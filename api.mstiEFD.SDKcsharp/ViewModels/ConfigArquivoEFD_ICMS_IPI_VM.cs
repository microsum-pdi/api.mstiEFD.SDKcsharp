using api.mstiEFD.SDKcsharp.Services.Shared;
using api.mstiEFD.SDKcsharp.ViewModels.Notifications;
using NJsonSchema.Annotations;

namespace api.mstiEFD.SDKcsharp.ViewModels
{
    [JsonSchemaExtensionData("example",
  @"{
      ""DataInicial"": ""2023-07-01"",
      ""DataFinal"": ""2023-07-31"",
      ""TipoAtividade"": ""0"",
      ""ClassificacaoContribuinte"": ""09"",
      ""Perfil"": ""A"",
      ""Finalidade"": 0,
      ""AproveitarCreditoEntradas"": true,
      ""BlocoK"": {
        ""EstoqueEscriturado"": true,
        ""ItensProduzidos"": true,
        ""InsumosConsumidos"": true
      },
      ""GerarInventario"": true,
      ""DataInventario"": ""2023-05-01"",
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
    public class ConfigArquivoEFD_ICMS_IPI_VM : EfdNotificavelVM
    {
        public ConfigArquivoEFD_ICMS_IPI_VM()
        {}

        public ConfigArquivoEFD_ICMS_IPI_VM(
            DateTime dataInicial, DateTime dataFinal, string tipoAtividade, string classificacaocontribuinte, string perfil,
            int finalidade, bool aproveitarCreditoEntradas, BlocoKVM blocoK, bool gerarInventario, ContabilidadeVM contabilidade
        )
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
            TipoAtividade = tipoAtividade;
            ClassificacaoContribuinte = classificacaocontribuinte;
            Perfil = perfil;
            Finalidade = finalidade;
            AproveitarCreditoEntradas = aproveitarCreditoEntradas;
            BlocoK = blocoK;
            GerarInventario = gerarInventario;
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

        public void ExecutaValidacoes()
        {
            if (DataFinal < DataInicial)
            {
                AddNotification("DataFinal ('" + DataFinal.ToString("dd/MM/yyyy") + "') < DataInicial ('" + DataInicial.ToString("dd/MM/yyyy") + "')", EfdResources.DataFinalMenorQueDataInicial);
            }

            if (!StringServices.ValorContidoNaLista(TipoAtividade, EFD_ICPS_IPI_TIPO_ATIV))
            {
                AddNotification("TipoAtividade ('" + TipoAtividade + "')", EfdResources.ConfigArquivoICMSTipoAtividadeInvalida + string.Join(", ", EFD_ICPS_IPI_TIPO_ATIV));
            }

            if (!StringServices.ValorContidoNaLista(ClassificacaoContribuinte, EFD_ICPS_IPI_CLAS_ESTAB_IND))
            {
                AddNotification("ClassificacaoContribuinte ('" + ClassificacaoContribuinte + "')", EfdResources.ConfigArquivoICMSClasContribInvalida + string.Join(", ", EFD_ICPS_IPI_CLAS_ESTAB_IND));
            }

            if (!StringServices.ValorContidoNaLista(Perfil, EFD_ICPS_IPI_PERFIL))
            {
                AddNotification("Perfil ('" + Perfil + "')", EfdResources.ConfigArquivoICMSPerfilInvalido + string.Join(", ", EFD_ICPS_IPI_PERFIL));
            }

            if (!StringServices.ValorContidoNaLista(Finalidade, EFD_ICPS_IPI_FINALIDADE))
            {
                AddNotification("Finalidade ('" + Finalidade + "')", EfdResources.ConfigArquivoICMSFinalidadeInvalida + string.Join(", ", EFD_ICPS_IPI_FINALIDADE));
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
        /// IND_ATIV - Tipo de atividade
        /// 
        /// <para>0 - Industrial ou equiparado a industrial</para> 
        /// <para>1 - Outros</para> 
        /// </summary> 
        public string TipoAtividade { get; set; }

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
        public string ClassificacaoContribuinte { get; set; }

        /// <summary> 
        /// Perfil de apresentação do arquivo fiscal
        /// 
        /// <para>A – Perfil A</para> 
        /// <para>B – Perfil B</para> 
        /// <para>C – Perfil C</para> 
        /// </summary> 
        public string Perfil { get; set; }

        /// <summary> 
        /// COD_FIN - Código da finalidade do arquivo:
        /// 
        /// <para>0 - Remessa do arquivo original;</para> 
        /// <para>1 - Remessa do arquivo substituto.</para> 
        /// </summary> 
        public int Finalidade { get; set; }

        /// <summary>
        /// Aproveitar Crédito do ICMS nas Entradas
        /// </summary>
        public bool AproveitarCreditoEntradas { get; set; }

        public BlocoKVM BlocoK { get; set; }

        /// <summary>
        /// Gerar Bloco H - Inventário Físico
        /// </summary>
        public bool GerarInventario { get; set; }

        /// <summary>
        /// DT_INV - Data do inventário (yyyy-MM-dd)
        /// </summary> 
        public DateTime DataInventario { get; set; }

        public ContabilidadeVM Contabilidade { get; set; }
    }

    /// <summary>
    /// Bloco K - Controle da Produção e do Estoque
    /// </summary>
    public class BlocoKVM
    {
        public BlocoKVM()
        {}

        /// <summary>
        /// Gerar K200 - Estoque Escriturado
        /// </summary>
        public bool EstoqueEscriturado { get; set; }

        /// <summary>
        /// Gerar K230 - Itens Produzidos
        /// </summary>
        public bool ItensProduzidos { get; set; }

        /// <summary>
        /// Gerar K235 - Insumos Consumidos
        /// </summary>
        public bool InsumosConsumidos { get; set; }
    }
}