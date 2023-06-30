using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels.Notifications;
using api.mstiEFD.SDKcsharp.ViewModels.ValueObjects;
using NJsonSchema.Annotations;

namespace api.mstiEFD.SDKcsharp.ViewModels
{
    [JsonSchemaExtensionData("example",
@" {
   ""Operacao"": 0,
   ""TipoEmissao"": ""1"",
   ""Finalidade"": ""1"",
   ""NaturezaOperacao"": {
     ""Codigo"": ""001"",
     ""Descricao"": ""Compra para comercialização""
   },
   ""Participante"": {
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
   ""ModeloDocumento"": ""55"",
   ""Situacao"": ""01"",
   ""Serie"": 1,
   ""Numero"": 1,
   ""Chave"": ""42210780078934000185550010000097511171825601"",
   ""DataEmissao"": ""2023-05-16"",
   ""DataEntradaSaida"": ""2023-05-16"",
   ""ValorTotal"": 2231.18,
   ""TipoPagamento"": 1,
   ""ValorDesconto"": 113.22,
   ""ValorAbatimento"": 0,
   ""ValorMercadorias"": 2311.18,
   ""TipoTransporte"": 0,
   ""ValorFrete"": 0,
   ""ValorSeguro"": 0,
   ""ValorDespesas"": 0,
   ""ICMS_BC"": 0,
   ""ICMS_Valor"": 0,
   ""ICMS_ST_BC_Valor"": 0,
   ""ICMS_ST_Retido_Valor"": 0,
   ""IPI_Valor"": 0,
   ""PIS_Valor"": 0,
   ""PIS_ST_Valor"": 0,
   ""COFINS_Valor"": 0,
   ""COFINS_ST_Valor"": 0,
   ""Transporte"": {
     ""Transportador"": {
       ""Codigo"": ""32"",
       ""Nome"": ""TNT MERCURIO C E E EXS LTDA"",
       ""Cod_Pais"": ""1058"",
       ""CNPJ"": ""95.591.723/0038-00"",
       ""CPF"": """",
       ""IE"": ""108254280116"",
       ""SUFRAMA"": """",
       ""EnderecoUFSigla"": ""SP"",
       ""EnderecoUFCodigo"": ""35"",
       ""EnderecoCidadeCodigo"": ""3550308"",
       ""EnderecoLogradouro"": ""AVENIDA MARGINAL DIREITA DO TIETÊ"",
       ""EnderecoNumero"": """",
       ""EnderecoComplemento"": """",
       ""EnderecoBairro"": ""VILA JAGUARA""
     },
     ""ModeloDocumento"": ""57"",
     ""Situacao"": ""00"",
     ""Serie"": 1,
     ""Numero"": 8736951,
     ""Chave"": ""35230195591723003800570000087369511035524969"",
     ""DataEmissao"": ""2023-01-09"",
     ""DataPrestacao"": ""2023-01-09"",
     ""ValorTotal"": 51.96,
     ""ICMS_BC"": 51.96,
     ""ICMS_ST"": ""00"",
     ""ICMS_Valor"": 49.25,
     ""CFOP"": ""5352"",
     ""CodigoContaContabil"": ""18"",
     ""PIS_CST"": ""99"",
     ""PIS_BC"": 51.96,
     ""PIS_Aliquota"": 0,
     ""PIS_Valor"": 0,
     ""COFINS_CST"": ""99"",
     ""COFINS_BC"": 51.96,
     ""COFINS_Aliquota"": 0,
     ""COFINS_Valor"": 0,
     ""ContaContabil"": {
       ""Codigo"": ""18"",
       ""DataInclusao"": ""2023-01-01"",
       ""Tipo"": ""S"",
       ""Nivel"": 3,
       ""NomeContaAnalitica"": ""PAGAMENTO TRANSPORTE"",
       ""CodigoContaReceitaFederal"": """"
     }
   },
   ""Produtos"": [
     {
       ""Numero"": 1,
       ""Codigo"": ""001"",
       ""CodigoBarras"": ""7898938236034"",
       ""Descricao"": ""Produto teste 1"",
       ""Quantidade"": 24,
       ""Unidade"": {
         ""Codigo"": ""001"",
         ""Simbolo"": ""UN""
       },
       ""Tipo"": ""00"",
       ""Origem"": 0,
       ""NCM"": ""33072090"",
       ""CEST"": """",
       ""ValorTotal"": 1083,
       ""Desconto"": 57,
       ""Movimentado"": 0,
       ""CFOP"": ""2102"",
       ""ValorFrete"": 0,
       ""ValorSeguro"": 0,
       ""ValorDespesas"": 0,
       ""ICMS_CST"": ""101"",
       ""ICMS_BC"": 1123.28,
       ""ICMS_Aliquota"": 4,
       ""ICMS_Valor"": 0,
       ""ICMS_ST_BC"": 0,
       ""ICMS_ST_Aliquota"": 0,
       ""ICMS_ST_Valor"": 0,
       ""ICMS_DIFAL_vBCUFDest"": 0,
       ""ICMS_DIFAL_vBCFCPUFDest"": 0,
       ""ICMS_DIFAL_pFCPUFDest"": 0,
       ""ICMS_DIFAL_pICMSUFDest"": 0,
       ""ICMS_DIFAL_pICMSInter"": 0,
       ""ICMS_DIFAL_vFCPUFDest"": 0,
       ""ICMS_DIFAL_vICMSUFDest"": 0,
       ""ICMS_DIFAL_vICMSUFRemet"": 0,
       ""IPI_Apuracao"": 0,
       ""IPI_CST"": ""49"",
       ""IPI_Enquadramento"": """",
       ""IPI_BC"": 0,
       ""IPI_Aliquota"": 0,
       ""IPI_Valor"": 0,
       ""PIS_CST"": ""99"",
       ""PIS_BC"": 0,
       ""PIS_Aliquota"": 0,
       ""PIS_BC_Quantidade"": 0,
       ""PIS_Aliquota_Reais"": 0,
       ""PIS_Valor"": 0,
       ""COFINS_CST"": ""99"",
       ""COFINS_BC"": 0,
       ""COFINS_Aliquota"": 0,
       ""COFINS_BC_Quantidade"": 0,
       ""COFINS_Aliquota_Reais"": 0,
       ""COFINS_Valor"": 0,
       ""ContaContabil"": {
         ""Codigo"": ""8"",
         ""DataInclusao"": ""2023-01-01"",
         ""Tipo"": ""S"",
         ""Nivel"": 3,
         ""NomeContaAnalitica"": ""COMPRAS E SERVIÇOS"",
         ""CodigoContaReceitaFederal"": """"
       },
       ""ValorAbatimento"": 0
     },
     {
       ""Numero"": 2,
       ""Codigo"": ""002"",
       ""CodigoBarras"": ""7894900911510"",
       ""Descricao"": ""Produto teste 2"",
       ""Quantidade"": 24,
       ""Unidade"": {
         ""Codigo"": ""002"",
         ""Simbolo"": ""MT""
       },
       ""Tipo"": ""00"",
       ""Origem"": 0,
       ""NCM"": ""33072090"",
       ""CEST"": """",
       ""ValorTotal"": 1068.18,
       ""Desconto"": 56.22,
       ""Movimentado"": 0,
       ""CFOP"": ""2102"",
       ""ValorFrete"": 0,
       ""ValorSeguro"": 0,
       ""ValorDespesas"": 0,
       ""ICMS_CST"": ""101"",
       ""ICMS_BC"": 1107.9,
       ""ICMS_Aliquota"": 4,
       ""ICMS_Valor"": 0,
       ""ICMS_ST_BC"": 0,
       ""ICMS_ST_Aliquota"": 0,
       ""ICMS_ST_Valor"": 0,
       ""ICMS_DIFAL_vBCUFDest"": 0,
       ""ICMS_DIFAL_vBCFCPUFDest"": 0,
       ""ICMS_DIFAL_pFCPUFDest"": 0,
       ""ICMS_DIFAL_pICMSUFDest"": 0,
       ""ICMS_DIFAL_pICMSInter"": 0,
       ""ICMS_DIFAL_vFCPUFDest"": 0,
       ""ICMS_DIFAL_vICMSUFDest"": 0,
       ""ICMS_DIFAL_vICMSUFRemet"": 0,
       ""IPI_Apuracao"": 0,
       ""IPI_CST"": ""49"",
       ""IPI_Enquadramento"": """",
       ""IPI_BC"": 0,
       ""IPI_Aliquota"": 0,
       ""IPI_Valor"": 0,
       ""PIS_CST"": ""99"",
       ""PIS_BC"": 0,
       ""PIS_Aliquota"": 0,
       ""PIS_BC_Quantidade"": 0,
       ""PIS_Aliquota_Reais"": 0,
       ""PIS_Valor"": 0,
       ""COFINS_CST"": ""99"",
       ""COFINS_BC"": 0,
       ""COFINS_Aliquota"": 0,
       ""COFINS_BC_Quantidade"": 0,
       ""COFINS_Aliquota_Reais"": 0,
       ""COFINS_Valor"": 0,
       ""ContaContabil"": """",
       ""ContaContabil"": {
         ""Codigo"": ""8"",
         ""DataInclusao"": ""2023-01-01"",
         ""Tipo"": ""S"",
         ""Nivel"": 3,
         ""NomeContaAnalitica"": ""COMPRAS E SERVIÇOS"",
         ""CodigoContaReceitaFederal"": """"
       },
       ""ValorAbatimento"": 0
     }
   ]
 }")]
    public class NotaFiscalVM : EfdNotificavelVM
    {
        public NotaFiscalVM()
        {}

        public NotaFiscalVM(
            string operacao, string tipoEmissao, string finalidade, NotaFiscalProdutoNaturezaOperacaoVM naturezaOperacao,
            ParticipanteVM participante, string modeloDocumento, string situacao, int serie,
            int numero, string chave, string dataEmissao, string dataEntradaSaida, decimal valorTotal,
            string tipoPagamento, decimal valorDesconto, decimal valorAbatimento, decimal valorMercadorias,
            string tipoTransporte, decimal valorFrete, decimal valorSeguro, decimal valorDespesas, decimal iCMS_BC,
            decimal iCMS_Valor, decimal iCMS_ST_BC_Valor, decimal iCMS_ST_Retido_Valor,
            decimal iPI_Valor, decimal pIS_Valor, decimal pIS_ST_Valor, decimal cOFINS_Valor, decimal cOFINS_ST_Valor,
            TransporteVM transporte, List<NotaFiscalProdutoVM> produtos)
        {
            Operacao = operacao;
            TipoEmissao = tipoEmissao;
            Finalidade = finalidade;
            NaturezaOperacao = naturezaOperacao;
            Participante = participante;
            ModeloDocumento = modeloDocumento;
            Situacao = situacao;
            Serie = serie;
            Numero = numero;
            Chave = chave;
            DataEmissao = dataEmissao;
            DataEntradaSaida = dataEntradaSaida;
            ValorTotal = valorTotal;
            TipoPagamento = tipoPagamento;
            ValorDesconto = valorDesconto;
            ValorAbatimento = valorAbatimento;
            ValorMercadorias = valorMercadorias;
            TipoTransporte = tipoTransporte;
            ValorFrete = valorFrete;
            ValorSeguro = valorSeguro;
            ValorDespesas = valorDespesas;
            ICMS_BC = iCMS_BC;
            ICMS_Valor = iCMS_Valor;
            ICMS_ST_BC_Valor = iCMS_ST_BC_Valor;
            ICMS_ST_Retido_Valor = iCMS_ST_Retido_Valor;
            IPI_Valor = iPI_Valor;
            PIS_Valor = pIS_Valor;
            PIS_ST_Valor = pIS_ST_Valor;
            COFINS_Valor = cOFINS_Valor;
            COFINS_ST_Valor = cOFINS_ST_Valor;
            Transporte = transporte;
            Produtos = produtos;

            ExecutaValidacoes();

            //Adiciona a natureza da nota fiscal na lista de itens validáveis
            if (naturezaOperacao != null)
            {
                AddNotifications(naturezaOperacao);
            }

            //Adiciona o participante da nota fiscal na lista de itens validáveis
            if (participante != null)
            {
                AddNotifications(participante);
            }

            //Adiciona o transporte da nota fiscal na lista de itens validáveis
            if (transporte != null)
            {
                AddNotifications(transporte);
            }

            //Adiciona os produtos na lista de itens validáveis
            if (produtos != null && produtos?.Count > 0)
            {
                foreach (var produto in produtos)
                {
                    AddNotifications(produto);
                }
            }
        }

        private void ExecutaValidacoes()
        {
            if (!StringServices.ValorContidoNaLista(Operacao, IND_OPER))
            {
                AddNotification("Operacao ('" + Operacao + "')", EfdResources.NotaFiscalOperacaoInvalida + string.Join(", ", IND_OPER));
            }

            if (!StringServices.ValorContidoNaLista(TipoEmissao, IND_EMIT))
            {
                AddNotification("TipoEmissao ('" + TipoEmissao + "')", EfdResources.NotaFiscalTipoEmissaoInvalido + string.Join(", ", IND_EMIT));
            }

            if (!StringServices.ValorContidoNaLista(Finalidade, FIN_NFE))
            {
                AddNotification("Finalidade ('" + Finalidade + "')", EfdResources.NotaFiscalFinalidadeInvalida + string.Join(", ", FIN_NFE));
            }

            if (NaturezaOperacao == null)
            {
                AddNotification("NaturezaOperacao", EfdResources.NotaFiscalNaturezaOperacaoNaoInformada);
            }

            if (Participante == null)
            {
                AddNotification("Participante", EfdResources.NotaFiscalParticipanteNaoInformado);
            }

            if (!StringServices.ValorContidoNaLista(ModeloDocumento, COD_MOD))
            {
                AddNotification("ModeloDocumento ('" + ModeloDocumento + "')", EfdResources.NotaFiscalModeloInvalido + string.Join(", ", COD_MOD));
            }

            if (!StringServices.ValorContidoNaLista(Situacao, COD_SIT))
            {
                AddNotification("Situacao ('" + Situacao + "')", EfdResources.NotaFiscalSituacaoInvalida + string.Join(", ", COD_SIT));
            }

            if (Serie < 1 || Serie > 999)
            {
                AddNotification("Série ('" + Serie + "')", EfdResources.NotaFiscalSerieInvalida);
            }

            if (Numero < 1 || Numero > 999999999)
            {
                AddNotification("Número ('" + Numero + "')", EfdResources.NotaFiscalNumeroInvalido);
            }

            if (Chave == null || !Chave.IsNumeric() || Chave.Length != 44)
            {
                AddNotification("Chave ('" + Chave + "')", EfdResources.NotaFiscalChaveDeAcessoInvalida);
            }

            if (!DateTimeServices.TestaData_AAAA_MM_DD(DataEmissao))
            {
                AddNotification("DataEmissao ('" + DataEmissao + "')", EfdResources.NotaFiscalDataEmissaoInvalida);
            }

            if (!DateTimeServices.TestaData_AAAA_MM_DD(DataEntradaSaida))
            {
                AddNotification("DataEntradaSaida ('" + DataEntradaSaida + "')", EfdResources.NotaFiscalDataEntradaSaidaInvalida);
            }

            if (!StringServices.ValorContidoNaLista(TipoPagamento, IND_PGTO))
            {
                AddNotification("TipoPagamento ('" + TipoPagamento + "')", EfdResources.NotaFiscalTipoPagamentoInvalida + string.Join(", ", IND_PGTO));
            }

            if (!StringServices.ValorContidoNaLista(TipoTransporte, IND_FRT))
            {
                AddNotification("TipoTransporte ('" + TipoTransporte + "')", EfdResources.NotaFiscalTipoTransporteInvalida + string.Join(", ", IND_FRT));
            }

        }

        /// <summary> 
        /// IND_OPER - Indicador do tipo de operação:
        /// 
        /// <para>0 - Entrada</para> 
        /// <para>1 - Saída</para> 
        /// </summary> 
        public string Operacao { get; set; }

        /// <summary> 
        /// IND_EMIT - Indicador do emitente do documento fiscal:
        /// 
        /// <para>0 - Emissão própria</para> 
        /// <para>1 - Terceiros</para> 
        /// </summary> 
        public string TipoEmissao { get; set; }

        /// <summary> 
        /// finNFe - Finalidade da emissão da NF-e:
        /// 
        /// <para>1 - Normal;</para> 
        /// <para>2 - Complementar;</para> 
        /// <para>3 - Ajuste;</para> 
        /// <para>4 - Devolução/Retorno</para> 
        /// </summary> 
        public string Finalidade { get; set; }

        /// <summary>
        /// COD_NAT - Código da natureza da operação
        /// </summary>
        public NotaFiscalProdutoNaturezaOperacaoVM NaturezaOperacao { get; set; }

        /// <summary> 
        /// Participante - Entidade envolvida na operação
        /// 
        /// <para> - **Emitente** do documento ou **remetente** das mercadorias, no caso de entradas</para> 
        /// <para> - **Cliente**, ou **destinatário**, no caso de saídas</para> 
        /// <para> - **Transportador**, quando informado na propriedade [NotaFiscal.Transporte.Transportador]</para> 
        /// </summary> 
        public ParticipanteVM Participante { get; set; }

        /// <summary> 
        /// COD_MOD - Código do modelo do documento fiscal
        /// 
        /// <para>01 - Nota Fiscal</para> 
        /// <para>1B - Nota Fiscal Avulsa</para> 
        /// <para>02 - Nota Fiscal de Venda a Consumidor</para> 
        /// <para>2D - Cupom Fiscal emitido por ECF</para> 
        /// <para>2E - Bilhete de Passagem emitido por ECF</para> 
        /// <para>04 - Nota Fiscal de Produtor</para> 
        /// <para>06 - Nota Fiscal/Conta de Energia Elétrica</para> 
        /// <para>07 - Nota Fiscal de Serviço de Transporte</para> 
        /// <para>08 - Conhecimento de Transporte Rodoviário de Cargas</para> 
        /// <para>8B - Conhecimento de Transporte de Cargas Avulso</para> 
        /// <para>09 - Conhecimento de Transporte Aquaviário de Cargas</para> 
        /// <para>10 - Conhecimento Aéreo</para> 
        /// <para>11 - Conhecimento de Transporte Ferroviário de Cargas</para> 
        /// <para>13 - Bilhete de Passagem Rodoviário</para> 
        /// <para>14 - Bilhete de Passagem Aquaviário</para> 
        /// <para>15 - Bilhete de Passagem e Nota de Bagagem</para> 
        /// <para>17 - Despacho de Transporte</para> 
        /// <para>16 - Bilhete de Passagem Ferroviário</para> 
        /// <para>18 - Resumo de Movimento Diário</para> 
        /// <para>20 - Ordem de Coleta de Cargas</para> 
        /// <para>21 - Nota Fiscal de Serviço de Comunicação</para> 
        /// <para>22 - Nota Fiscal de Serviço de Telecomunicação</para> 
        /// <para>23 - GNRE</para> 
        /// <para>24 - Autorização de Carregamento e Transporte</para> 
        /// <para>25 - Manifesto de Carga</para> 
        /// <para>26 - Conhecimento de Transporte Multimodal de Cargas</para> 
        /// <para>27 - Nota Fiscal de Transporte Ferroviário de Cargas</para> 
        /// <para>28 - Nota Fiscal/Conta de Fornecimento de Gás Canalizado</para> 
        /// <para>29 - Nota Fiscal/Conta de Fornecimento de Água Canalizada</para> 
        /// <para>30 - Bilhete/Recibo do Passageiro</para> 
        /// <para>55 - Nota Fiscal Eletrônica</para> 
        /// <para>57 - Conhecimento de Transporte Eletrônico – CT-e</para> 
        /// <para>59 - Cupom Fiscal Eletrônico – CF-e</para> 
        /// <para>60 - Cupom Fiscal Eletrônico CF-e-ECF</para> 
        /// <para>65 - Nota Fiscal Eletrônica ao Consumidor Final – NFC-e</para> 
        /// <para>67 - Conhecimento de Transporte Eletrônico para Outros Serviços - CT-e OS</para> 
        /// <para>63 - Bilhete de Passagem Eletrônico - BP-e</para> 
        /// <para>66 - Nota Fiscal de Energia Elétrica Eletrônica - NF3e</para> 
        /// </summary> 
        public string ModeloDocumento { get; set; }

        /// <summary> 
        /// COD_SIT - Código da situação do documento fiscal
        /// 
        /// <para>00 - Documento regular</para> 
        /// <para>01 - Escrituração extemporânea de documento regular</para> 
        /// <para>02 - Documento cancelado</para> 
        /// <para>03 - Escrituração extemporânea de documento cancelado</para> 
        /// <para>04 - NF-e, NFC-e ou CT-e - denegado</para> 
        /// <para>05 - NF-e, NFC-e ou CT-e - Numeração inutilizada</para> 
        /// <para>06 - Documento Fiscal Complementar</para> 
        /// <para>07 - Escrituração extemporânea de documento complementar</para> 
        /// <para>08 - Documento Fiscal emitido com base em Regime Especial ou Norma Específica</para> 
        /// </summary> 
        public string Situacao { get; set; }

        /// <summary>
        /// SER - Série do documento fiscal - Formato: "000"
        /// </summary>
        public int Serie { get; set; }

        /// <summary>
        /// NUM_DOC - Número do documento fiscal
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// CHV_NFE - Chave da Nota Fiscal Eletrônica
        /// </summary>
        public string Chave { get; set; }

        /// <summary>
        /// DT_DOC - Data da emissão do documento fiscal - Formato: AAAA-MM-DD
        /// </summary>
        public string DataEmissao { get; set; }

        /// <summary>
        /// DT_E_S - Data da entrada ou da saída - Formato: AAAA-MM-DD
        /// </summary>
        public string DataEntradaSaida { get; set; }

        /// <summary>
        /// VL_DOC - Valor total do documento fiscal
        /// </summary>
        public decimal ValorTotal { get; set; }

        /// <summary> 
        /// IND_PGTO - Indicador do tipo de pagamento
        /// 
        /// <para>0 - À vista</para> 
        /// <para>1 - A prazo</para> 
        /// <para>2 - Outros</para> 
        /// </summary> 
        public string TipoPagamento { get; set; }

        /// <summary>
        /// VL_DESC - Valor total do desconto
        /// </summary>
        public decimal ValorDesconto { get; set; }

        /// <summary>
        /// VL_ABAT_NT - Abatimento não tributado e não comercial. 
        /// 
        /// Por exemplo: Desconto ICMS nas remessas para ZFM.
        /// </summary>
        public decimal ValorAbatimento { get; set; }

        /// <summary>
        /// VL_MERC - Valor total das mercadorias e serviços        
        /// </summary>
        public decimal ValorMercadorias { get; set; }

        /// <summary> 
        /// IND_FRT - Indicador do tipo do frete:
        /// 
        /// <para>0 - Contratação do Frete por conta do Remetente(CIF)</para> 
        /// <para>1 - Contratação do Frete por conta do Destinatário(FOB)</para> 
        /// <para>2 - Contratação do Frete por conta de Terceiros</para> 
        /// <para>3 - Transporte Próprio por conta do Remetente</para> 
        /// <para>4 - Transporte Próprio por conta do Destinatário</para> 
        /// <para>9 - Sem Ocorrência de Transporte</para> 
        /// </summary> 
        public string TipoTransporte { get; set; }

        /// <summary>
        /// VL_FRT - Valor do frete indicado no documento fiscal
        /// </summary>
        public decimal ValorFrete { get; set; }

        /// <summary>
        /// VL_SEG - Valor do seguro indicado no documento fiscal
        /// </summary>
        public decimal ValorSeguro { get; set; }

        /// <summary>
        /// VL_OUT_DA - Valor de outras despesas acessórias
        /// </summary>
        public decimal ValorDespesas { get; set; }

        /// <summary>
        /// VL_BC_ICMS - Valor da base de cálculo do ICMS
        /// </summary>
        public decimal ICMS_BC { get; set; }

        /// <summary>
        /// VL_ICMS - Valor do ICMS
        /// </summary>
        public decimal ICMS_Valor { get; set; }

        /// <summary>
        /// VL_BC_ICMS_ST - Valor da base de cálculo do ICMS substituição tributária
        /// </summary>
        public decimal ICMS_ST_BC_Valor { get; set; }

        /// <summary>
        /// VL_ICMS_ST - Valor do ICMS retido por substituição tributária
        /// </summary>
        public decimal ICMS_ST_Retido_Valor { get; set; }

        /// <summary>
        /// VL_IPI - Valor total do IPI
        /// </summary>
        public decimal IPI_Valor { get; set; }

        /// <summary>
        /// VL_PIS - Valor total do PIS
        /// </summary>
        public decimal PIS_Valor { get; set; }

        /// <summary>
        /// VL_PIS_ST - Valor total do PIS retido por substituição tributária
        /// </summary>
        public decimal PIS_ST_Valor { get; set; }

        /// <summary>
        /// VL_COFINS - Valor total da COFINS
        /// </summary>
        public decimal COFINS_Valor { get; set; }

        /// <summary>
        /// VL_COFINS_ST - Valor total da COFINS retido por substituição tributária
        /// </summary>
        public decimal COFINS_ST_Valor { get; set; }

        public TransporteVM Transporte { get; set; }

        public List<NotaFiscalProdutoVM> Produtos { get; set; }
    }

    public class TransporteVM : EfdNotificavelVM
    {
        public TransporteVM()
        {}

        public TransporteVM(
            ParticipanteVM? transportador, string? modeloDocumento, string? situacao, int? serie,
            int? numero, string? chave, string? dataEmissao, string? dataPrestacao, decimal? valorTotal,
            string? iCMS_ST, decimal? iCMS_BC, decimal? iCMS_Aliquota, decimal? iCMS_Valor, string? cFOP, string? codigoContaContabil, string? pIS_CST, decimal? pIS_BC,
            decimal? pIS_Aliquota, decimal? pIS_Valor, string? cOFINS_CST, decimal? cOFINS_BC,
            decimal? cOFINS_Aliquota, decimal? cOFINS_Valor
        )
        {
            Transportador = transportador;
            ModeloDocumento = modeloDocumento;
            Situacao = situacao;
            Serie = serie;
            Numero = numero;
            Chave = chave;
            DataEmissao = dataEmissao;
            DataPrestacao = dataPrestacao;
            ValorTotal = valorTotal;
            ICMS_ST = iCMS_ST;
            ICMS_BC = iCMS_BC;
            ICMS_Aliquota = iCMS_Aliquota;
            ICMS_Valor = iCMS_Valor;
            CFOP = cFOP;
            CodigoContaContabil = codigoContaContabil;
            PIS_CST = pIS_CST;
            PIS_BC = pIS_BC;
            PIS_Aliquota = pIS_Aliquota;
            PIS_Valor = pIS_Valor;
            COFINS_CST = cOFINS_CST;
            COFINS_BC = cOFINS_BC;
            COFINS_Aliquota = cOFINS_Aliquota;
            COFINS_Valor = cOFINS_Valor;

            //Adiciona o transportador da CT-e na lista de itens validáveis
            if (transportador != null)
            {
                AddNotifications(transportador);
            }

            ExecutaValidacoes();
        }

        private void ExecutaValidacoes()
        {
            //if (string.IsNullOrEmpty(Codigo) || Codigo.Length > 10)
            //{
            //    AddNotification("NaturezaOperacao.Codigo ('" + Codigo + "')", EfdResources.NotaFiscalNaturezaCodigoNaoInformado);
            //}

            //if (string.IsNullOrEmpty(Descricao))
            //{
            //    AddNotification("NaturezaOperacao.Descricao ('" + Descricao + "')", EfdResources.NotaFiscalNaturezaDescricaoNaoInformada);
            //}
        }

        /// <summary>
        /// COD_PART - Código do participante
        /// </summary>
        public ParticipanteVM? Transportador { get; set; }

        /// <summary> 
        /// COD_MOD - Código do modelo do documento fiscal
        /// 
        /// <para>07 - Nota Fiscal de Serviço de Transporte</para> 
        /// <para>08 - Conhecimento de Transporte Rodoviário de Cargas</para> 
        /// <para>8B - Conhecimento de Transporte de Cargas Avulso</para> 
        /// <para>09 - Conhecimento de Transporte Aquaviário de Cargas</para> 
        /// <para>11 - Conhecimento de Transporte Ferroviário de Cargas</para> 
        /// <para>17 - Despacho de Transporte</para> 
        /// <para>24 - Autorização de Carregamento e Transporte</para> 
        /// <para>26 - Conhecimento de Transporte Multimodal de Cargas</para> 
        /// <para>27 - Nota Fiscal de Transporte Ferroviário de Cargas</para> 
        /// <para>57 - Conhecimento de Transporte Eletrônico – CT-e</para> 
        /// <para>67 - Conhecimento de Transporte Eletrônico para Outros Serviços - CT-e OS</para> 
        /// </summary> 
        public string? ModeloDocumento { get; set; }

        /// <summary>
        /// COD_SIT - Código da situação do documento fiscal, conforme a Tabela 4.1.2
        /// </summary>
        public string? Situacao { get; set; }

        /// <summary>
        /// SER - Série do documento fiscal
        /// </summary>
        public int? Serie { get; set; }

        /// <summary>
        /// NUM_DOC - Número do documento fiscal
        /// </summary>
        public int? Numero { get; set; }

        /// <summary>
        /// CHV_CTE - Chave do Conhecimento de Transporte Eletrônico
        /// </summary>
        public string? Chave { get; set; }

        /// <summary>
        /// DT_DOC - Data da emissão do documento fiscal
        /// </summary>
        public string? DataEmissao { get; set; }

        /// <summary>
        /// DT_A_P - Data da aquisição ou da prestação do serviço - Formato: AAAA-MM-DD
        /// </summary>
        public string? DataPrestacao { get; set; }

        /// <summary>
        /// VL_DOC - Valor total do documento fiscal
        /// </summary>
        public decimal? ValorTotal { get; set; }

        /// <summary>
        /// CST_ICMS - Código da Situação Tributária da CT-e, conforme a Tabela indicada no item 4.3.1
        /// </summary>
        public string? ICMS_ST { get; set; }

        /// <summary>
        /// VL_BC_ICMS - Valor da base de cálculo do ICMS
        /// </summary>
        public decimal? ICMS_BC { get; set; }

        /// <summary>
        /// ALIQ_ICMS - Alíquota do ICMS
        /// </summary>
        public decimal? ICMS_Aliquota { get; set; }

        /// <summary>
        /// VL_ICMS - Valor do ICMS
        /// </summary>
        public decimal? ICMS_Valor { get; set; }

        /// <summary>
        /// Código Fiscal de Operação e Prestação, conforme a tabela indicada no item 4.2.2
        /// </summary>
        public string? CFOP { get; set; }

        /// <summary>
        /// COD_CTA - Código da conta analítica contábil debitada/creditada
        /// </summary>
        public string? CodigoContaContabil { get; set; }

        /// <summary> 
        /// CST_PIS - Código da Situação Tributária referente ao PIS
        /// <para></para>
        /// 
        /// Valores possíveis:
        /// <para></para>
        /// 
        /// <para> 01 - Operação Tributável com Alíquota Básica</para> 
        /// <para> 02 - Operação Tributável com Alíquota Diferenciada</para> 
        /// <para> 03 - Operação Tributável com Alíquota por Unidade de Medida de Produto</para> 
        /// <para> 04 - Operação Tributável Monofásica - Revenda a Alíquota Zero</para> 
        /// <para> 05 - Operação Tributável por Substituição Tributária</para> 
        /// <para> 06 - Operação Tributável a Alíquota Zero</para> 
        /// <para> 07 - Operação Isenta da Contribuição</para> 
        /// <para> 08 - Operação sem Incidência da Contribuição</para> 
        /// <para> 09 - Operação com Suspensão da Contribuição</para> 
        /// <para> 49 - Outras Operações de Saída</para> 
        /// <para> 50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para> 51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno</para> 
        /// <para> 52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para> 53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para> 54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para> 60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para> 61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno</para> 
        /// <para> 62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para> 63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para> 64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para> 67 - Crédito Presumido - Outras Operações</para> 
        /// <para> 70 - Operação de Aquisição sem Direito a Crédito</para> 
        /// <para> 71 - Operação de Aquisição com Isenção</para> 
        /// <para> 72 - Operação de Aquisição com Suspensão</para> 
        /// <para> 73 - Operação de Aquisição a Alíquota Zero</para> 
        /// <para> 74 - Operação de Aquisição sem Incidência da Contribuição</para> 
        /// <para> 75 - Operação de Aquisição por Substituição Tributária</para> 
        /// <para> 98 - Outras Operações de Entrada</para> 
        /// <para> 99 - Outras Operações</para> 
        /// </summary> 
        public string? PIS_CST { get; set; }

        /// <summary>
        /// VL_BC_PIS - Valor da base de cálculo do PIS
        /// </summary>
        public decimal? PIS_BC { get; set; }

        /// <summary>
        /// ALIQ_PIS - Alíquota do PIS (em percentual)
        /// </summary>
        public decimal? PIS_Aliquota { get; set; }

        /// <summary>
        /// VL_PIS - Valor do PIS
        /// </summary>
        public decimal? PIS_Valor { get; set; }

        /// <summary> 
        /// CST_COFINS - Código da Situação Tributária referente ao COFINS
        /// <para></para>
        /// 
        /// Valores possíveis:
        /// <para></para>
        /// 
        /// <para> 01 - Operação Tributável com Alíquota Básica</para> 
        /// <para> 02 - Operação Tributável com Alíquota Diferenciada</para> 
        /// <para> 03 - Operação Tributável com Alíquota por Unidade de Medida de Produto</para> 
        /// <para> 04 - Operação Tributável Monofásica - Revenda a Alíquota Zero</para> 
        /// <para> 05 - Operação Tributável por Substituição Tributária</para> 
        /// <para> 06 - Operação Tributável a Alíquota Zero</para> 
        /// <para> 07 - Operação Isenta da Contribuição</para> 
        /// <para> 08 - Operação sem Incidência da Contribuição</para> 
        /// <para> 09 - Operação com Suspensão da Contribuição</para> 
        /// <para> 49 - Outras Operações de Saída</para> 
        /// <para> 50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para> 51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno</para> 
        /// <para> 52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para> 53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para> 54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para> 60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para> 61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno</para> 
        /// <para> 62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para> 63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para> 64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para> 67 - Crédito Presumido - Outras Operações</para> 
        /// <para> 70 - Operação de Aquisição sem Direito a Crédito</para> 
        /// <para> 71 - Operação de Aquisição com Isenção</para> 
        /// <para> 72 - Operação de Aquisição com Suspensão</para> 
        /// <para> 73 - Operação de Aquisição a Alíquota Zero</para> 
        /// <para> 74 - Operação de Aquisição sem Incidência da Contribuição</para> 
        /// <para> 75 - Operação de Aquisição por Substituição Tributária</para> 
        /// <para> 98 - Outras Operações de Entrada</para> 
        /// <para> 99 - Outras Operações</para> 
        /// </summary> 
        public string? COFINS_CST { get; set; }

        /// <summary>
        /// VL_BC_COFINS - Valor da base de cálculo da COFINS
        /// </summary>
        public decimal? COFINS_BC { get; set; }

        /// <summary>
        /// ALIQ_COFINS - Alíquota do COFINS (em percentual)
        /// </summary>
        public decimal? COFINS_Aliquota { get; set; }

        /// <summary>
        /// VL_COFINS - Valor da COFINS
        /// </summary>
        public decimal? COFINS_Valor { get; set; }

        public ContaContabilVM? ContaContabil { get; set; }
    }

    public class ContaContabilVM : EfdNotificavelVM
    {
        public ContaContabilVM()
        { }

        public ContaContabilVM(
            string codigo, string dataInclusao, string tipo, int nivel,
            string nomeContaAnalitica, string codigoContaReceitaFederal
        )
        {
            Codigo = codigo;
            DataInclusao = dataInclusao;
            Tipo = tipo;
            Nivel = nivel;
            NomeContaAnalitica = nomeContaAnalitica;
            CodigoContaReceitaFederal = codigoContaReceitaFederal;
        }

        /// <summary>
        /// COD_CTA - Código da conta analítica/grupo de contas
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// DT_ALT - Data da inclusão/alteração - Formato: AAAA-MM-DD
        /// </summary>
        public string DataInclusao { get; set; }

        /// <summary> 
        /// IND_CTA - Indicador do tipo de conta
        /// 
        /// <para>S - Sintética (grupo de contas)</para> 
        /// <para>A - Analítica (conta).</para> 
        /// </summary> 
        public string Tipo { get; set; }

        /// <summary>
        /// NÍVEL - Nível da conta analítica/grupo de contas
        /// </summary>
        public int Nivel { get; set; }

        /// <summary>
        /// NOME_CTA - Nome da conta analítica/grupo de contas
        /// </summary>
        public string NomeContaAnalitica { get; set; }

        /// <summary>
        /// COD_CTA_REF - Código da conta correlacionada no Plano de Contas Referenciado, publicado pela RFB.
        /// </summary>
        public string CodigoContaReceitaFederal { get; set; }
    }

    public class ParticipanteVM : EfdNotificavelVM
    {
        public ParticipanteVM()
        { }

        public ParticipanteVM(string codigo, string nome, string cod_Pais, string cNPJ, string cPF,
            string iE, string sUFRAMA, string enderecoUFSigla, string enderecoUFCodigo, string enderecoCidadeCodigo, string enderecoLogradouro, string enderecoNumero,
            string enderecoComplemento, string enderecoBairro)
        {
            Codigo = codigo;
            Nome = nome;
            Cod_Pais = cod_Pais;
            CNPJ = cNPJ;
            CPF = cPF;
            IE = iE;
            SUFRAMA = sUFRAMA;
            EnderecoUFSigla = enderecoUFSigla;
            EnderecoUFCodigo = enderecoUFCodigo;
            EnderecoCidadeCodigo = enderecoCidadeCodigo;
            EnderecoLogradouro = enderecoLogradouro;
            EnderecoNumero = enderecoNumero;
            EnderecoComplemento = enderecoComplemento;
            EnderecoBairro = enderecoBairro;

            ExecutaValidacoes();
        }

        private void ExecutaValidacoes()
        {
            if (string.IsNullOrEmpty(Codigo))
            {
                AddNotification("Participante.Codigo ('" + Codigo + "')", EfdResources.NotaFiscalParticipanteCodigoNaoInformado);
            }

            if (string.IsNullOrEmpty(Nome))
            {
                AddNotification("Participante.Nome ('" + Nome + "')", EfdResources.NotaFiscalParticipanteNomeNaoInformado);
            }

            if (string.IsNullOrEmpty(Cod_Pais))
            {
                AddNotification("Participante.Cod_Pais ('" + Cod_Pais + "')", EfdResources.NotaFiscalParticipanteCodigoPaisNaoInformado);
            }
            ValidaCPF_CNPJ();

            if (!StringServices.ValorContidoNaLista(EnderecoUFSigla, UF_Sigla))
            {
                AddNotification("Participante.EnderecoUFSigla ('" + EnderecoUFSigla + "')", EfdResources.NotaFiscalParticipanteSiglaUFInvalida + string.Join(", ", UF_Sigla));
            }

            if (!StringServices.ValorContidoNaLista(EnderecoUFCodigo, UF_Codigo))
            {
                AddNotification("Participante.EnderecoUFCodigo ('" + EnderecoUFCodigo + "')", EfdResources.NotaFiscalParticipanteCodigoUFInvalido + string.Join(", ", UF_Codigo));
            }

            if (string.IsNullOrEmpty(EnderecoCidadeCodigo))
            {
                AddNotification("Participante.EnderecoCidadeCodigo ('" + EnderecoCidadeCodigo + "')", EfdResources.NotaFiscalParticipanteEnderecoCidadeCodigoNaoInformado);
            }

            if (string.IsNullOrEmpty(EnderecoLogradouro))
            {
                AddNotification("Participante.EnderecoLogradouro ('" + EnderecoLogradouro + "')", EfdResources.NotaFiscalParticipanteEnderecoLogradouroNaoInformado);
            }

            if (string.IsNullOrEmpty(EnderecoBairro))
            {
                AddNotification("Participante.EnderecoBairro ('" + EnderecoBairro + "')", EfdResources.NotaFiscalParticipanteEnderecoBairroNaoInformado);
            }

        }

        private void ValidaCPF_CNPJ()
        {
            bool CPF_CNPJ_Valido = false;

            if (!string.IsNullOrEmpty(CPF))
            {
                if (new EfdVoCPF(CPF).Valid)
                {
                    CPF_CNPJ_Valido = new EfdVoCPF(CPF).Valid;
                }
                else
                {
                    AddNotification("Participante.CPF ('" + CPF + "')", EfdResources.NotaFiscalParticipanteCPFInvalido);
                }
            }

            if (!string.IsNullOrEmpty(CNPJ))
            {
                if (new EfdVoCNPJ(CNPJ).Valid)
                {
                    CPF_CNPJ_Valido = new EfdVoCNPJ(CNPJ).Valid;
                }
                else
                {
                    AddNotification("Participante.CNPJ ('" + CNPJ + "')", EfdResources.NotaFiscalParticipanteCNPJInvalido);
                }
            }

            if (!CPF_CNPJ_Valido)
            {
                AddNotification("Participante.CPF_CNPJ", EfdResources.NotaFiscalParticipanteCPFCNPJNaoInformado);
            }
        }


        /// <summary> 
        /// COD_PART - Código de identificação do participante
        /// </summary> 
        public string Codigo { get; set; }

        /// <summary>
        /// Nome pessoal ou empresarial do participante
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Código do país do participante, conforme a tabela indicada no item 3.2.1
        /// </summary>
        public string Cod_Pais { get; set; }

        /// <summary>
        /// CNPJ do participante
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        /// CPF do participante
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Inscrição Estadual do participante
        /// </summary>
        public string IE { get; set; }

        /// <summary>
        /// Número de inscrição do participante na SUFRAMA
        /// </summary>
        public string SUFRAMA { get; set; }

        /// <summary>
        /// Sigla da UF do endereço
        /// </summary>
        public string EnderecoUFSigla { get; set; }

        /// <summary>
        /// Código IBGE do estado
        /// </summary>
        public string EnderecoUFCodigo { get; set; }

        /// <summary>
        /// Código do município, conforme a tabela IBGE
        /// </summary>
        public string EnderecoCidadeCodigo { get; set; }

        /// <summary>
        /// Logradouro e endereço do imóvel
        /// </summary>
        public string EnderecoLogradouro { get; set; }

        /// <summary>
        /// Número do imóvel
        /// </summary>
        public string EnderecoNumero { get; set; }

        /// <summary>
        /// Dados complementares do endereço
        /// </summary>
        public string EnderecoComplemento { get; set; }

        /// <summary>
        /// Bairro em que o imóvel está situado
        /// </summary>
        public string EnderecoBairro { get; set; }
    }

    public class NotaFiscalProdutoVM : EfdNotificavelVM
    {
        public NotaFiscalProdutoVM()
        { }

        public NotaFiscalProdutoVM(int numero, string codigo, string codigoBarras, string descricao, decimal quantidade,
            NotaFiscalProdutoUnidadeVM unidade, string tipo, string origem, string nCM, string cEST, decimal valorTotal,
            decimal desconto, int movimentado, string iCMS_CST, string cFOP, decimal valorFrete, decimal valorSeguro,
            decimal valorDespesas, decimal iCMS_BC, decimal iCMS_Aliquota, decimal iCMS_Valor, decimal iCMS_ST_BC,
            decimal iCMS_ST_Aliquota, decimal iCMS_ST_Valor, decimal iCMS_DIFAL_vBCUFDest, decimal iCMS_DIFAL_vBCFCPUFDest,
            decimal iCMS_DIFAL_pFCPUFDest, decimal iCMS_DIFAL_pICMSUFDest, decimal iCMS_DIFAL_pICMSInter,
            decimal iCMS_DIFAL_vFCPUFDest, decimal iCMS_DIFAL_vICMSUFDest, decimal iCMS_DIFAL_vICMSUFRemet, string iPI_Apuracao,
            string iPI_CST, string iPI_Enquadramento, decimal iPI_BC, decimal iPI_Aliquota, decimal iPI_Valor,
            string pIS_CST, decimal pIS_BC, decimal pIS_Aliquota, decimal pIS_BC_Quantidade, decimal pIS_Aliquota_Reais,
            decimal pIS_Valor, string cOFINS_CST, decimal cOFINS_BC, decimal cOFINS_Aliquota, decimal cOFINS_BC_Quantidade,
            decimal cOFINS_Aliquota_Reais, decimal cOFINS_Valor, ContaContabilVM? contaContabil, decimal valorAbatimento)
        {
            Numero = numero;
            Codigo = codigo;
            CodigoBarras = codigoBarras;
            Descricao = descricao;
            Quantidade = quantidade;
            Unidade = unidade;
            Tipo = tipo;
            Origem = origem;
            NCM = nCM;
            CEST = cEST;
            ValorTotal = valorTotal;
            Desconto = desconto;
            Movimentado = movimentado;
            ICMS_CST = iCMS_CST;
            CFOP = cFOP;
            ValorFrete = valorFrete;
            ValorSeguro = valorSeguro;
            ValorDespesas = valorDespesas;
            ICMS_BC = iCMS_BC;
            ICMS_Aliquota = iCMS_Aliquota;
            ICMS_Valor = iCMS_Valor;
            ICMS_ST_BC = iCMS_ST_BC;
            ICMS_ST_Aliquota = iCMS_ST_Aliquota;
            ICMS_ST_Valor = iCMS_ST_Valor;
            ICMS_DIFAL_vBCUFDest = iCMS_DIFAL_vBCUFDest;
            ICMS_DIFAL_vBCFCPUFDest = iCMS_DIFAL_vBCFCPUFDest;
            ICMS_DIFAL_pFCPUFDest = iCMS_DIFAL_pFCPUFDest;
            ICMS_DIFAL_pICMSUFDest = iCMS_DIFAL_pICMSUFDest;
            ICMS_DIFAL_pICMSInter = iCMS_DIFAL_pICMSInter;
            ICMS_DIFAL_vFCPUFDest = iCMS_DIFAL_vFCPUFDest;
            ICMS_DIFAL_vICMSUFDest = iCMS_DIFAL_vICMSUFDest;
            ICMS_DIFAL_vICMSUFRemet = iCMS_DIFAL_vICMSUFRemet;
            IPI_Apuracao = iPI_Apuracao;
            IPI_CST = iPI_CST;
            IPI_Enquadramento = iPI_Enquadramento;
            IPI_BC = iPI_BC;
            IPI_Aliquota = iPI_Aliquota;
            IPI_Valor = iPI_Valor;
            PIS_CST = pIS_CST;
            PIS_BC = pIS_BC;
            PIS_Aliquota = pIS_Aliquota;
            PIS_BC_Quantidade = pIS_BC_Quantidade;
            PIS_Aliquota_Reais = pIS_Aliquota_Reais;
            PIS_Valor = pIS_Valor;
            COFINS_CST = cOFINS_CST;
            COFINS_BC = cOFINS_BC;
            COFINS_Aliquota = cOFINS_Aliquota;
            COFINS_BC_Quantidade = cOFINS_BC_Quantidade;
            COFINS_Aliquota_Reais = cOFINS_Aliquota_Reais;
            COFINS_Valor = cOFINS_Valor;
            ContaContabil = contaContabil;
            ValorAbatimento = valorAbatimento;

            //Adiciona a unidade de medida do produto na lista de itens validáveis
            if (unidade != null)
            {
                AddNotifications(unidade);
            }

            ExecutaValidacoes();
        }

        private void ExecutaValidacoes()
        {
            if (Numero <= 0)
            {
                AddNotification("Produto[" + Numero + "].Numero ('" + Numero + "')", EfdResources.NotaFiscalProdutoNumeroInvalido);
            }

            if (string.IsNullOrEmpty(Codigo))
            {
                AddNotification("Produto[" + Numero + "].Codigo ('" + Codigo + "')", EfdResources.NotaFiscalProdutoCodigoNaoInformado);
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                AddNotification("Produto[" + Numero + "].Descricao ('" + Descricao + "')", EfdResources.NotaFiscalProdutoDescricaoNaoInformada);
            }

            if (Quantidade < 0)
            {
                AddNotification("Produto[" + Numero + "].Quantidade ('" + Quantidade + "')", EfdResources.NotaFiscalProdutoQuantidadeInvalida);
            }

            if (Unidade == null)
            {
                AddNotification("Produto[" + Numero + "].Unidade ('" + Unidade + "')", EfdResources.NotaFiscalProdutoUnidadeNaoInformada);
            }

            if (!StringServices.ValorContidoNaLista(Tipo, TIPO_ITEM))
            {
                AddNotification("Produto[" + Numero + "].Tipo ('" + Tipo + "')", EfdResources.NotaFiscalProdutoTipoInvalido + string.Join(", ", TIPO_ITEM));
            }

            if (!StringServices.ValorContidoNaLista(Origem, ORIGEM_MERCADORIA))
            {
                AddNotification("Produto[" + Numero + "].Origem ('" + Origem + "')", EfdResources.NotaFiscalProdutoOrigemInvalida + string.Join(", ", ORIGEM_MERCADORIA));
            }

            if (string.IsNullOrEmpty(NCM) || NCM.Length != 8 || !NCM.IsNumeric())
            {
                AddNotification("Produto[" + Numero + "].NCM ('" + NCM + "')", EfdResources.NotaFiscalProdutoNCMNaoInformado);
            }

            if (!string.IsNullOrEmpty(CEST) & (CEST.Length != 7 || !CEST.IsNumeric()))
            {
                AddNotification("Produto[" + Numero + "].CEST ('" + CEST + "')", EfdResources.NotaFiscalProdutoCESTIncorreto);
            }

            if (!StringServices.ValorContidoNaLista(Movimentado, IND_MOV))
            {
                AddNotification("Produto[" + Numero + "].Movimentado ('" + Movimentado + "')", EfdResources.NotaFiscalProdutoMovimentadoInvalida + string.Join(", ", IND_MOV));
            }

            if (string.IsNullOrEmpty(CFOP) || CFOP.Length != 4 || !CFOP.IsNumeric())
            {
                AddNotification("Produto[" + Numero + "].CFOP ('" + CFOP + "')", EfdResources.NotaFiscalProdutoCFOPIncorreto);
            }

            if (!StringServices.ValorContidoNaLista(ICMS_CST, CST_ICMS.Concat(CSOSN).ToArray()))
            {
                AddNotification("Produto[" + Numero + "].ICMS_CST ('" + ICMS_CST + "')", EfdResources.NotaFiscalProdutoCST_CSOSN_ICMSInvalido + string.Join(", ", CST_ICMS.Concat(CSOSN).ToArray()));
            }

            if (!StringServices.ValorContidoNaLista(IPI_Apuracao, IND_APUR))
            {
                AddNotification("Produto[" + Numero + "].IPI_Apuracao ('" + IPI_Apuracao + "')", EfdResources.NotaFiscalProdutoCST_CSOSN_ICMSInvalido + string.Join(", ", IND_APUR));
            }

            if (!StringServices.ValorContidoNaLista(IPI_CST, CST_IPI))
            {
                AddNotification("Produto[" + Numero + "].IPI_CST ('" + IPI_CST + "')", EfdResources.NotaFiscalProdutoCST_IPIInvalido + string.Join(", ", CST_IPI));
            }

            if (!StringServices.ValorContidoNaLista(PIS_CST, CST_PIS))
            {
                AddNotification("Produto[" + Numero + "].PIS_CST ('" + PIS_CST + "')", EfdResources.NotaFiscalProdutoPISCSTIncorreto + string.Join(", ", CST_PIS));
            }

            if (!StringServices.ValorContidoNaLista(COFINS_CST, CST_COFINS))
            {
                AddNotification("Produto[" + Numero + "].COFINS_CST ('" + COFINS_CST + "')", EfdResources.NotaFiscalProdutoCOFINSCSTIncorreto + string.Join(", ", CST_COFINS));
            }

            if (COFINS_CST != PIS_CST)
            {
                AddNotification("Produto[" + Numero + "] | PIS_CST ('" + PIS_CST + "') | COFINS_CST ('" + COFINS_CST + "')", EfdResources.NotaFiscalProdutoDivergenciaCST_PIS_COFINS);
            }

        }

        /// <summary>
        /// NUM_ITEM - Número sequencial do item no documento fiscal
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// COD_ITEM - Código do item
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
        /// QTD - Quantidade do item comercializada
        /// </summary>
        public decimal Quantidade { get; set; }

        /// <summary>
        /// UNID - Unidade do item (Campo 02 do registro 0190)
        /// </summary>
        public NotaFiscalProdutoUnidadeVM Unidade { get; set; }

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
        public string CEST { get; set; }

        /// <summary>
        /// VL_ITEM - Valor total do item (mercadorias ou serviços)
        /// </summary>
        public decimal ValorTotal { get; set; }

        /// <summary>
        /// VL_DESC - Valor do desconto comercial
        /// </summary>
        public decimal Desconto { get; set; }

        /// <summary> 
        /// IND_MOV - Movimentação física do ITEM/PRODUTO
        /// 
        /// <para>0 - Sim</para> 
        /// <para>1 - Não</para> 
        /// </summary> 
        public int Movimentado { get; set; }

        /// <summary>
        /// CFOP - Código Fiscal de Operação e Prestação
        /// </summary>
        public string CFOP { get; set; }

        /// <summary>
        /// VL_FRT - Valor do frete do item, indicado no documento fiscal
        /// </summary>
        public decimal ValorFrete { get; set; }

        /// <summary>
        /// VL_SEG - Valor do seguro do item, indicado no documento fiscal
        /// </summary>
        public decimal ValorSeguro { get; set; }

        /// <summary>
        /// VL_OUT_DA - Valor de outras despesas acessórias do item
        /// </summary>
        public decimal ValorDespesas { get; set; }

        /// <summary> 
        /// CST_ICMS - Código da Situação Tributária referente ao ICMS (CST sem a origem ou CSOSN)
        /// <para></para>
        /// 
        /// Valores possíveis:
        /// <para></para>
        /// 
        /// CST - Código da Situação Tributária
        /// <para></para>
        /// 
        /// <para>00 - Tributada integralmente</para> 
        /// <para>10 - Tributada e com cobrança do ICMS por substituição tributária</para> 
        /// <para>20 - Com redução da BC</para> 
        /// <para>30 - Isenta / não tributada e com cobrança do ICMS por substituição tributária</para> 
        /// <para>40 - Isenta</para> 
        /// <para>41 - Não tributada</para> 
        /// <para>50 - Com suspensão</para> 
        /// <para>51 - Com diferimento</para> 
        /// <para>60 - ICMS cobrado anteriormente por substituição tributária</para> 
        /// <para>70 - Com redução da BC e cobrança do ICMS por substituição tributária</para> 
        /// <para>90 - Outras</para> 
        /// 
        /// <para></para>
        /// 
        /// CSOSN - Código de Situação da Operação no Simples Nacional
        /// <para></para>
        /// 
        /// <para>101 - Tributada pelo Simples Nacional com permissão de crédito</para> 
        /// <para>102 - Tributada pelo Simples Nacional sem permissão de crédito</para> 
        /// <para>103 - Isenção do ICMS no Simples Nacional para faixa de receita bruta</para> 
        /// <para>201 - Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por substituição tributária</para> 
        /// <para>202 - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por substituição tributária</para> 
        /// <para>203 - Isenção do ICMS no Simples Nacional para faixa de receita bruta e com cobrança do ICMS por substituição tributária</para> 
        /// <para>300 - Imune</para> 
        /// <para>400 - Não tributada pelo Simples Nacional</para> 
        /// <para>500 - ICMS cobrado anteriormente por substituição tributária (substituído) ou por antecipação</para> 
        /// <para>900 - Outros</para> 
        /// </summary> 
        public string ICMS_CST { get; set; }

        /// <summary>
        /// VL_BC_ICMS - Valor da base de cálculo do ICMS
        /// </summary>
        public decimal ICMS_BC { get; set; }

        /// <summary>
        /// ALIQ_ICMS - Alíquota do ICMS
        /// </summary>
        public decimal ICMS_Aliquota { get; set; }

        /// <summary>
        /// VL_ICMS - Valor do ICMS creditado/debitado
        /// </summary>
        public decimal ICMS_Valor { get; set; }

        /// <summary>
        /// VL_BC_ICMS_ST - Valor da base de cálculo referente à substituição tributária
        /// </summary>
        public decimal ICMS_ST_BC { get; set; }

        /// <summary>
        /// ALIQ_ST - Alíquota do ICMS da substituição tributária na unidade da federação de destino
        /// </summary>
        public decimal ICMS_ST_Aliquota { get; set; }

        /// <summary>
        /// VL_ICMS_ST - Valor do ICMS referente à substituição tributária
        /// </summary>
        public decimal ICMS_ST_Valor { get; set; }

        #region DIFAL
        /// <summary>
        /// vBCUFDest - Valor da Base de Cálculo do ICMS na UF do destinatário
        /// 
        /// `Obs.: Informado nas vendas interestaduais para consumidor final, não contribuinte de ICMS`
        /// </summary>
        public decimal ICMS_DIFAL_vBCUFDest { get; set; }

        /// <summary>
        /// vBCFCPUFDest - Valor da Base de Cálculo do FCP na UF do destinatário
        /// 
        /// `Obs.: Informado nas vendas interestaduais para consumidor final, não contribuinte de ICMS`
        /// </summary>
        public decimal ICMS_DIFAL_vBCFCPUFDest { get; set; }

        /// <summary>
        /// pFCPUFDest - Percentual adicional inserido na alíquota interna da UF de destino, relativo ao Fundo de Combate à Pobreza (FCP) naquela UF
        /// 
        /// `Obs.: Informado nas vendas interestaduais para consumidor final, não contribuinte de ICMS`
        /// </summary>
        public decimal ICMS_DIFAL_pFCPUFDest { get; set; }

        /// <summary>
        /// pICMSUFDest - Alíquota adotada nas operações internas na UF do destinatário para o produto / mercadoria
        /// 
        /// `Obs.: Informado nas vendas interestaduais para consumidor final, não contribuinte de ICMS`
        /// </summary>
        public decimal ICMS_DIFAL_pICMSUFDest { get; set; }

        /// <summary> 
        /// pICMSInter - Alíquota interestadual das UF envolvidas: 
        /// <para></para> 
        /// 
        /// <para>4% alíquota interestadual para produtos importados</para> 
        /// <para>7% para os Estados de origem do Sul e Sudeste (exceto ES), destinado para os Estados do Norte e Nordeste ou ES</para> 
        /// <para>12% para os demais casos</para> 
        /// 
        /// `Obs.: Informado nas vendas interestaduais para consumidor final, não contribuinte de ICMS`
        /// </summary> 
        public decimal ICMS_DIFAL_pICMSInter { get; set; }

        /// <summary>
        /// vFCPUFDest - Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP) da UF de destino
        /// 
        /// `Obs.: Informado nas vendas interestaduais para consumidor final, não contribuinte de ICMS`
        /// </summary>
        public decimal ICMS_DIFAL_vFCPUFDest { get; set; }

        /// <summary>
        /// vICMSUFDest - Valor do ICMS de partilha para a UF do destinatário
        /// 
        /// `Obs.: Informado nas vendas interestaduais para consumidor final, não contribuinte de ICMS`
        /// </summary>
        public decimal ICMS_DIFAL_vICMSUFDest { get; set; }

        /// <summary>
        /// vICMSUFRemet - Valor do ICMS de partilha para a UF do remetente. Nota: A partir de 2019, este valor será zero
        /// 
        /// `Obs.: Informado nas vendas interestaduais para consumidor final, não contribuinte de ICMS`
        /// </summary>
        public decimal ICMS_DIFAL_vICMSUFRemet { get; set; }
        #endregion

        /// <summary> 
        /// IND_APUR Indicador de período de apuração do IPI
        /// 
        /// <para>0 - Mensal</para> 
        /// <para>1 - Decendial</para> 
        /// </summary> 
        public string IPI_Apuracao { get; set; }

        /// <summary> 
        /// CST_IPI - Código da Situação Tributária referente ao IPI
        /// <para></para>
        /// 
        /// Valores possíveis:
        /// <para></para>
        /// 
        /// <para>00 - Entrada com recuperação de crédito</para> 
        /// <para>01 - Entrada tributada com alíquota zero</para> 
        /// <para>02 - Entrada isenta</para> 
        /// <para>03 - Entrada não-tributada</para> 
        /// <para>04 - Entrada imune</para> 
        /// <para>05 - Entrada com suspensão</para> 
        /// <para>49 - Outras entradas</para> 
        /// <para>50 - Saída tributada</para> 
        /// <para>51 - Saída tributada com alíquota zero</para>         
        /// <para>52 - Saída isenta</para>         
        /// <para>53 - Saída não-tributada</para>         
        /// <para>54 - Saída imune</para>         
        /// <para>55 - Saída com suspensão</para>         
        /// <para>99 - Outras saídas</para>         
        /// </summary> 
        public string IPI_CST { get; set; }

        /// <summary>
        /// COD_ENQ - Código de enquadramento legal do IPI
        /// </summary>
        public string IPI_Enquadramento { get; set; }

        /// <summary>
        /// VL_BC_IPI - Valor da base de cálculo do IPI
        /// </summary>
        public decimal IPI_BC { get; set; }

        /// <summary>
        /// ALIQ_IPI - Alíquota do IPI
        /// </summary>
        public decimal IPI_Aliquota { get; set; }

        /// <summary>
        /// VL_IPI - Valor do IPI creditado/debitado
        /// </summary>
        public decimal IPI_Valor { get; set; }

        /// <summary> 
        /// CST_PIS - Código da Situação Tributária referente ao PIS
        /// <para></para>
        /// 
        /// Valores possíveis:
        /// <para></para>
        /// 
        /// <para> 01 - Operação Tributável com Alíquota Básica</para> 
        /// <para> 02 - Operação Tributável com Alíquota Diferenciada</para> 
        /// <para> 03 - Operação Tributável com Alíquota por Unidade de Medida de Produto</para> 
        /// <para> 04 - Operação Tributável Monofásica - Revenda a Alíquota Zero</para> 
        /// <para> 05 - Operação Tributável por Substituição Tributária</para> 
        /// <para> 06 - Operação Tributável a Alíquota Zero</para> 
        /// <para> 07 - Operação Isenta da Contribuição</para> 
        /// <para> 08 - Operação sem Incidência da Contribuição</para> 
        /// <para> 09 - Operação com Suspensão da Contribuição</para> 
        /// <para> 49 - Outras Operações de Saída</para> 
        /// <para> 50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para> 51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno</para> 
        /// <para> 52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para> 53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para> 54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para> 60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para> 61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno</para> 
        /// <para> 62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para> 63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para> 64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para> 67 - Crédito Presumido - Outras Operações</para> 
        /// <para> 70 - Operação de Aquisição sem Direito a Crédito</para> 
        /// <para> 71 - Operação de Aquisição com Isenção</para> 
        /// <para> 72 - Operação de Aquisição com Suspensão</para> 
        /// <para> 73 - Operação de Aquisição a Alíquota Zero</para> 
        /// <para> 74 - Operação de Aquisição sem Incidência da Contribuição</para> 
        /// <para> 75 - Operação de Aquisição por Substituição Tributária</para> 
        /// <para> 98 - Outras Operações de Entrada</para> 
        /// <para> 99 - Outras Operações</para> 
        /// </summary> 
        public string PIS_CST { get; set; }

        /// <summary>
        /// VL_BC_PIS - Valor da base de cálculo do PIS
        /// </summary>
        public decimal PIS_BC { get; set; }

        /// <summary>
        /// ALIQ_PIS - Alíquota do PIS (em percentual)
        /// </summary>
        public decimal PIS_Aliquota { get; set; }

        /// <summary>
        /// QUANT_BC_PIS - Quantidade – Base de cálculo PIS
        /// </summary>
        public decimal PIS_BC_Quantidade { get; set; }

        /// <summary>
        /// ALIQ_PIS_Reais - Alíquota do PIS (em reais)
        /// </summary>
        public decimal PIS_Aliquota_Reais { get; set; }

        /// <summary>
        /// VL_PIS - Valor do PIS
        /// </summary>
        public decimal PIS_Valor { get; set; }

        /// <summary> 
        /// CST_COFINS - Código da Situação Tributária referente ao COFINS
        /// <para></para>
        /// 
        /// Valores possíveis:
        /// <para></para>
        /// 
        /// <para> 01 - Operação Tributável com Alíquota Básica</para> 
        /// <para> 02 - Operação Tributável com Alíquota Diferenciada</para> 
        /// <para> 03 - Operação Tributável com Alíquota por Unidade de Medida de Produto</para> 
        /// <para> 04 - Operação Tributável Monofásica - Revenda a Alíquota Zero</para> 
        /// <para> 05 - Operação Tributável por Substituição Tributária</para> 
        /// <para> 06 - Operação Tributável a Alíquota Zero</para> 
        /// <para> 07 - Operação Isenta da Contribuição</para> 
        /// <para> 08 - Operação sem Incidência da Contribuição</para> 
        /// <para> 09 - Operação com Suspensão da Contribuição</para> 
        /// <para> 49 - Outras Operações de Saída</para> 
        /// <para> 50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para> 51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno</para> 
        /// <para> 52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para> 53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para> 54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para> 60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para> 61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno</para> 
        /// <para> 62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para> 63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para> 64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para> 66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para> 67 - Crédito Presumido - Outras Operações</para> 
        /// <para> 70 - Operação de Aquisição sem Direito a Crédito</para> 
        /// <para> 71 - Operação de Aquisição com Isenção</para> 
        /// <para> 72 - Operação de Aquisição com Suspensão</para> 
        /// <para> 73 - Operação de Aquisição a Alíquota Zero</para> 
        /// <para> 74 - Operação de Aquisição sem Incidência da Contribuição</para> 
        /// <para> 75 - Operação de Aquisição por Substituição Tributária</para> 
        /// <para> 98 - Outras Operações de Entrada</para> 
        /// <para> 99 - Outras Operações</para> 
        /// </summary> 
        public string COFINS_CST { get; set; }

        /// <summary>
        /// VL_BC_COFINS - Valor da base de cálculo da COFINS
        /// </summary>
        public decimal COFINS_BC { get; set; }

        /// <summary>
        /// ALIQ_COFINS - Alíquota do COFINS (em percentual)
        /// </summary>
        public decimal COFINS_Aliquota { get; set; }

        /// <summary>
        /// QUANT_BC_COFINS - Quantidade – Base de cálculo COFINS
        /// </summary>
        public decimal COFINS_BC_Quantidade { get; set; }

        /// <summary>
        /// DT_DOC - Alíquota da COFINS (em reais)
        /// </summary>
        public decimal COFINS_Aliquota_Reais { get; set; }

        /// <summary>
        /// VL_COFINS - Valor da COFINS
        /// </summary>
        public decimal COFINS_Valor { get; set; }

        /// <summary>
        /// COD_CTA - Código da conta analítica contábil debitada/creditada
        /// </summary>
        public ContaContabilVM? ContaContabil { get; set; }

        /// <summary>
        /// DT_DOC - Valor do abatimento não tributado e não comercial
        /// </summary>
        public decimal ValorAbatimento { get; set; }
    }

    public class NotaFiscalProdutoUnidadeVM : EfdNotificavelVM
    {
        public NotaFiscalProdutoUnidadeVM()
        { }

        public NotaFiscalProdutoUnidadeVM(string codigo, string simbolo)
        {
            Codigo = codigo;
            Simbolo = simbolo;

            ExecutaValidacoes();
        }

        private void ExecutaValidacoes()
        {
            if (string.IsNullOrEmpty(Codigo) || Codigo.Length > 6)
            {
                AddNotification("Produto.Unidade.Codigo ('" + Codigo + "')", EfdResources.NotaFiscalUnidadeCodigoNaoInformado);
            }

            if (string.IsNullOrEmpty(Simbolo))
            {
                AddNotification("Produto.Unidade.Simbolo ('" + Simbolo + "')", EfdResources.NotaFiscalUnidadeDescricaoNaoInformada);
            }
        }

        /// <summary>
        /// UNID - Código da unidade de medida
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// DESCR - Descrição da unidade de medida
        /// </summary>
        public string Simbolo { get; set; }
    }

    public class NotaFiscalProdutoNaturezaOperacaoVM : EfdNotificavelVM
    {
        public NotaFiscalProdutoNaturezaOperacaoVM()
        {}

        public NotaFiscalProdutoNaturezaOperacaoVM(string codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;

            ExecutaValidacoes();
        }

        private void ExecutaValidacoes()
        {
            if (string.IsNullOrEmpty(Codigo) || Codigo.Length > 10)
            {
                AddNotification("NaturezaOperacao.Codigo ('" + Codigo + "')", EfdResources.NotaFiscalNaturezaCodigoNaoInformado);
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                AddNotification("NaturezaOperacao.Descricao ('" + Descricao + "')", EfdResources.NotaFiscalNaturezaDescricaoNaoInformada);
            }
        }

        /// <summary>
        /// COD_NAT - Código da natureza da operação/prestação
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// DESCR_NAT - Descrição da natureza da operação/prestação
        /// </summary>
        public string Descricao { get; set; }
    }
}