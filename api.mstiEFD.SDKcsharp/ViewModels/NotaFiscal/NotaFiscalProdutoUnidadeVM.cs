using api.mstiEFD.SDKcsharp.ViewModels.Notifications;

namespace api.mstiEFD.SDKcsharp.ViewModels.NotaFiscal
{
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

        public void ExecutaValidacoes()
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
}