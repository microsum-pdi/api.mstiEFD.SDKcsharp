using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels.Notifications;
using NJsonSchema.Annotations;

namespace api.mstiEFD.SDKcsharp.ViewModels
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
        {}

        public EstoqueVM(List<ProdutoVM> produtos)
        {
            Produtos = produtos;

            ExecutaValidacoes();
        }

        private void ExecutaValidacoes()
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

    public class ProdutoVM
    {
        /// <summary>
        /// COD_ITEM - Código do item (campo 02 do Registro 0200)
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// COD_BARRA - Representação alfanumérico do código de barra do produto, se houver
        /// </summary>
        public string CodigoBarras { get; set; }

        /// <summary>
        /// DESCR_COMPL - Descrição complementar do item como adotado no documento fiscal
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// QTD - Quantidade do item
        /// </summary>
        public decimal Quantidade { get; set; }

        /// <summary>
        /// VL_ITEM - Valor unitário do item
        /// </summary>
        public decimal ValorUnitario { get; set; }

        /// <summary>
        /// UNID - Unidade do item (Campo 02 do registro 0190)
        /// </summary>
        public NotaFiscalProdutoUnidadeVM Unidade { get; set; }

        /// <summary> 
        /// IND_PROP - Indicador de propriedade/posse do item: 
        /// 
        /// <para>0 - Item de propriedade do informante e em seu poder;</para> 
        /// <para>1 - Item de propriedade do informante em posse de terceiros;</para> 
        /// <para>2- Item de propriedade de terceiros em posse do informante.</para>             
        /// </summary> 
        public string Propriedade { get; set; }

        /// <summary>
        /// COD_PART - Código do participante (campo 02 do Registro 0150): - proprietário/possuidor que não seja o informante do arquivo
        /// </summary>
        public ParticipanteVM Proprietario { get; set; }

        /// <summary> 
        /// TIPO_ITEM - Tipo do item – Atividades Industriais, Comerciais e Serviços: 
        /// 
        /// <para>00 – Mercadoria para Revenda;</para> 
        /// <para>01 – Matéria-prima;</para> 
        /// <para>02 – Embalagem;</para> 
        /// <para>03 – Produto em Processo;</para> 
        /// <para>04 – Produto Acabado;</para> 
        /// <para>05 – Subproduto;</para> 
        /// <para>06 – Produto Intermediário;</para> 
        /// <para>07 – Material de Uso e Consumo;</para> 
        /// <para>08 – Ativo Imobilizado;</para> 
        /// <para>09 – Serviços;</para> 
        /// <para>10 – Outros insumos;</para> 
        /// <para>99 – Outras</para> 
        /// </summary> 
        public string Tipo { get; set; }

        /// <summary> 
        /// Origem da mercadoria
        /// 
        /// <para>0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8</para> 
        /// <para>1 - Estrangeira - Importação direta, exceto a indicada no código 6</para> 
        /// <para>2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7</para> 
        /// <para>3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% e inferior ou igual a 70%</para> 
        /// <para>4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos Ajustes</para> 
        /// <para>5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%</para> 
        /// <para>6 - Estrangeira - Importação direta, sem similar nacional, constante em lista da CAMEX e gás natural</para> 
        /// <para>7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante lista CAMEX e gás natural</para> 
        /// <para>8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70%</para> 
        /// </summary> 
        public string Origem { get; set; }

        /// <summary>
        /// NCM - Nomenclatura Comum no Mercosul
        /// </summary>
        public string NCM { get; set; }

        /// <summary>
        /// CEST - Código Especificador de Substituição Tributária
        /// </summary>
        public string? CEST { get; set; }

        /// <summary>
        /// ALIQ_ICMS - Alíquota do ICMS
        /// </summary>
        public decimal ICMS_Aliquota { get; set; }

        /// <summary>
        /// COD_CTA - Código da conta analítica contábil debitada/creditada
        /// </summary>
        public ContaContabilVM? ContaContabil { get; set; }

        /// <summary>
        /// VL_ITEM_IR - Valor do item para efeitos do Imposto de Renda
        /// </summary>
        public decimal? ValorImpostoDeRenda { get; set; }
    }
}