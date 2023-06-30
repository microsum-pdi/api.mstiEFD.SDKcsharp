namespace api.mstiEFD.SDKcsharp.Resources
{
    public class EfdResources
    {
        //Validação da atualização de estoque dos produtos
        public const string EstoqueInvalido = "Deve ser enviado um objeto no formato [EstoqueVM]";
        public const string EstoqueQuantidadeDeItensInvalida = "Deve ser enviada uma lista de produtos, com no máximo 200 itens";
        public const string EstoqueAliquotaInvalida = "A alíquota padrão do ICMS do item deve ser maior ou igual a 0";
        public const string EstoqueValorIRInvalido = "O valor do item para efeitos do Imposto de Renda, deve ser maior ou igual a 0";
        public const string EstoqueTipoInvalido = "O tipo do produto deve conter um dos seguintes valores: ";
        public const string EstoqueIndicadorPropriedadeInvalido = "O indicador de propriedade do produto deve conter um dos seguintes valores: ";
        public const string EstoqueErroAoSalvarNoBanco = "Erro ao salvar estoque dos produtos no banco de dados";

        //Configurações arquivo EFD        
        public const string DataFinalMenorQueDataInicial = "A data final deve ser superior à data inicial";

        //Configurações arquivo EFD ICPS-IPI
        public const string ConfigArquivoEFD_ICPS_IPI = "Deve ser enviado um objeto no formato [ConfigArquivoEFD_ICMS_IPI_VM]";
        public const string ConfigArquivoICMSTipoAtividadeInvalida = "O indicador do tipo de atividade (IND_ATIV), deve conter um dos seguintes valores: ";
        public const string ConfigArquivoICMSClasContribInvalida = "A classificação de contribuinte do IPI [CLAS_ESTAB_IND], deve conter um dos seguintes valores: ";
        public const string ConfigArquivoICMSPerfilInvalido = "O perfil de apresentação do arquivo fiscal, deve conter um dos seguintes valores: ";
        public const string ConfigArquivoICMSFinalidadeInvalida = "O código da finalidade do arquivo [COD_FIN], deve conter um dos seguintes valores: ";

        //Configurações arquivo EFD Contribuições
        public const string ConfigArquivoContrib = "Deve ser enviado um objeto no formato [ConfigArquivoContribuicoesVM]";
        public const string ConfigArquivoContribTipoEscrituracaoInvalida = "O tipo da escrituração (TIPO_ESCRIT), deve conter um dos seguintes valores: ";
        public const string ConfigArquivoContribTipoAtividadeInvalida = "O indicador de tipo de atividade preponderante [IND_ATIV], deve conter um dos seguintes valores: ";
        public const string ConfigArquivoContribIncidenciaInvalida = "O indicador da incidência tributária no período [COD_INC_TRIB], deve conter um dos seguintes valores: ";
        public const string ConfigArquivoContribRetificadoraSemReferencia = "Para gerar uma escrituração retificadora, é necessário referenciar o recibo da escrituração que está sendo retificada";

        //Validação da contabilidade
        public const string ContabilidadeNomeNaoPreenchido = "O nome do contabilista, deve ser informado";
        public const string ContabilidadeCPFNaoPreenchido = "O CPF do contabilista, deve ser informado";
        public const string ContabilidadeCPFInvalido = "O CPF do contabilista inválido";
        public const string ContabilidadeCRCNaoPreenchido = "O CRC do contabilista, deve ser informado";
        public const string ContabilidadeCNPJInvalido = "O CNPJ da contabilidade inválido";
        public const string ContabilidadeEnderecoLogradouroNaoPreenchido = "O logradouro do endereço da contabilidade, deve ser informado";
        public const string ContabilidadeEnderecoCodigoCidadeNaoPreenchido = "O código da cidade da contabilidade, deve ser informado";
        public const string ContabilidadeEmailNaoPreenchido = "O e-mail da contabilidade, deve ser informado";

        public const string ImplantacaoErro = "Erro ao fazer a implantação do banco de dados";
        public const string ImplantacaoSucesso = "Implantação do banco de dados executada com sucesso";

        public const string HealthCheckErro = "Acesso ao testar conexão à API";

        public const string ClienteBdNaoConfigurado = "Acesso ao banco de dados do cliente deve ser configurado";
        public const string ClienteBdLoginNaoConfigurado = "Nesessário configurar o usuário (SQLServer:Usuario) e senha (SQLServer:Senha) do banco de dados no arquivo 'appsettings.json'";

        //Mensagens das operações com a nota fiscal
        public const string NotaFiscalInvalida = "Deve ser enviado um objeto no formato [NotaFiscalVM]";
        public const string NotaFiscalErroAoSalvarNoBanco = "Erro ao salvar nova fiscal no banco de dados";
        public const string NotaFiscalOperacaoInvalida = "A operação deve conter um dos seguintes valores: ";
        public const string NotaFiscalTipoEmissaoInvalido = "O tipo de emissão deve conter um dos seguintes valores: ";
        public const string NotaFiscalFinalidadeInvalida = "A finalidade da emissão deve conter um dos seguintes valores: ";
        public const string NotaFiscalNaturezaOperacaoNaoInformada = "A natureza da operação deve ser informada";
        public const string NotaFiscalParticipanteNaoInformado = "O participante deve ser informado";
        public const string NotaFiscalModeloInvalido = "O modelo deve conter um dos seguintes valores: ";
        public const string NotaFiscalSituacaoInvalida = "A situacao deve conter um dos seguintes valores: ";
        public const string NotaFiscalChaveDeAcessoInvalida = "A chave de acesso deve deve ser informada com 44 caracteres numéricos";
        public const string NotaFiscalSerieInvalida = "A série da nota deve conter um valor entre 1 e 999";
        public const string NotaFiscalNumeroInvalido = "O número da nota deve conter um valor entre 1 e 999.999.999";
        public const string NotaFiscalDataEmissaoInvalida = "A data de emissão deve ser informada no formato AAAA-MM-DD";
        public const string NotaFiscalDataEntradaSaidaInvalida = "A data de entrada/saída deve ser informada no formato AAAA-MM-DD";
        public const string NotaFiscalTipoPagamentoInvalida = "O tipo do pagamento deve conter um dos seguintes valores: ";
        public const string NotaFiscalTipoTransporteInvalida = "O tipo do transporte deve conter um dos seguintes valores: ";

        //Mensagens de validação dos produtos das notas fiscais
        public const string NotaFiscalProdutoNumeroInvalido = "O número do item deve ser maior que zero";
        public const string NotaFiscalProdutoCodigoNaoInformado = "O código do produto deve ser informado";
        public const string NotaFiscalProdutoDescricaoNaoInformada = "A descrição do produto deve ser informada";
        public const string NotaFiscalProdutoQuantidadeInvalida = "A quantidade do item deve ter um valor maior ou igual a 0";
        public const string NotaFiscalProdutoValorInvalido = "O valor do item deve ser maior ou igual a 0";
        public const string NotaFiscalProdutoUnidadeNaoInformada = "A unidade de medida do produto deve ser informada";
        public const string NotaFiscalProdutoOrigemInvalida = "A origem do produto deve conter um dos seguintes valores: ";
        public const string NotaFiscalProdutoTipoInvalido = "O tipo do produto deve conter um dos seguintes valores: ";
        public const string NotaFiscalProdutoNCMNaoInformado = "O NCM do produto deve ser informado com 8 caracteres numéricos";
        public const string NotaFiscalProdutoCESTIncorreto = "O CEST do produto deve ser informado com 7 caracteres numéricos";
        public const string NotaFiscalProdutoMovimentadoInvalida = "A indicação de movimentação física do produto deve conter um dos seguintes valores: ";
        public const string NotaFiscalProdutoCFOPIncorreto = "O CFOP do produto deve ser informado com 4 caracteres numéricos";
        public const string NotaFiscalProdutoCST_CSOSN_ICMSInvalido = "O CST/CSOSN do ICMS do produto deve conter um dos seguintes valores: ";
        public const string NotaFiscalProdutoIPIApuracaoInvalida = "O indicador do período de apuração do IPI do produto deve conter um dos seguintes valores: ";
        public const string NotaFiscalProdutoCST_IPIInvalido = "O CST do IPI do produto deve conter um dos seguintes valores: ";
        public const string NotaFiscalProdutoPISCSTIncorreto = "O CST do PIS do produto deve conter um dos seguintes valores: ";
        public const string NotaFiscalProdutoCOFINSCSTIncorreto = "O CST do COFINS do produto deve conter um dos seguintes valores: ";
        public const string NotaFiscalProdutoDivergenciaCST_PIS_COFINS = "O CST do PIS e da COFINS do produto devem ser iguais";

        //Mensagens de validação das unidades de medida dos produtos das notas fiscais
        public const string NotaFiscalUnidadeCodigoNaoInformado = "O código da unidade de medida deve ser informado. (máximo 6 caracteres)";
        public const string NotaFiscalUnidadeDescricaoNaoInformada = "A descrição (símbolo) da unidade de medida deve ser informada";

        //Mensagens de validação da natureza da operacao
        public const string NotaFiscalNaturezaCodigoNaoInformado = "O código da natureza da operação deve ser informado. (máximo 10 caracteres)";
        public const string NotaFiscalNaturezaDescricaoNaoInformada = "A descrição da natureza da operação deve ser informada";

        //Mensagens de validação do participante
        public const string NotaFiscalParticipanteCodigoNaoInformado = "O código do participante da nota fiscal deve ser informado";
        public const string NotaFiscalParticipanteNomeNaoInformado = "O nome do participante da nota fiscal deve ser informado";
        public const string NotaFiscalParticipanteCodigoPaisNaoInformado = "O código do país do participante da nota fiscal deve ser informado";
        public const string NotaFiscalParticipanteSiglaUFInvalida = "A sigla da UF do participante, deve estar contida na lista: ";
        public const string NotaFiscalParticipanteCodigoUFInvalido = "O código da UF do participante, deve estar contido na lista: ";
        public const string NotaFiscalParticipanteCPFInvalido = "CPF do participante inválido";
        public const string NotaFiscalParticipanteCNPJInvalido = "CNPJ do participante inválido";
        public const string NotaFiscalParticipanteCPFCNPJNaoInformado = "Deve ser informado um CPF ou um CNPJ válido para o participante";
        public const string NotaFiscalParticipanteEnderecoCidadeCodigoNaoInformado = "O código do municipio do participante deve ser informado";
        public const string NotaFiscalParticipanteEnderecoLogradouroNaoInformado = "O endereço do participante deve ser informado";
        public const string NotaFiscalParticipanteEnderecoBairroNaoInformado = "O bairro do endereço do participante deve ser informado";

        //Configuração da api.mstiEFD.Core
        public const string CaminhoApiMstiEFDCoreNaoConfigurado = "Necessário criar a configuração 'APIs:api.mstiEFD.Core:Host' no arquivo 'appsettings.json'";

        //Geração arquivo EFD Contribuicoes
        public const string ErroAoSolicitarGeracaoEFDContribuicoes = "Erro ao solicitar geração do arquivo EFD Contribuições";

        //Geração arquivo EFD ICMS IPI
        public const string ErroAoSolicitarGeracaoEFD_ICMS_IPI = "Erro ao solicitar geração do arquivo EFD ICMS IPI";

        //Health Check
        public const string ErroAoSolicitarAoAcessarServicoHealthCheck = "Erro ao acessar endpoint health check";

        public const string NotaFiscalEnviadaParaAFila = "Nota fiscal enviada para a fila de processamento";
    }
}