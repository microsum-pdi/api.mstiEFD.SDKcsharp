namespace api.mstiEFD.SDKcsharp.Tests
{
    public class GenericTests
    {
        public const string TOKEN = "2ad82c82c282e816cac0a978dac9fdc534b46bf7";
        public const string URL = "http://192.168.1.250:9206/api.mstiEFD";

        protected DateTime PrimeiroDiaDoMesAtual()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }
        
        protected DateTime UltimoDiaDoMesAtual()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }
    }
}
