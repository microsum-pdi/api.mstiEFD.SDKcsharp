using api.mstiEFD.SDKcsharp.ViewModels.Notifications;

namespace api.mstiEFD.SDKcsharp.ViewModels.NotaFiscal
{
    public class NotaFiscalProdutoNaturezaOperacaoVM : EfdNotificavelVM
    {
        public NotaFiscalProdutoNaturezaOperacaoVM()
        { }

        public NotaFiscalProdutoNaturezaOperacaoVM(string codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;

            ExecutaValidacoes();
        }

        public void ExecutaValidacoes()
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