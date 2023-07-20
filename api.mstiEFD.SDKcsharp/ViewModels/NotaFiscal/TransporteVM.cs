using api.mstiEFD.SDKcsharp.ViewModels.Notifications;

namespace api.mstiEFD.SDKcsharp.ViewModels.NotaFiscal
{
    public class TransporteVM : EfdNotificavelVM
    {
        public TransporteVM()
        { }

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

            ExecutaValidacoes();
        }

        public void ExecutaValidacoes()
        {
            //Adiciona o transportador da CT-e na lista de itens validáveis
            if (Transportador != null)
            {
                Transportador.ExecutaValidacoes();
                AddNotifications(Transportador);
            }

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
}
