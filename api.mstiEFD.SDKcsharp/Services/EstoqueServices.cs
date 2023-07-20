using api.mstiEFD.SDKcsharp.Enums;
using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels;
using api.mstiEFD.SDKcsharp.ViewModels.Estoque;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.mstiEFD.SDKcsharp.Services
{
    public class EstoqueServices : SDKGenericServices
    {
        private EfdConfigAmbienteSDK configAmbienteSDK;

        public EstoqueServices(EfdConfigAmbienteSDK configAmbienteSDK) : base(configAmbienteSDK)
        {
            this.configAmbienteSDK = configAmbienteSDK;
        }

        /// <summary>
        /// Atualiza o estoque dos produtos (máximo 200 produtos por requisição)
        /// </summary>
        /// <returns></returns>
        public async Task<EfdResultVM<string>> Atualizar([FromBody] EstoqueVM produtos)
        {
            #region Validações
            // Validações da estrutura da informação recebida na requisição
            if (produtos == null)
            {
                return new EfdResultVM<string>()
                    .WithStatusCode(EHttpStatusCode.BadRequest)
                    .WithMessage(EfdResources.EstoqueInvalido);
            }

            produtos.ExecutaValidacoes();

            // Validações de preenchimento
            if (produtos.Invalid)
            {
                return new EfdResultVM<string>()
                    .WithStatusCode(EHttpStatusCode.BadRequest)
                    .WithMessages(produtos.NotificationsToList());
            }
            #endregion

            string url = configAmbienteSDK.URL + "/api/estoque/";

            EfdResultVM<string> result = new();

            try
            {
                HttpResponseMessage response = await ExecutaPost(produtos, url);

                var resposta = JsonConvert.DeserializeObject<EfdResultVM<string>>(await response.Content.ReadAsStringAsync());

                if (resposta == null)
                {
                    result
                        .WithStatusCode(EHttpStatusCode.BadRequest)
                        .WithMessage("Erro ao atualizar o estoque.");
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
                DetalheErro += "Erro ao atualizar o estoque." + " - " + ex.GetAllInnerExceptionMessage() + "\n";
                DetalheErro += "Url: " + url + "\n";

                throw new Exception(DetalheErro);
            }
        }
    }
}