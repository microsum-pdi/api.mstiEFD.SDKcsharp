using api.mstiEFD.SDKcsharp.Resources;
using api.mstiEFD.SDKcsharp.Services;
using api.mstiEFD.SDKcsharp.ViewModels;
using api.mstiEFD.SDKcsharp.ViewModels.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api.mstiEFD.SDKcsharp.Tests.Services
{
    public class NotasFiscaisServicesTests : GenericTests
    {
        private NotasFiscaisServices _notasFiscaisServices;

        public NotasFiscaisServicesTests()
        {
            EfdConfigAmbienteSDK config = new(TOKEN, URL);
            _notasFiscaisServices = new(config);
        }

        [Fact]
        public async Task DeveSalvarNotaFiscal()
        {
            NotaFiscalVM notaVM = new()
            {
                Operacao = Constantes.IND_OPER_ENTRADA,
                TipoEmissao = "1",
                Finalidade = "1",
                NaturezaOperacao = new()
                {
                    Codigo = "001",
                    Descricao = "Compra para comercialização"
                },
                Participante = new()
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
                ModeloDocumento = Constantes.NFE,
                Situacao = "01",
                Serie = 1,
                Numero = 1,
                Chave = "42210780078934000185550010000097511171825601",
                DataEmissao = DateTime.Now.ToString("yyyy-MM-dd"),
                DataEntradaSaida = DateTime.Now.ToString("yyyy-MM-dd"),
                ValorTotal = 2231.18M,
                TipoPagamento = "1",
                ValorDesconto = 113.22M,
                ValorAbatimento = 0,
                ValorMercadorias = 2311.18M,
                TipoTransporte = "0",
                ValorFrete = 0,
                ValorSeguro = 0,
                ValorDespesas = 0,
                ICMS_BC = 0,
                ICMS_Valor = 0,
                ICMS_ST_BC_Valor = 0,
                ICMS_ST_Retido_Valor = 0,
                IPI_Valor = 0,
                PIS_Valor = 0,
                PIS_ST_Valor = 0,
                COFINS_Valor = 0,
                COFINS_ST_Valor = 0,
                Transporte = new()
                {
                    Transportador = new()
                    {
                        Codigo = "16",
                        Nome = "EDB CARDOSO - AMIGO EXPRESS ME",
                        Cod_Pais = "1058",
                        CNPJ = "09478767000367",
                        CPF = "",
                        IE = "129119406110",
                        SUFRAMA = "",
                        EnderecoUFSigla = "SP",
                        EnderecoUFCodigo = "35",
                        EnderecoCidadeCodigo = "3550308",
                        EnderecoLogradouro = "RUA ANTÔNIO FONSECA",
                        EnderecoNumero = "",
                        EnderecoComplemento = "",
                        EnderecoBairro = "VILA MARIA BAIXA"
                    },
                    ModeloDocumento = "57",
                    Situacao = "00",
                    Serie = 1,
                    Numero = 42171,
                    Chave = "35230109478767000367570010000421711001600367",
                    DataEmissao = DateTime.Now.ToString("yyyy-MM-dd"),
                    DataPrestacao = DateTime.Now.ToString("yyyy-MM-dd"),
                    ValorTotal = 703.60M,
                    ICMS_ST = "00",
                    ICMS_BC = 703.60M,
                    ICMS_Aliquota = 3,
                    ICMS_Valor = 49.25M,
                    CFOP = "1351",
                    CodigoContaContabil = "18",
                    PIS_CST = "99",
                    PIS_BC = 703.60M,
                    PIS_Aliquota = 0,
                    PIS_Valor = 0,
                    COFINS_CST = "99",
                    COFINS_BC = 703.60M,
                    COFINS_Aliquota = 0,
                    COFINS_Valor = 0,
                    ContaContabil = new()
                    {
                        Codigo = "18",
                        DataInclusao = "2023-01-01",
                        Tipo = "S",
                        Nivel = 3,
                        NomeContaAnalitica = "PAGAMENTO TRANSPORTE",
                        CodigoContaReceitaFederal = ""
                    }
                },
                Produtos = new List<NotaFiscalProdutoVM>()
                {
                    new NotaFiscalProdutoVM()
                    {
                        Numero = 1,
                        Codigo = "001",
                        CodigoBarras = "7898938236034",
                        Descricao = "Produto teste 1",
                        Quantidade = 24,
                        Unidade = new()
                        {
                            Codigo = "001",
                            Simbolo = "UN"
                        },
                        Tipo = "00",
                        Origem = "0",
                        NCM = "33072090",
                        CEST = "",
                        ValorTotal = 1083,
                        Desconto = 57,
                        Movimentado = 0,
                        CFOP = "2102",
                        ValorFrete = 0,
                        ValorSeguro = 0,
                        ValorDespesas = 0,
                        ICMS_CST = "101",
                        ICMS_BC = 1123.28M,
                        ICMS_Aliquota = 4,
                        ICMS_Valor = 0,
                        ICMS_ST_BC = 0,
                        ICMS_ST_Aliquota = 0,
                        ICMS_ST_Valor = 0,
                        ICMS_DIFAL_vBCUFDest = 0,
                        ICMS_DIFAL_vBCFCPUFDest = 0,
                        ICMS_DIFAL_pFCPUFDest = 0,
                        ICMS_DIFAL_pICMSUFDest = 0,
                        ICMS_DIFAL_pICMSInter = 0,
                        ICMS_DIFAL_vFCPUFDest = 0,
                        ICMS_DIFAL_vICMSUFDest = 0,
                        ICMS_DIFAL_vICMSUFRemet = 0,
                        IPI_Apuracao = "0",
                        IPI_CST = "49",
                        IPI_Enquadramento = "",
                        IPI_BC = 0,
                        IPI_Aliquota = 0,
                        IPI_Valor = 0,
                        PIS_CST = "01",
                        PIS_BC = 0,
                        PIS_Aliquota = 0,
                        PIS_BC_Quantidade = 0,
                        PIS_Aliquota_Reais = 0,
                        PIS_Valor = 0,
                        COFINS_CST = "01",
                        COFINS_BC = 0,
                        COFINS_Aliquota = 0,
                        COFINS_BC_Quantidade = 0,
                        COFINS_Aliquota_Reais = 0,
                        COFINS_Valor = 0,
                        ContaContabil = new()
                        {
                            Codigo= "8",
                            DataInclusao= "2023-01-01",
                            Tipo= "S",
                            Nivel=3,
                            NomeContaAnalitica= "COMPRAS E SERVIÇOS",
                            CodigoContaReceitaFederal= ""
                        },
                        ValorAbatimento = 0
                    },
                    new NotaFiscalProdutoVM()
                    {
                        Numero = 2,
                        Codigo = "002",
                        CodigoBarras = "7894900911510",
                        Descricao = "Produto teste 2",
                        Quantidade = 24,
                        Unidade = new()
                        {
                            Codigo = "002",
                            Simbolo = "MT"
                        },
                        Tipo = "00",
                        Origem = "0",
                        NCM = "33072090",
                        CEST = "",
                        ValorTotal = 1068.18M,
                        Desconto = 56.22M,
                        Movimentado = 0,
                        CFOP = "2102",
                        ValorFrete = 0,
                        ValorSeguro = 0,
                        ValorDespesas = 0,
                        ICMS_CST = "101",
                        ICMS_BC = 1107.9M,
                        ICMS_Aliquota = 4,
                        ICMS_Valor = 0,
                        ICMS_ST_BC = 0,
                        ICMS_ST_Aliquota = 0,
                        ICMS_ST_Valor = 0,
                        ICMS_DIFAL_vBCUFDest = 0,
                        ICMS_DIFAL_vBCFCPUFDest = 0,
                        ICMS_DIFAL_pFCPUFDest = 0,
                        ICMS_DIFAL_pICMSUFDest = 0,
                        ICMS_DIFAL_pICMSInter = 0,
                        ICMS_DIFAL_vFCPUFDest = 0,
                        ICMS_DIFAL_vICMSUFDest = 0,
                        ICMS_DIFAL_vICMSUFRemet = 0,
                        IPI_Apuracao = "0",
                        IPI_CST = "49",
                        IPI_Enquadramento = "",
                        IPI_BC = 0,
                        IPI_Aliquota = 0,
                        IPI_Valor = 0,
                        PIS_CST = "01",
                        PIS_BC = 0,
                        PIS_Aliquota = 0,
                        PIS_BC_Quantidade = 0,
                        PIS_Aliquota_Reais = 0,
                        PIS_Valor = 0,
                        COFINS_CST = "01",
                        COFINS_BC = 0,
                        COFINS_Aliquota = 0,
                        COFINS_BC_Quantidade = 0,
                        COFINS_Aliquota_Reais = 0,
                        COFINS_Valor = 0,
                        ContaContabil = new()
                        {
                            Codigo = "8",
                            DataInclusao = "2023-01-01",
                            Tipo = "S",
                            Nivel = 3,
                            NomeContaAnalitica = "COMPRAS E SERVIÇOS",
                            CodigoContaReceitaFederal = ""
                        },
                        ValorAbatimento = 0
                    }

                }
            };

            EfdResultVM<string> resp = await _notasFiscaisServices.Add(notaVM);

            Assert.Equal(resp.HttpStatusCode, Enums.EHttpStatusCode.OK);
        }
    }
}