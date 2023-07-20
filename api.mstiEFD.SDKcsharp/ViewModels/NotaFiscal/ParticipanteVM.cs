using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels.Notifications;
using api.mstiEFD.SDKcsharp.ViewModels.ValueObjects;

namespace api.mstiEFD.SDKcsharp.ViewModels.NotaFiscal
{
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

        public void ExecutaValidacoes()
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
}