## SDK C# para integração com a ami.EFD ##

#### 1 - Escriturações Implementadas

- EFD ICMS IPI (SPED Fiscal):

A Escrituração Fiscal Digital - EFD é um arquivo digital, que se constitui de um conjunto de escriturações de documentos fiscais e de outras informações de interesse dos Fiscos das unidades federadas e da Secretaria da Receita Federal do Brasil, bem como de registros de apuração de impostos referentes às operações e prestações praticadas pelo contribuinte.
Este arquivo deverá ser assinado digitalmente e transmitido, via Internet, ao ambiente Sped.

- EFD Contribuições (SPED PIS/COFINS):

A EFD-Contribuições trata de arquivo digital instituído no Sistema Publico de Escrituração Digital – SPED, a ser utilizado pelas pessoas jurídicas de direito privado na escrituração da Contribuição para o PIS/Pasep e da Cofins, nos regimes de apuração não-cumulativo e/ou cumulativo, com base no conjunto de documentos e operações representativos das receitas auferidas, bem como dos custos, despesas, encargos e aquisições geradores de créditos da não cumulatividade.


#### 2 - Dependências

- Dotnet 6.0

------------


[TOC]

#### 3 - Configuração do ambiente

Antes de executar qualquer operação com a API ami.EFD. É necessário executar a configuração do ambiente.

Caso contrário, ao tentar consumir qualquer um dos serviços, será lançada a exceção:

**Necessário executar a configuração do ambiente (ConfigAmbienteSDKServices.ConfigurarAmbiente(new ConfigAmbienteSDK())), antes de comunicar com a API ami.EFD.**

Existem duas configurações que devem ser executadas para utilizar a api.EFD, utilizando este SDK:

**3.1- Configuração do ambiente de execução do SDK**

Este serviço é usado para configurar o token da empresa e a url onde a ami.EFD está sendo executada.

```csharp
ConfigAmbienteSDKServices.ConfigurarAmbiente(new ConfigAmbienteSDK() 
{ 
    Token = "Informe_o_token_da_empresa", URL = "informe_a_url_da_ami.dfe"
});
```

#### 4 - Envio de movimentações

Para que a API consiga gerar as escriturações, é necessário que o sistema usuário envie os seguintes blocos de informações:

**4.1- Notas Fiscais (NF-e e NFC-e)**

Movimentações relacionadas às notas fiscais emitidas, ou cadastradas do sistema usuário da API.

Estas movimentações devem ser enviadas para o seguinte serviço:

```
SDKServices.NotaFiscal.Enviar(new NotaFiscalVM(){...});
```

**4.2- Inventário**

Informação das quantidades em estoque dos produtos cadastrados no sistema usuário.

Estas informações devem ser enviadas para o seguinte serviço:

```
SDKServices.Inventario.Enviar(new InventarioVM(){...});
```

