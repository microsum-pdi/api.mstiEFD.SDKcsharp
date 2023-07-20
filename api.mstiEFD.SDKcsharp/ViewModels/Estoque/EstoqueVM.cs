using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels.Notifications;
using NJsonSchema.Annotations;

namespace api.mstiEFD.SDKcsharp.ViewModels.Estoque
{
    [JsonSchemaExtensionData("example",
    @" {
       ""Produtos"": [
          {
             ""Codigo"": ""001"",
             ""CodigoBarras"": ""7898938236034"",
             ""Descricao"": ""Produto teste 1"",
             ""Quantidade"": 65,
             ""ValorUnitario"": 1083,
             ""Unidade"": {
                ""Codigo"": ""001"",
                ""Simbolo"": ""UN""
             },
             ""Propriedade"": ""2"",
             ""Proprietario"": {
                ""Codigo"": ""01"",
                ""Nome"": ""Fornecedor teste 01"",
                ""Cod_Pais"": ""1058"",
                ""CNPJ"": ""05.462.662/0001-05"",
                ""CPF"": """",
                ""IE"": ""10.358.086-7"",
                ""SUFRAMA"": """",
                ""EnderecoUFSigla"": ""GO"",
                ""EnderecoUFCodigo"": ""52"",
                ""EnderecoCidadeCodigo"": ""5208707"",
                ""EnderecoLogradouro"": ""Rua"",
                ""EnderecoNumero"": ""90"",
                ""EnderecoComplemento"": ""90"",
                ""EnderecoBairro"": ""Setor Sul""
             },
             ""Tipo"": ""00"",
             ""Origem"": 0,
             ""NCM"": ""33072090"",
             ""CEST"": """",
             ""ICMS_Aliquota"": 17,
             ""ContaContabil"": {
                ""Codigo"": ""3"",
                ""DataInclusao"": ""2023-01-01"",
                ""Tipo"": ""S"",
                ""Nivel"": 3,
                ""NomeContaAnalitica"": ""INVENTÁRIO"",
                ""CodigoContaReceitaFederal"": """"
             },
             ""ValorImpostoDeRenda"": 0
          }
       ]
    }")]
    public class EstoqueVM : EfdNotificavelVM
    {
        public EstoqueVM()
        { }

        public EstoqueVM(List<ProdutoVM> produtos)
        {
            Produtos = produtos;

            ExecutaValidacoes();
        }

        public void ExecutaValidacoes()
        {
            if (Produtos.Count > 200)
            {
                AddNotification("Estoque.Produtos", EfdResources.EstoqueQuantidadeDeItensInvalida);
            }

            for (int i = 0; i < Produtos.Count; i++)
            {
                if (string.IsNullOrEmpty(Produtos[i].Codigo))
                {
                    AddNotification("Produto[" + i + "].Codigo ('" + Produtos[i].Codigo + "')", EfdResources.NotaFiscalProdutoCodigoNaoInformado);
                }

                if (string.IsNullOrEmpty(Produtos[i].Descricao))
                {
                    AddNotification("Produto[" + i + "].Descricao ('" + Produtos[i].Descricao + "')", EfdResources.NotaFiscalProdutoDescricaoNaoInformada);
                }

                if (Produtos[i].Quantidade < 0)
                {
                    AddNotification("Produto[" + i + "].Quantidade ('" + Produtos[i].Quantidade + "')", EfdResources.NotaFiscalProdutoQuantidadeInvalida);
                }

                if (Produtos[i].ValorUnitario < 0)
                {
                    AddNotification("Produto[" + i + "].ValorUnitario ('" + Produtos[i].ValorUnitario + "')", EfdResources.NotaFiscalProdutoValorInvalido);
                }

                if (Produtos[i].Unidade == null)
                {
                    AddNotification("Produto[" + i + "].Unidade ('" + Produtos[i].Unidade + "')", EfdResources.NotaFiscalProdutoUnidadeNaoInformada);
                }
                else
                {
                    //Adiciona a unidade do item na lista de itens validáveis
                    AddNotifications(Produtos[i].Unidade);
                }

                if (!StringServices.ValorContidoNaLista(Produtos[i].Propriedade, IND_PROP))
                {
                    AddNotification("Produto[" + i + "].Propriedade ('" + Produtos[i].Propriedade + "')", EfdResources.EstoqueIndicadorPropriedadeInvalido + string.Join(", ", IND_PROP));
                }

                //Adiciona o proprietário do item na lista de itens validáveis
                if (Produtos[i].Proprietario != null)
                {
                    AddNotifications(Produtos[i].Proprietario);
                }

                if (!StringServices.ValorContidoNaLista(Produtos[i].Tipo, TIPO_ITEM))
                {
                    AddNotification("Produto[" + i + "].Tipo ('" + Produtos[i].Tipo + "')", EfdResources.NotaFiscalProdutoTipoInvalido + string.Join(", ", TIPO_ITEM));
                }

                if (!StringServices.ValorContidoNaLista(Produtos[i].Origem, ORIGEM_MERCADORIA))
                {
                    AddNotification("Produto[" + i + "].Origem ('" + Produtos[i].Origem + "')", EfdResources.NotaFiscalProdutoOrigemInvalida + string.Join(", ", ORIGEM_MERCADORIA));
                }

                if (string.IsNullOrEmpty(Produtos[i].NCM) || Produtos[i].NCM.Length != 8 || !Produtos[i].NCM.IsNumeric())
                {
                    AddNotification("Produto[" + i + "].NCM ('" + Produtos[i].NCM + "')", EfdResources.NotaFiscalProdutoNCMNaoInformado);
                }

                if (!string.IsNullOrEmpty(Produtos[i].CEST) & (Produtos[i]?.CEST?.Length != 7 || !Produtos[i].CEST.IsNumeric()))
                {
                    AddNotification("Produto[" + i + "].CEST ('" + Produtos[i].CEST + "')", EfdResources.NotaFiscalProdutoCESTIncorreto);
                }

                if (Produtos[i].ICMS_Aliquota < 0)
                {
                    AddNotification("Produto[" + i + "].ICMS_Aliquota ('" + Produtos[i].ICMS_Aliquota + "')", EfdResources.EstoqueAliquotaInvalida);
                }

                //Adiciona a conta contábil do item na lista de itens validáveis
                if (Produtos[i].ContaContabil != null)
                {
                    AddNotifications(Produtos[i].ContaContabil);
                }

                if (Produtos[i].ValorImpostoDeRenda != null && Produtos[i].ValorImpostoDeRenda < 0)
                {
                    AddNotification("Produto[" + i + "].ValorImpostoDeRenda ('" + Produtos[i].ValorImpostoDeRenda + "')", EfdResources.EstoqueValorIRInvalido);
                }
            }
        }

        /// <summary>
        /// Lote de produtos a terem seus estoques atualizados (máximo 200 itens por requisição)
        /// </summary>
        public List<ProdutoVM> Produtos { get; set; }
    }   
}