using api.mstiEFD.SDKcsharp.Enums;
using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels;
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