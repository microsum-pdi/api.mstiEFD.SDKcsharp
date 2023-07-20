using api.mstiEFD.SDKcsharp.Extensions;
using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels.Notifications;

namespace api.mstiEFD.SDKcsharp.ViewModels.NotaFiscal
{
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

        public void ExecutaValidacoes()
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
}