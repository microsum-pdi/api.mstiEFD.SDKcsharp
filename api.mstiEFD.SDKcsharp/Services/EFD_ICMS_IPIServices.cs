using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels;

namespace api.mstiEFD.SDKcsharp.Services
{
    public class EFD_ICMS_IPIServices : SDKGenericServices
    {
        private EfdConfigAmbienteSDK configAmbienteSDK;

        public EFD_ICMS_IPIServices(EfdConfigAmbienteSDK configAmbienteSDK) : base(configAmbienteSDK)
        {
            this.configAmbienteSDK = configAmbienteSDK;
        }

        /// <summary>
        /// Cria uma solicitação para geração de um arquivo EFD ICMS-IPI
        /// </summary>
        /// <returns></returns>
        public async Task<string> GerarArquivo(ConfigArquivoEFD_ICMS_IPI_VM config)
        {
            string url = configAmbienteSDK.URL + "/api/efd_icms_ipi/gerararquivo/";

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
                DetalheErro += "Erro ao solicitar geração do arquivo EFD ICMS-IPI." + " - " + ex.GetAllInnerExceptionMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }
    }
}