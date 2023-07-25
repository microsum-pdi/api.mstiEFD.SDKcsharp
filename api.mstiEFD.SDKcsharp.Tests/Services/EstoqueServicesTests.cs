using api.mstiEFD.SDKcsharp.Services;
using api.mstiEFD.SDKcsharp.ViewModels;
using api.mstiEFD.SDKcsharp.ViewModels.Estoque;
using api.mstiEFD.SDKcsharp.ViewModels.NotaFiscal;

namespace api.mstiEFD.SDKcsharp.Tests.Services
{
    public class EstoqueServicesTests : GenericTests
    {
        private EstoqueServices _estoqueServices;

        public EstoqueServicesTests()
        {
            EfdConfigAmbienteSDK config = new(TOKEN, URL);
            _estoqueServices = new(config);
        }

        [Fact]
        public async Task DeveGerarArquivoEfdContribuicos()
        {
            EstoqueVM estoqueVM = new()
            {
                Produtos = new List<ProdutoVM>()
                {
                    new ProdutoVM()
                    {
                        Codigo = "001",
                        CodigoBarras = "7898938236034",
                        Descricao = "Produto teste 1",
                        Quantidade = 65,
                        ValorUnitario = 1083,
                        Unidade = new ()
                        {
                            Codigo = "001",
                            Simbolo = "UN"
                        },
                        Propriedade = "2",
                        Proprietario = new ()
                        {
                            Codigo = "01",
                            Nome = "Fornecedor teste 01",
                            Cod_Pais = "1058",
                            CNPJ = "05.462.662/0001-05",
                            CPF = "",
                            IE = "10.358.086-7",
                            SUFRAMA = "",
                            EnderecoUFSigla = "GO",
                            EnderecoUFCodigo = "52",
                            EnderecoCidadeCodigo = "5208707",
                            EnderecoLogradouro = "Rua",
                            EnderecoNumero = "90",
                            EnderecoComplemento = "90",
                            EnderecoBairro = "Setor Sul"
                        },
                        Tipo = "00",
                        Origem = "0",
                        NCM = "33072090",
                        CEST = "",
                        ICMS_Aliquota = 17,
                        ContaContabil = new ()
                        {
                            Codigo = "3",
                            DataInclusao = "2023-01-01",
                            Tipo = "S",
                            Nivel = 3,
                            NomeContaAnalitica = "INVENTÁRIO",
                            CodigoContaReceitaFederal = ""
                        },
                        ValorImpostoDeRenda = 0
                    },
                    new ProdutoVM()
                    {
                        Codigo = "002",
                        CodigoBarras = "7898938236034",
                        Descricao = "Produto teste 2",
                        Quantidade = 65,
                        ValorUnitario = 1083,
                        Unidade = new ()
                        {
                            Codigo = "001",
                            Simbolo = "UN"
                        },
                        Propriedade = "2",
                        Proprietario = new ()
                        {
                            Codigo = "01",
                            Nome = "Fornecedor teste 01",
                            Cod_Pais = "1058",
                            CNPJ = "05.462.662/0001-05",
                            CPF = "",
                            IE = "10.358.086-7",
                            SUFRAMA = "",
                            EnderecoUFSigla = "GO",
                            EnderecoUFCodigo = "52",
                            EnderecoCidadeCodigo = "5208707",
                            EnderecoLogradouro = "Rua",
                            EnderecoNumero = "90",
                            EnderecoComplemento = "90",
                            EnderecoBairro = "Setor Sul"
                        },
                        Tipo = "00",
                        Origem = "0",
                        NCM = "33072090",
                        CEST = "",
                        ICMS_Aliquota = 17,
                        ContaContabil = new ()
                        {
                            Codigo = "3",
                            DataInclusao = "2023-01-01",
                            Tipo = "S",
                            Nivel = 3,
                            NomeContaAnalitica = "INVENTÁRIO",
                            CodigoContaReceitaFederal = ""
                        },
                        ValorImpostoDeRenda = 0
                    }
                }
            };

            EfdResultVM<string> resp = await _estoqueServices.Atualizar(estoqueVM);

            Assert.Equal(resp.HttpStatusCode, Enums.EHttpStatusCode.OK);
        }

        [Fact]
        public async Task DevePesquisarProdutos()
        {
            EfdResultVM<EstoqueVM> resp = await _estoqueServices.Pesquisar(10, 0, "");
            Assert.Equal(resp.HttpStatusCode, Enums.EHttpStatusCode.OK);
        }
    }
}