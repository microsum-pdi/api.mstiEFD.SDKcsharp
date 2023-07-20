using api.mstiEFD.SDKcsharp.ViewModels.NotaFiscal;

namespace api.mstiEFD.SDKcsharp.ViewModels.Estoque
{
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
