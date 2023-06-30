using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels;
using Newtonsoft.Json;

namespace api.mstiEFD.SDKcsharp.Services
{
    public class HealthServices: SDKGenericServices
    {
        public EfdConfigAmbienteSDK _configAmbienteSDK { get; private set; }

        public HealthServices(EfdConfigAmbienteSDK configAmbienteSDK) : base(configAmbienteSDK)
        {
            _configAmbienteSDK = configAmbienteSDK;
        }

        /// <summary>
        /// Teste de funcionamento da API
        /// </summary>
        public async Task<EfdResultVM<string>> HealthCheck()
        {
            string url = $"{_configAmbienteSDK.URL}/api/health";
            EfdResultVM<string> result = new();

            try
            {
                HttpResponseMessage response = await ExecutaGet(url);
                var resposta = JsonConvert.DeserializeObject<EfdResultVM<string>>(await response.Content.ReadAsStringAsync());

                if (resposta == null)
                {
                    result
                        .WithStatusCode(Enums.EHttpStatusCode.BadRequest)
                        .WithMessage("Não foi possível estabelecer uma conexão com a API com os dados fornecidos.");
                }
                else
                {
                    result = resposta;
                }

                return result;
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao configurar o ambiente para uma conexão com a API.EFD." + " - " + ex.GetAllInnerExceptionMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }
    }
}
