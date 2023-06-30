using api.mstiEFD.SDKcsharp.ViewModels.Notifications;

namespace api.mstiEFD.SDKcsharp.ViewModels.ValueObjects
{
    public class EfdVoIE : EfdNotificavelVM
    {
        private string strIE { get; set; }

        public EfdVoIE(string IE, string UF)
        {
            if (IE != null)
            {
                this.strIE = IE;

                if (string.IsNullOrEmpty(IE) || !isValid(IE, UF))
                    AddNotification("IE", "Inscrição Estadual inválida");
            }
            else
            {
                AddNotification("IE", "Inscrição Estadual  inválida");
            }
        }

        public string getNumbers()
        {
            return String.Join("", System.Text.RegularExpressions.Regex.Split(this.strIE, @"[^\d]"));
        }

        public bool isValid(string documento, string uF)
        {
            return true;
        }
    }
}