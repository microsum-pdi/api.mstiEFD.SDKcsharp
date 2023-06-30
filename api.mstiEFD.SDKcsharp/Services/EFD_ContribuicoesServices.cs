using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels;

namespace api.mstiEFD.SDKcsharp.Services
{
    public class EFD_ContribuicoesServices : SDKGenericServices
    {
        private EfdConfigAmbienteSDK configAmbienteSDK;

        public EFD_ContribuicoesServices(EfdConfigAmbienteSDK configAmbienteSDK) : base(configAmbienteSDK)
        {
            this.configAmbienteSDK = configAmbienteSDK;
        }

        /// <summary>
        /// Cria uma solicitação para geração de um arquivo EFD Contribuições
        /// </summary>
        /// <returns></returns>
        public async Task<string> GerarArquivo(ConfigArquivoContribuicoesVM config)
        {
            string url = configAmbienteSDK.URL + "/api/efd_contribuicoes/gerararquivo/";

            string result;

            try
            {
                HttpResponseMessage response = await ExecutaPost(config, url);

                var resposta = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(resposta))
                {
                    return "";
                }
                else
                {
                    return resposta;
                }
            }
            catch (Exception ex)
            {
                string DetalheErro = "";
                DetalheErro += "Erro ao solicitar geração do arquivo EFD Contribuições." + " - " + ex.GetAllInnerExceptionMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }
    }
}