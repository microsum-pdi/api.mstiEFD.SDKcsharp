using api.mstiEFD.SDKcsharp.Services;
using api.mstiEFD.SDKcsharp.ViewModels;

namespace api.mstiEFD.SDKcsharp.Tests.Services
{
    public class EFD_ContribuicoesServicesTests : GenericTests
    {
        private EFD_ContribuicoesServices _eFD_ContribuicoesServices;

        public EFD_ContribuicoesServicesTests()
        {
            EfdConfigAmbienteSDK config = new(TOKEN, URL);
            _eFD_ContribuicoesServices = new(config);
        }

        [Fact]
        public async Task DeveGerarArquivoEfdContribuicos()
        {
            ConfigArquivoContribuicoesVM config = new()
            {
                DataInicial = PrimeiroDiaDoMesAtual(),
                DataFinal = UltimoDiaDoMesAtual(),
                Tipo = 0,
                TipoAtividade = "2",
                Incidencia = "1",
                ReciboEscrituracaoRetificada = "",
                AproveitarCreditoEntradas = true,
                GerarRegistros0900 = true,
                Contabilidade = new()
                {
                    Nome = "Emanuel e Martin Advocacia ME",
                    CPF = "140.771.580-10",
                    CRC = "123456-7",
                    CNPJ = "45.306.757/0001-46",
                    CEP = "11533-580",
                    Logradouro = "Rua Josefa Araújo de Oliveira",
                    Numero = 123,
                    Complemento = "Qd 47 Lt 10",
                    Bairro = "Parque São Luis",
                    Telefone = "(13) 2712-8983",
                    Fax = "(13) 98654-5881",
                    Email = "orcamento@emanuelemartinadvocaciame.com.br",
                    CidadeCodigo = "3513504"
                }
            };

            var resp = await _eFD_ContribuicoesServices.GerarArquivo(config);

            Assert.NotEqual(resp, "");
        }
    }
}