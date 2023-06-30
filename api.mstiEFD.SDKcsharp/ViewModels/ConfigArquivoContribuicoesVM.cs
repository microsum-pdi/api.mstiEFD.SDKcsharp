using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels.Notifications;
using NJsonSchema.Annotations;

namespace api.mstiEFD.SDKcsharp.ViewModels
{
    [JsonSchemaExtensionData("example",
  @"{
      ""DataInicial"": ""2023-05-01"",
      ""DataFinal"": ""2023-05-31"",
      ""Tipo"": ""0"",
      ""TipoAtividade"": ""2"",
      ""Incidencia"": ""1"",
      ""ReciboEscrituracaoRetificada"": """",
      ""AproveitarCreditoEntradas"": true,
      ""GerarRegistros0900"": true,      
      ""Contabilidade"": {
        ""Nome"": ""Emanuel e Martin Advocacia ME"",
        ""CPF"": ""140.771.580-10"",
        ""CRC"": ""123456-7"",
        ""CNPJ"": ""45.306.757/0001-46"",
        ""CEP"": ""11533-580"",
        ""Logradouro"": ""Rua Josefa Araújo de Oliveira"",
        ""Numero"": 123,
        ""Complemento"": ""Qd 47 Lt 10"",
        ""Bairro"": ""Parque São Luis"",
        ""Telefone"": ""(13) 2712-8983"",
        ""Fax"": ""(13) 98654-5881"",
        ""Email"": ""orcamento@emanuelemartinadvocaciame.com.br"",
        ""CidadeCodigo"": ""3513504""
      }
    }")]
    public class ConfigArquivoContribuicoesVM : EfdNotificavelVM
    {
        public ConfigArquivoContribuicoesVM()
        {            
        }

        public ConfigArquivoContribuicoesVM(
            DateTime dataInicial, DateTime dataFinal, int tipo, string tipoAtividade, string incidencia, string reciboEscrituracaoRetificada,
            bool aproveitarCreditoEntradas, bool gerarRegistros0900, ContabilidadeVM contabilidade
        )
        {            
            DataInicial = dataInicial;
            DataFinal = dataFinal;
            Tipo = tipo;
            TipoAtividade = tipoAtividade;
            Incidencia = incidencia;
            ReciboEscrituracaoRetificada = reciboEscrituracaoRetificada;
            AproveitarCreditoEntradas = aproveitarCreditoEntradas;
            GerarRegistros0900 = gerarRegistros0900;
            Contabilidade = contabilidade;

            ExecutaValidacoes();

            //Adiciona as informações da contabilidade na lista de itens validáveis
            if (contabilidade == null)
            {
                AddNotification("", "");
            }
            else
            {
                AddNotifications(contabilidade);
            }
        }

        private void ExecutaValidacoes()
        {
            if (DataFinal < DataInicial)
            {
                AddNotification("DataFinal ('" + DataFinal.ToString("dd/MM/yyyy") + "') < DataInicial ('" + DataInicial.ToString("dd/MM/yyyy") + "')", EfdResources.DataFinalMenorQueDataInicial);
            }

            if (!StringServices.ValorContidoNaLista(Tipo, EFD_CONTRIB_TIPO_ESCRIT))
            {
                AddNotification("Tipo ('" + Tipo + "')", EfdResources.ConfigArquivoContribTipoEscrituracaoInvalida + string.Join(", ", EFD_CONTRIB_TIPO_ESCRIT));
            }
            else if (Tipo == 1 && string.IsNullOrEmpty(ReciboEscrituracaoRetificada))
            {
                AddNotification("ReciboEscrituracaoRetificada ('" + ReciboEscrituracaoRetificada + "')", EfdResources.ConfigArquivoContribRetificadoraSemReferencia);
            }

            if (!StringServices.ValorContidoNaLista(TipoAtividade, EFD_CONTRIB_IND_ATIV))
            {
                AddNotification("TipoAtividade ('" + TipoAtividade + "')", EfdResources.ConfigArquivoContribTipoAtividadeInvalida + string.Join(", ", EFD_CONTRIB_IND_ATIV));
            }

            if (!StringServices.ValorContidoNaLista(Incidencia, EFD_CONTRIB_INCIDENCIA))
            {
                AddNotification("Incidencia ('" + Incidencia + "')", EfdResources.ConfigArquivoContribIncidenciaInvalida + string.Join(", ", EFD_CONTRIB_INCIDENCIA));
            }
        }

        /// <summary>
        /// Data inicial das informações contidas no arquivo (yyyy-MM-dd)
        /// </summary> 
        public DateTime DataInicial { get; set; }

        /// <summary>
        /// Data final das informações contidas no arquivo (yyyy-MM-dd)
        /// </summary> 
        public DateTime DataFinal { get; set; }

        /// <summary> 
        /// TIPO_ESCRIT - Tipo de escrituração:
        /// 
        /// <para>0 - Original;</para> 
        /// <para>1 – Retificadora.</para> 
        /// </summary> 
        public int Tipo { get; set; }

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
        public string TipoAtividade { get; set; }

        /// <summary> 
        /// COD_INC_TRIB - Código indicador da incidência tributária no período
        /// 
        /// <para>1 – Escrituração de operações com incidência exclusivamente no regime não-cumulativo;</para> 
        /// <para>2 – Escrituração de operações com incidência exclusivamente no regime cumulativo</para> 
        /// <para>3 – Escrituração de operações com incidência nos regimes não-cumulativo e cumulativo</para> 
        /// </summary> 
        public string Incidencia { get; set; }

        /// <summary>
        /// NUM_REC_ANTERIOR - Número do Recibo da Escrituração anterior a ser retificada, 
        /// utilizado quando TIPO_ESCRIT for igual a 1
        /// </summary>
        public string ReciboEscrituracaoRetificada { get; set; }

        /// <summary>
        /// Aproveitar Crédito do ICMS nas Entradas
        /// </summary>
        public bool AproveitarCreditoEntradas { get; set; }

        /// <summary>
        /// Gerar registro 0900 - Composição das Receitas do Período – Receita Bruta e Demais Receitas
        /// <para></para>
        /// 
        /// Registro a ser utilizado para detalhamento da composição das receitas do período, por bloco de registros da EFDContribuições.
        /// Sua escrituração é obrigatória sempre que o arquivo original da EFD-Contribuições for transmitido após o prazo 
        /// regular de entrega (após o 10º dia útil do 2º mês subsequente ao período de apuração a que se refere a escrituração).
        /// </summary>
        public bool GerarRegistros0900 { get; set; }

        public ContabilidadeVM Contabilidade { get; set; }
    }
}