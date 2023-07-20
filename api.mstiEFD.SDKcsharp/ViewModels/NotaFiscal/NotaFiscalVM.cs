using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels.Notifications;
using NJsonSchema.Annotations;

namespace api.mstiEFD.SDKcsharp.ViewModels.NotaFiscal
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
        { }

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
        }

        public void ExecutaValidacoes()
        {
            //Adiciona a natureza da nota fiscal na lista de itens validáveis
            if (NaturezaOperacao != null)
            {
                NaturezaOperacao.ExecutaValidacoes();
                AddNotifications(NaturezaOperacao);
            }

            //Adiciona o participante da nota fiscal na lista de itens validáveis
            if (Participante != null)
            {
                Participante.ExecutaValidacoes();
                AddNotifications(Participante);
            }

            //Adiciona o transporte da nota fiscal na lista de itens validáveis
            if (Transporte != null)
            {
                Transporte.ExecutaValidacoes();
                AddNotifications(Transporte);
            }

            //Adiciona os produtos na lista de itens validáveis
            if (Produtos != null && Produtos.Any())
            {
                foreach (var produto in Produtos)
                {
                    produto.ExecutaValidacoes();
                    AddNotifications(produto);
                }
            }

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
}