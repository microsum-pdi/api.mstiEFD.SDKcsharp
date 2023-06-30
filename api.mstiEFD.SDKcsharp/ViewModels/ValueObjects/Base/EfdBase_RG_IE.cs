using api.mstiEFD.SDKcsharp.ViewModels.Notifications;

namespace api.mstiEFD.SDKcsharp.ViewModels.ValueObjects.Base
{
    /// <summary>
    /// Essa classe foi criada para permitir que o EF Mapeie RG e IE no mesmo campo da Tabela Pessoa
    /// Pois o tipo a ser mapeado deve ser sempre concreto
    /// </summary>
    public class EfdBase_RG_IE : EfdNotificavelVM
    {
        public EfdBase_RG_IE() { }

        public string RG_IE { get; set; }

        public virtual bool isValid(string documento)
        {
            throw new System.Exception("Deve ser implementado nos filhos!");
        }
    }
}