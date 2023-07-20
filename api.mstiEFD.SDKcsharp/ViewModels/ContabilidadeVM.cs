using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels.Notifications;
using api.mstiEFD.SDKcsharp.ViewModels.ValueObjects;

namespace api.mstiEFD.SDKcsharp.ViewModels
{
    /// <summary>
    /// Informações da contabilidade da empresa
    /// </summary>
    public class ContabilidadeVM : EfdNotificavelVM
    {
        public ContabilidadeVM()
        { }

        public ContabilidadeVM(
            string nome, string cPF, string cRC, string cNPJ, string cEP, string logradouro, int numero,
            string complemento, string bairro, string telefone, string fax, string email, string cidadeCodigo
        )
        {
            Nome = nome;
            CPF = cPF;
            CRC = cRC;
            CNPJ = cNPJ;
            CEP = cEP;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Telefone = telefone;
            Fax = fax;
            Email = email;
            CidadeCodigo = cidadeCodigo;

            ExecutaValidacoes();
        }

        public void ExecutaValidacoes()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AddNotification("Contabilidade.Nome ('" + Nome + "')", EfdResources.ContabilidadeNomeNaoPreenchido);
            }

            if (string.IsNullOrEmpty(CPF))
            {
                AddNotification("Contabilidade.CPF ('" + CPF + "')", EfdResources.ContabilidadeCPFNaoPreenchido);
            }
            else if (new EfdCPF(CPF).Invalid)
            {
                AddNotification("Contabilidade.CPF ('" + CPF + "')", EfdResources.ContabilidadeCPFInvalido);
            }

            if (string.IsNullOrEmpty(CRC))
            {
                AddNotification("Contabilidade.CRC ('" + CRC + "')", EfdResources.ContabilidadeCRCNaoPreenchido);
            }

            if (!string.IsNullOrEmpty(CNPJ) && new EfdCNPJ(CNPJ).Invalid)
            {
                AddNotification("Contabilidade.CNPJ ('" + CNPJ + "')", EfdResources.ContabilidadeCNPJInvalido);
            }

            if (string.IsNullOrEmpty(Logradouro))
            {
                AddNotification("Contabilidade.Logradouro ('" + Logradouro + "')", EfdResources.ContabilidadeEnderecoLogradouroNaoPreenchido);
            }

            if (string.IsNullOrEmpty(CidadeCodigo))
            {
                AddNotification("Contabilidade.CidadeCodigo ('" + CidadeCodigo + "')", EfdResources.ContabilidadeEnderecoCodigoCidadeNaoPreenchido);
            }

            if (string.IsNullOrEmpty(Email))
            {
                AddNotification("Contabilidade.Email ('" + Email + "')", EfdResources.ContabilidadeEmailNaoPreenchido);
            }
        }

        public void RemoverAcentos()
        {
            Nome = StringServices.RemoveAcentos(Nome);
            Logradouro = StringServices.RemoveAcentos(Logradouro);
            Complemento = StringServices.RemoveAcentos(Complemento);
            Bairro = StringServices.RemoveAcentos(Bairro);
            Email = StringServices.RemoveAcentos(Email);
            Telefone = StringServices.RemoveAcentos(Telefone);
            Fax = StringServices.RemoveAcentos(Fax);
        }

        /// <summary>
        /// Nome do contabilista
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Número de inscrição do contabilista no CPF
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Número de inscrição do contabilista no Conselho Regional de Contabilidade
        /// </summary>
        public string CRC { get; set; }

        /// <summary>
        /// Número de inscrição do escritório de contabilidade no CNPJ, se houver
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        /// Código de Endereçamento Postal
        /// </summary>
        public string CEP { get; set; }

        /// <summary>
        /// Logradouro e endereço do imóvel
        /// </summary>
        public string Logradouro { get; set; }

        /// <summary>
        /// Número do imóvel.
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// Dados complementares do endereço
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// Bairro em que o imóvel está situado
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Número do telefone (DDD+FONE)
        /// </summary>
        public string Telefone { get; set; }

        /// <summary>
        /// Número do fax
        ///</summary>
        public string Fax { get; set; }

        ///<summary> 
        /// Endereço do correio eletrônico
        ///</summary> 
        public string Email { get; set; }

        ///<summary> 
        /// Código do município, conforme tabela IBGE
        ///</summary> 
        public string CidadeCodigo { get; set; }
    }
}