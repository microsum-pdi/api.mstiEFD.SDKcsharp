using api.mstiEFD.SDKcsharp.Services;
using api.mstiEFD.SDKcsharp.ViewModels;
using api.mstiEFD.SDKcsharp.Resources;

namespace api.mstiEFD.SDKcsharp.Tests.Services
{
    public class EFD_ICMS_IPIServicesTests : GenericTests
    {
        private EFD_ICMS_IPIServices _eFD_ICMS_IPIServices;

        public EFD_ICMS_IPIServicesTests()
        {
            EfdConfigAmbienteSDK config = new(TOKEN, URL);
            _eFD_ICMS_IPIServices = new(config);
        }

        [Fact]
        public async Task DeveGerarArquivoEfdIcmsIpi()
        {
            ConfigArquivoEFD_ICMS_IPI_VM config = new()
            {
                DataInicial = PrimeiroDiaDoMesAtual(),
                DataFinal = UltimoDiaDoMesAtual(),
                TipoAtividade = Constantes.IND_ATIV_INDUSTRIAL_OU_EQUIPARADO,
                ClassificacaoContribuinte = Constantes.CLAS_ESTAB_IND_OUTROS,
                Perfil = Constantes.PERFIL_A,
                Finalidade = Constantes.COD_FIN_ARQUIVO_ORIGINAL,
                AproveitarCreditoEntradas = true,
                BlocoK = new()
                {
                    EstoqueEscriturado = true,
                    ItensProduzidos = true,
                    InsumosConsumidos = true
                },
                GerarInventario = true,
                DataInventario = DateTime.Now,
                Contabilidade = new()
                {
                    Nome = "Emanuel e Martin Advocacia ME",
                    CPF = "140.771.580 - 10",
                    CRC = "123456 - 7",
                    CNPJ = "45.306.757 / 0001 - 46",
                    CEP = "11533 - 580",
                    Logradouro = "Rua Josefa Araújo de Oliveira",
                    Numero = 123,
                    Complemento = "Qd 47 Lt 10",
                    Bairro = "Parque São Luis",
                    Telefone = "(13) 2712 - 8983",
                    Fax = "(13) 98654 - 5881",
                    Email = "orcamento @emanuelemartinadvocaciame.com.br",
                    CidadeCodigo = "3513504"
                }
            };

            var resp = await _eFD_ICMS_IPIServices.GerarArquivo(config);

            Assert.NotEqual(resp, "");
        }
    }
}