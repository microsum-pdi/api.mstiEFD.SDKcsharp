using api.mstiEFD.SDKcsharp.Enums;
using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.mstiEFD.SDKcsharp.Services
{
    public class NotasFiscaisServices : SDKGenericServices
    {
        private EfdConfigAmbienteSDK configAmbienteSDK;

        public NotasFiscaisServices(EfdConfigAmbienteSDK configAmbienteSDK) : base(configAmbienteSDK)
        {
            this.configAmbienteSDK = configAmbienteSDK;
        }

        /// <summary>
        /// Envia uma nota fiscal (NF-e ou NFC-e) para a fila, para ser salva no banco de dados
        /// </summary>
        /// <returns></returns>
        public async Task<EfdResultVM<string>> Add([FromBody] NotaFiscalVM notaFiscal)
        {
            #region Validações
            // Validações da estrutura da informação recebida na requisição
            if (notaFiscal == null)
            {
                return new EfdResultVM<string>()
                    .WithStatusCode(EHttpStatusCode.BadRequest)
                    .WithMessage(EfdResources.NotaFiscalInvalida);
            }

            // Validações de preenchimento
            if (notaFiscal.Invalid)
            {
                return new EfdResultVM<string>()
                    .WithStatusCode(EHttpStatusCode.BadRequest)
                    .WithMessages(notaFiscal.NotificationsToList());
            }
            #endregion

            string url = configAmbienteSDK.URL + "/api/notasfiscais/";

            EfdResultVM<string> result = new();

            try
            {
                HttpResponseMessage response = await ExecutaPost(notaFiscal, url);

                var resposta = JsonConvert.DeserializeObject<EfdResultVM<string>>(await response.Content.ReadAsStringAsync());

                if (resposta == null)
                {
                    result
                        .WithStatusCode(EHttpStatusCode.BadRequest)
                        .WithMessage("Erro ao salvar nota fiscal.");
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
                DetalheErro += "Erro ao salvar nota fiscal." + " - " + ex.GetAllInnerExceptionMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }
    }
}