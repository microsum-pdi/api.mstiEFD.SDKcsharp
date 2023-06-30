using System.Globalization;

namespace api.mstiEFD.SDKcsharp.Services.Shared
{
    public static class DateTimeServices
    {
        public static DateTime DateTimeFromAAAA_MM_DD(string data)
        {
            if (!TestaData_AAAA_MM_DD(data)) throw new Exception("Não é possível gerar uma data, a partir da string: " + data + "");

            string[] datas = data.Split('-');

            return new DateTime(int.Parse(datas[0]), int.Parse(datas[1]), int.Parse(datas[2]));
        }

        public static bool TestaData_AAAA_MM_DD(string data)
        {
            return DateTime.TryParseExact(data, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
    }
}
