namespace api.mstiEFD.SDKcsharp.Resources
{
    public static class Constantes
    {
        public const string COD_SIT_DOCUMENTO_REGULAR = "00";
        public const string COD_SIT_ESCRITURACAO_EXTEMPORÂNEA_DE_DOCUMENTO_REGULAR = "01";
        public const string COD_SIT_DOCUMENTO_CANCELADO = "02";
        public const string COD_SIT_ESCRITURACAO_EXTEMPORÂNEA_DE_DOCUMENTO_CANCELADO = "03";
        public const string COD_SIT_NFE_NFCE_OU_CTE__DENEGADO = "04";
        public const string COD_SIT_NFE_NFCE_OU_CTE__NUMERACAO_INUTILIZADA = "05";
        public const string COD_SIT_DOCUMENTO_FISCAL_COMPLEMENTAR = "06";
        public const string COD_SIT_ESCRITURACAO_EXTEMPORÂNEA_DE_DOCUMENTO_COMPLEMENTAR = "07";
        public const string COD_SIT_DOCUMENTO_FISCAL_EMITIDO_COM_BASE_EM_REGIME_ESPECIAL_OU_NORMA_ESPECIFICA = "08";

        public const string NFE = "55";
        public const string NFCE = "65";
        public const string ENTRADA = "0";
        public const string SAIDA = "1";

        public const string IND_ATIV_INDUSTRIAL_OU_EQUIPARADO = "0";
        public const string IND_ATIV_OUTROS = "1";

        public const int COD_FIN_ARQUIVO_ORIGINAL = 0;
        public const int COD_FIN_ARQUIVO_SUBSTITUTO = 1;

        public const string FIN_NFE_NORMAL = "1";
        public const string FIN_NFE_COMPLEMENTAR = "2";
        public const string FIN_NFE_AJUSTE = "3";
        public const string FIN_NFE_DEVOLUCAO = "4";

        public const string CLAS_ESTAB_IND_INDUSTRIAL_TRANSFORMACAO = "00";
        public const string CLAS_ESTAB_IND_INDUSTRIAL_BENEFICIAMENTO = "01";
        public const string CLAS_ESTAB_IND_INDUSTRIAL_MONTAGEM = "02";
        public const string CLAS_ESTAB_IND_INDUSTRIAL_ACONDICIONAMENTO_REACONDICIONAMENTO = "03";
        public const string CLAS_ESTAB_IND_INDUSTRIAL_RENOVAÇÃO_RECONDICIONAMENTO = "04";
        public const string CLAS_ESTAB_IND_EQUIPARADO_INDUSTRIAL_POR_OPCAO = "05";
        public const string CLAS_ESTAB_IND_EQUIPARADO_INDUSTRIAL_IMPORTACAO_DIRETA = "06";
        public const string CLAS_ESTAB_IND_EQUIPARADO_INDUSTRIAL_POR_LEI_ESPECÍFICA = "07";
        public const string CLAS_ESTAB_IND_EQUIPARADO_INDUSTRIAL_NAO_ENQUADRADO_NOS_CODIGOS_05_06_07 = "08";
        public const string CLAS_ESTAB_IND_OUTROS = "09";

        public const string PERFIL_A = "A";
        public const string PERFIL_B = "B";
        public const string PERFIL_C = "C";

        public const string COD_MOD_TRANSPORTE_NOTA_FISCAL_DE_SERVIÇO_DE_TRANSPORTE = "07";
        public const string COD_MOD_TRANSPORTE_CONHECIMENTO_TRANSPORTE_RODOVIARIO_CARGAS = "08";
        public const string COD_MOD_TRANSPORTE_CONHECIMENTO_TRANSPORTE_CARGAS_AVULSO = "8B";
        public const string COD_MOD_TRANSPORTE_CONHECIMENTO_TRANSPORTE_AQUAVIARIO_CARGAS = "09";
        public const string COD_MOD_TRANSPORTE_CONHECIMENTO_TRANSPORTE_FERROVIARIO_CARGAS = "11";
        public const string COD_MOD_TRANSPORTE_DESPACHO_TRANSPORTE = "17";
        public const string COD_MOD_TRANSPORTE_AUTORIZACAO_CARREGAMENTO_E_TRANSPORTE = "24";
        public const string COD_MOD_TRANSPORTE_CONHECIMENTO_TRANSPORTE_MULTIMODAL_CARGAS = "26";
        public const string COD_MOD_TRANSPORTE_NOTA_FISCAL_TRANSPORTE_FERROVIARIO_CARGAS = "27";
        public const string COD_MOD_TRANSPORTE_CONHECIMENTO_TRANSPORTE_ELETRONICO_CTE = "57";
        public const string COD_MOD_TRANSPORTE_CONHECIMENTO_TRANSPORTE_ELETRONICO_PARA_OUTROS_SERVICOS_CTE_OS = "67";

        public const string IND_OPER_ENTRADA = "0";
        public const string IND_OPER_SAIDA = "1";

        /// <summary> 
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
        public static readonly string[] CSOSN =
        {
            "101", "102", "103", "201", "202", "203", "300", "400", "500", "900"
        };

        /// <summary>
        /// CST - Código da Situação Tributária do ICMS
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
        /// </summary>
        public static readonly string[] CST_ICMS =
        {
            "00", "10", "20", "30", "40", "41", "50", "51", "60", "70", "90"
        };

        /// <summary>
        /// IND_OPER - Indicador do tipo de operação
        /// <para></para>
        /// 
        /// <para>0 - Entrada</para> 
        /// <para>1 - Saída</para> 
        /// </summary>
        public static readonly string[] IND_OPER = { "0", "1" };

        /// <summary>
        /// IND_EMIT - Indicador do emitente do documento fiscal
        /// <para></para>
        /// 
        /// <para>0 - Emissão própria</para> 
        /// <para>1 - Terceiros</para> 
        /// </summary>
        public static readonly string[] IND_EMIT = { "0", "1" };

        /// <summary> 
        /// finNFe - Finalidade da emissão da NF-e:
        /// 
        /// <para>1 - Normal;</para> 
        /// <para>2 - Complementar;</para> 
        /// <para>3 - Ajuste;</para> 
        /// <para>4 - Devolução/Retorno</para> 
        /// </summary> 
        public static readonly string[] FIN_NFE = { "1", "2", "3", "4" };

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
        public static readonly string[] COD_MOD =
        {
            "01", "1B", "02", "2D", "2E", "04", "06", "07", "08", "8B", "09",
            "10", "11", "13", "14", "15", "17", "16", "18", "20", "21", "22",
            "23", "24", "25", "26", "27", "28", "29", "30", "55", "57", "59",
            "60", "65", "67", "63", "66"
        };

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
        public static readonly string[] COD_SIT =
        {
            "00", "01", "02", "03", "04", "05", "06", "07", "08"
        };

        /// <summary> 
        /// IND_PGTO - Indicador do tipo de pagamento
        /// 
        /// <para>0 - À vista</para> 
        /// <para>1 - A prazo</para> 
        /// <para>2 - Outros</para> 
        /// </summary> 
        public static readonly string[] IND_PGTO =
        {
            "0", "1", "2"
        };

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
        public static readonly string[] IND_FRT =
        {
            "0", "1", "2", "3", "4", "9"
        };

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
        public static readonly string[] TIPO_ITEM =
        {
            "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "99"
        };

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
        public static readonly string[] ORIGEM_MERCADORIA =
        {
            "0", "1", "2", "3", "4", "5", "6", "7", "8"
        };

        /// <summary> 
        /// IND_MOV - Movimentação física do ITEM/PRODUTO
        /// 
        /// <para>0 - Sim</para> 
        /// <para>1 - Não</para> 
        /// </summary> 
        public static readonly string[] IND_MOV =
        {
            "0", "1"
        };

        /// <summary> 
        /// IND_APUR Indicador de período de apuração do IPI
        /// 
        /// <para>0 - Mensal</para> 
        /// <para>1 - Decendial</para> 
        /// </summary> 
        public static readonly string[] IND_APUR =
        {
            "0", "1"
        };

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
        public static readonly string[] CST_IPI =
        {
            "00", "01", "02", "03", "04", "05", "49", "50", "51", "52", "53", "54", "55", "99"
        };

        /// <summary> 
        /// CST_PIS - Código da Situação Tributária referente ao PIS
        /// <para></para>
        /// 
        /// Valores possíveis:
        /// <para></para>
        /// 
        /// <para>01 - Operação Tributável com Alíquota Básica</para> 
        /// <para>02 - Operação Tributável com Alíquota Diferenciada</para> 
        /// <para>03 - Operação Tributável com Alíquota por Unidade de Medida de Produto</para> 
        /// <para>04 - Operação Tributável Monofásica - Revenda a Alíquota Zero</para> 
        /// <para>05 - Operação Tributável por Substituição Tributária</para> 
        /// <para>06 - Operação Tributável a Alíquota Zero</para> 
        /// <para>07 - Operação Isenta da Contribuição</para> 
        /// <para>08 - Operação sem Incidência da Contribuição</para> 
        /// <para>09 - Operação com Suspensão da Contribuição</para> 
        /// <para>49 - Outras Operações de Saída</para> 
        /// <para>50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para>51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno</para> 
        /// <para>52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para>53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para>54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para>55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para>56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para>60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para>61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno</para> 
        /// <para>62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para>63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para>64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para>65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para>66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para>67 - Crédito Presumido - Outras Operações</para> 
        /// <para>70 - Operação de Aquisição sem Direito a Crédito</para> 
        /// <para>71 - Operação de Aquisição com Isenção</para> 
        /// <para>72 - Operação de Aquisição com Suspensão</para> 
        /// <para>73 - Operação de Aquisição a Alíquota Zero</para> 
        /// <para>74 - Operação de Aquisição sem Incidência da Contribuição</para> 
        /// <para>75 - Operação de Aquisição por Substituição Tributária</para> 
        /// <para>98 - Outras Operações de Entrada</para> 
        /// <para>99 - Outras Operações</para> 
        /// </summary> 
        public static readonly string[] CST_PIS =
        {
            "01", "02", "03", "04", "05", "06", "07", "08", "09", "49", "50",
            "51", "52", "53", "54", "55", "56", "60", "61", "62", "63", "64",
            "65", "66", "67", "70", "71", "72", "73", "74", "75", "98", "99"
        };

        /// <summary> 
        /// CST_COFINS - Código da Situação Tributária referente ao COFINS
        /// <para></para>
        /// 
        /// Valores possíveis:
        /// <para></para>
        /// 
        /// <para>01 - Operação Tributável com Alíquota Básica</para> 
        /// <para>02 - Operação Tributável com Alíquota Diferenciada</para> 
        /// <para>03 - Operação Tributável com Alíquota por Unidade de Medida de Produto</para> 
        /// <para>04 - Operação Tributável Monofásica - Revenda a Alíquota Zero</para> 
        /// <para>05 - Operação Tributável por Substituição Tributária</para> 
        /// <para>06 - Operação Tributável a Alíquota Zero</para> 
        /// <para>07 - Operação Isenta da Contribuição</para> 
        /// <para>08 - Operação sem Incidência da Contribuição</para> 
        /// <para>09 - Operação com Suspensão da Contribuição</para> 
        /// <para>49 - Outras Operações de Saída</para> 
        /// <para>50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para>51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno</para> 
        /// <para>52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para>53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para>54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para>55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para>56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para>60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para> 
        /// <para>61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno</para> 
        /// <para>62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação</para> 
        /// <para>63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para> 
        /// <para>64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para> 
        /// <para>65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para> 
        /// <para>66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para> 
        /// <para>67 - Crédito Presumido - Outras Operações</para> 
        /// <para>70 - Operação de Aquisição sem Direito a Crédito</para> 
        /// <para>71 - Operação de Aquisição com Isenção</para> 
        /// <para>72 - Operação de Aquisição com Suspensão</para> 
        /// <para>73 - Operação de Aquisição a Alíquota Zero</para> 
        /// <para>74 - Operação de Aquisição sem Incidência da Contribuição</para> 
        /// <para>75 - Operação de Aquisição por Substituição Tributária</para> 
        /// <para>98 - Outras Operações de Entrada</para> 
        /// <para>99 - Outras Operações</para> 
        /// </summary> 
        public static readonly string[] CST_COFINS = CST_PIS;

        /// <summary> 
        /// Lista de siglas das UF
        /// 
        /// <para>11 - Rondônia - RO</para> 
        /// <para>12 - Acre - AC</para> 
        /// <para>13 - Amazonas - AM</para> 
        /// <para>14 - Roraima - RR</para> 
        /// <para>15 - Pará - PA</para> 
        /// <para>16 - Amapá - AP</para> 
        /// <para>17 - Tocantins - TO</para> 
        /// <para>21 - Maranhão - MA</para> 
        /// <para>22 - Piauí - PI</para> 
        /// <para>23 - Ceará - CE</para> 
        /// <para>24 - Rio Grande do Norte - RN</para> 
        /// <para>25 - Paraíba - PB</para> 
        /// <para>26 - Pernambuco - PE</para> 
        /// <para>27 - Alagoas - AL</para> 
        /// <para>28 - Sergipe - SE</para> 
        /// <para>29 - Bahia - BA</para> 
        /// <para>31 - Minas Gerais - MG</para> 
        /// <para>32 - Espírito Santo - ES</para> 
        /// <para>33 - Rio de Janeiro - RJ</para> 
        /// <para>35 - São Paulo - SP</para> 
        /// <para>41 - Paraná - PR</para> 
        /// <para>42 - Santa Catarina - SC</para> 
        /// <para>43 - Rio Grande do Sul (*) - RS</para> 
        /// <para>50 - Mato Grosso do Sul - MS</para> 
        /// <para>51 - Mato Grosso - MT</para> 
        /// <para>52 - Goiás - GO</para> 
        /// <para>53 - Distrito Federal - DF</para> 
        /// </summary> 
        public static readonly string[] UF_Sigla =
        {
            "RO", "AC", "AM", "RR", "PA", "AP", "TO", "MA", "PI",
            "CE", "RN", "PB", "PE", "AL", "SE", "BA", "MG", "ES",
            "RJ", "SP", "PR", "SC", "RS", "MS", "MT", "GO", "DF"
        };

        /// <summary> 
        /// Lista de códigos das UF
        /// 
        /// <para>11 - Rondônia - RO</para> 
        /// <para>12 - Acre - AC</para> 
        /// <para>13 - Amazonas - AM</para> 
        /// <para>14 - Roraima - RR</para> 
        /// <para>15 - Pará - PA</para> 
        /// <para>16 - Amapá - AP</para> 
        /// <para>17 - Tocantins - TO</para> 
        /// <para>21 - Maranhão - MA</para> 
        /// <para>22 - Piauí - PI</para> 
        /// <para>23 - Ceará - CE</para> 
        /// <para>24 - Rio Grande do Norte - RN</para> 
        /// <para>25 - Paraíba - PB</para> 
        /// <para>26 - Pernambuco - PE</para> 
        /// <para>27 - Alagoas - AL</para> 
        /// <para>28 - Sergipe - SE</para> 
        /// <para>29 - Bahia - BA</para> 
        /// <para>31 - Minas Gerais - MG</para> 
        /// <para>32 - Espírito Santo - ES</para> 
        /// <para>33 - Rio de Janeiro - RJ</para> 
        /// <para>35 - São Paulo - SP</para> 
        /// <para>41 - Paraná - PR</para> 
        /// <para>42 - Santa Catarina - SC</para> 
        /// <para>43 - Rio Grande do Sul (*) - RS</para> 
        /// <para>50 - Mato Grosso do Sul - MS</para> 
        /// <para>51 - Mato Grosso - MT</para> 
        /// <para>52 - Goiás - GO</para> 
        /// <para>53 - Distrito Federal - DF</para> 
        /// </summary> 
        public static readonly string[] UF_Codigo =
        {
            "11", "12", "13", "14", "15", "16", "17", "21", "22",
            "23", "24", "25", "26", "27", "28", "29", "31", "32",
            "33", "35", "41", "42", "43", "50", "51", "52", "53"
        };

        /// <summary> 
        /// IND_PROP - Indicador de propriedade/posse do item: 
        /// 
        /// <para>0 - Item de propriedade do informante e em seu poder;</para> 
        /// <para>1 - Item de propriedade do informante em posse de terceiros;</para> 
        /// <para>2- Item de propriedade de terceiros em posse do informante.</para>             
        /// </summary> 
        public static readonly string[] IND_PROP =
        {
            "0", "1", "2"
        };

        #region Configurações EFD Contribuições
        /// <summary> 
        /// TIPO_ESCRIT - Tipo de escrituração:
        /// 
        /// <para>0 - Original;</para> 
        /// <para>1 – Retificadora.</para> 
        /// </summary> 
        public static readonly string[] EFD_CONTRIB_TIPO_ESCRIT =
        {
            "0", "1"
        };

        /// <summary> 
        /// IND_ATIV - Indicador de tipo de atividade preponderante
        /// 
        /// <para>0 – Industrial ou equiparado a industrial</para> 
        /// <para>1 – Prestador de serviços</para> 
        /// <para>2 - Atividade de comércio</para> 
        /// <para>3 – Pessoas jurídicas referidas nos §§ 6º, 8º e 9º do art. 3º da Lei nº 9.718, de 1998</para> 
        /// <para>4 – Atividade imobiliária</para> 
        /// <para>9 – Outros</para> 
        /// <para></para> 
        /// </summary> 
        public static readonly string[] EFD_CONTRIB_IND_ATIV =
        {
            "0", "1", "2", "3", "4", "9"
        };

        /// <summary> 
        /// COD_INC_TRIB - Código indicador da incidência tributária no período
        /// 
        /// <para>1 – Escrituração de operações com incidência exclusivamente no regime não-cumulativo;</para> 
        /// <para>2 – Escrituração de operações com incidência exclusivamente no regime cumulativo</para> 
        /// <para>3 – Escrituração de operações com incidência nos regimes não-cumulativo e cumulativo</para> 
        /// </summary> 
        public static readonly string[] EFD_CONTRIB_INCIDENCIA =
        {
            "1", "2", "3"
        };
        #endregion

        #region Configurações EFD ICMS IPI
        /// <summary> 
        /// IND_ATIV - Tipo de atividade
        /// 
        /// <para>0 - Industrial ou equiparado a industrial</para> 
        /// <para>1 - Outros</para> 
        /// </summary> 
        public static readonly string[] EFD_ICPS_IPI_TIPO_ATIV =
        {
            "0", "1"
        };

        /// <summary> 
        /// CLAS_ESTAB_IND - Classificação de Contribuintes do IPI
        /// 
        /// <para>00 - Industrial - transformação</para> 
        /// <para>01 - Industrial - beneficiamento</para> 
        /// <para>02 - Industrial - montagem</para> 
        /// <para>03 - Industrial - acondicionamento ou reacondicionamento</para> 
        /// <para>04 - Industrial - renovação ou recondicionamento</para> 
        /// <para>05 - Equiparado a industrial - por opção</para> 
        /// <para>06 - Equiparado a industrial - importação direta</para> 
        /// <para>07 - Equiparado a industrial - por lei específica</para> 
        /// <para>08 - Equiparado a industrial - não enquadrado nos códigos 05, 06 ou 07</para> 
        /// <para>09 - Outros</para> 
        /// </summary>  
        public static readonly string[] EFD_ICPS_IPI_CLAS_ESTAB_IND =
        {
            "00", "01", "02", "03", "04", "05", "06", "07", "08", "09"
        };

        /// <summary> 
        /// Perfil de apresentação do arquivo fiscal
        /// 
        /// <para>A – Perfil A</para> 
        /// <para>B – Perfil B</para> 
        /// <para>C – Perfil C</para> 
        /// </summary> 
        public static readonly string[] EFD_ICPS_IPI_PERFIL =
        {
            "A", "B", "C"
        };

        /// <summary> 
        /// COD_FIN - Código da finalidade do arquivo:
        /// 
        /// <para>0 - Remessa do arquivo original;</para> 
        /// <para>1 - Remessa do arquivo substituto.</para> 
        /// </summary> 
        public static readonly string[] EFD_ICPS_IPI_FINALIDADE =
        {
            "0", "1"
        };
        #endregion
    }
}