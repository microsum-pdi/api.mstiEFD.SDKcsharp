using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace api.mstiEFD.SDKcsharp.Services.Shared
{
    public class SDKGenericServices
    {
        public readonly HttpClient httpClient;

        private EfdConfigAmbienteSDK configAmbienteSDK;

        public SDKGenericServices(EfdConfigAmbienteSDK configAmbienteSDK)
        {
            this.configAmbienteSDK = configAmbienteSDK;

            IServiceCollection services = new ServiceCollection();

            services.AddHttpClient();

            var serviceProvider = services.BuildServiceProvider();

            var HttpClientFactory = serviceProvider.GetService<IHttpClientFactory>();

            httpClient = HttpClientFactory.CreateClient();
        }

        protected async Task<HttpResponseMessage> ExecutaPut<T>(T dados, string url)
        {
            VerificaConfiguracaoAmbiente();
            var request = new HttpRequestMessage(new HttpMethod("PUT"), url);
            request.Headers.TryAddWithoutValidation("x-api-key", configAmbienteSDK.Token);
            request.Content = new StringContent(JsonConvert.SerializeObject(dados));
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            HttpResponseMessage response = await httpClient.SendAsync(request);
            return response;
        }


        protected async Task<HttpResponseMessage> ExecutaPost<T>(T dados, string url)
        {
            VerificaConfiguracaoAmbiente();
            var request = new HttpRequestMessage(new HttpMethod("POST"), url);
            request.Headers.TryAddWithoutValidation("x-api-key", configAmbienteSDK.Token);
            request.Content = new StringContent(JsonConvert.SerializeObject(dados));
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            HttpResponseMessage response = await httpClient.SendAsync(request);
            return response;
        }

        protected async Task<HttpResponseMessage> ExecutaGet(string url)
        {
            VerificaConfiguracaoAmbiente();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.AddXApiKey(configAmbienteSDK.Token);

            HttpResponseMessage response = await httpClient.GetAsync(url);
            return response;
        }

        protected async Task<HttpResponseMessage> ExecutaDelete(string url)
        {
            VerificaConfiguracaoAmbiente();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.AddXApiKey(configAmbienteSDK.Token);

            HttpResponseMessage response = await httpClient.DeleteAsync(url);
            return response;
        }

        private void VerificaConfiguracaoAmbiente()
        {
            if (configAmbienteSDK == null ||
               string.IsNullOrEmpty(configAmbienteSDK?.Token) ||
               string.IsNullOrEmpty(configAmbienteSDK?.URL))
            {
                throw new Exception("Necessário executar a configuração do ambiente (ConfigAmbienteSDKServices.ConfigurarAmbiente(new ConfigAmbienteSDK())), antes de comunicar com a API ami.EFD.");
            }
        }
    }
}
