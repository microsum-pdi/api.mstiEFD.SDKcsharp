using Flunt.Notifications;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NJsonSchema.Annotations;
using System.Runtime.Serialization;

namespace api.mstiEFD.SDKcsharp.ViewModels.Notifications
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [JsonObject(MemberSerialization = MemberSerialization.OptOut)]
    public class EfdNotificavelVM :  Notifiable<Notification>
    {
        [IgnoreDataMember]
        [JsonIgnore]
        public bool Invalid { get { return this.Notifications.Count > 0; } }

        [IgnoreDataMember]
        [JsonIgnore]
        public bool Valid { get { return !Invalid; } }

        [IgnoreDataMember]
        [JsonIgnore]
        [JsonSchemaIgnore]
        public IReadOnlyCollection<Notification> Notifications => base.Notifications;

        [IgnoreDataMember]
        [JsonIgnore]
        [JsonSchemaIgnore]
        public IReadOnlyCollection<Notification> Isvalid => base.Notifications;

        /// <summary>
        /// Retorna a lista de falhas de validação (propriedade "Notifications"), em uma lista de string
        /// </summary>
        /// <returns></returns>
        public List<string> NotificationsToList()
        {
            List<string> lista = new List<string>();

            lista.Clear();
            foreach (var item in Notifications)
            {
                lista.Add(item.Key + ": " + item.Message);
            }
            return Notifications.Select(n => $"{n.Key}: {n.Message}").ToList();
        }
    }
}