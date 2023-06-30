using api.mstiEFD.SDKcsharp.ViewModels.Notifications;

namespace api.mstiEFD.SDKcsharp.ViewModels.ValueObjects.Base
{
    /// <summary>
    /// Essa classe foi criada para permitir que o EF Mapeie CPF e CNPJ no mesmo campo da Tabela Pessoa
    /// Pois o tipo a ser mapeado deve ser sempre concreto
    /// </summary>
    public class EfdBase_CPF_CNPJ : EfdNotificavelVM
    {
        public EfdBase_CPF_CNPJ() { }

        public string CPF_CNPJ { get; set; }


        public virtual bool isValid(string documento)
        {
            throw new System.Exception("Deve ser implementado nos filhos!");
        }

    }
}