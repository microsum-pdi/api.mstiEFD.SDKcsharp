using api.mstiEFD.SDKcsharp.ViewModels.Notifications;

namespace api.mstiEFD.SDKcsharp.ViewModels.NotaFiscal
{
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
}