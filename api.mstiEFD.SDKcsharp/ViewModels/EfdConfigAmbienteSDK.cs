namespace api.mstiEFD.SDKcsharp.ViewModels
{
    public class EfdConfigAmbienteSDK
    {
        public EfdConfigAmbienteSDK()
        {
        }

        public EfdConfigAmbienteSDK(string token, string url)
        {
            Token = token;
            URL = url;
        }

        public string Token { get; set; }

        public string URL { get; set; }
    }
}