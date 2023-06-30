using api.mstiEFD.SDKcsharp.ViewModels.ValueObjects.Base;
using System.Text.RegularExpressions;

namespace api.mstiEFD.SDKcsharp.ViewModels.ValueObjects
{
    public class EfdCNPJ : EfdBase_CPF_CNPJ
    {
        private EfdCNPJ()
        {
        }

        public EfdCNPJ(string CPF_CNPJ)
        {
            if (CPF_CNPJ != null)
            {
                this.CPF_CNPJ = string.Join("", Regex.Split(CPF_CNPJ, @"[^\d]"));

                if (string.IsNullOrEmpty(CPF_CNPJ) || !isValid(CPF_CNPJ))
                    AddNotification("CNPJ", "ValueObjects.Cnpj.CNPJInvalido");
            }
            else
            {
                AddNotification("CNPJ", "ValueObjects.Cnpj.CNPJInvalido");
            }
        }

        public override bool isValid(string documento)
        {
            var valido = IsCnpjValido(documento);
            return valido;
        }


        public static string FormataCNPJ(string cnpj)
        {
            return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000/0000-00");
        }


        private bool IsCnpjValido(string vrCNPJ)
        {

            if (vrCNPJ == null)
                return false;

            string CNPJ = String.Join("", Regex.Split(vrCNPJ, @"[^\d]"));

            bool result = true;

            switch (CNPJ)
            {
                case "00000000000000":
                    result = false;
                    break;
                case "11111111111111":
                    result = false;
                    break;
                case "22222222222222":
                    result = false;
                    break;
                case "33333333333333":
                    result = false;
                    break;
                case "44444444444444":
                    result = false;
                    break;
                case "55555555555555":
                    result = false;
                    break;
                case "66666666666666":
                    result = false;
                    break;
                case "77777777777777":
                    result = false;
                    break;
                case "88888888888888":
                    result = false;
                    break;
                case "99999999999999":
                    result = false;
                    break;
            }
            if (result == false)
                return false;

            if (string.IsNullOrEmpty(CNPJ))
                return false;

            if (CNPJ.Length != 14)
                return false;

            int[] digitos, soma, resultado;
            int nrDig;
            string ftmt;
            bool[] CNPJOk;

            ftmt = "6543298765432";
            digitos = new int[14];
            soma = new int[2];
            soma[0] = 0;
            soma[1] = 0;
            resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;
            CNPJOk = new bool[2];
            CNPJOk[0] = false;
            CNPJOk[1] = false;

            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = int.Parse(
                        CNPJ.Substring(nrDig, 1));
                    if (nrDig <= 11)
                        soma[0] += (digitos[nrDig] *
                        int.Parse(ftmt.Substring(
                            nrDig + 1, 1)));
                    if (nrDig <= 12)
                        soma[1] += (digitos[nrDig] *
                        int.Parse(ftmt.Substring(
                            nrDig, 1)));
                }

                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                        CNPJOk[nrDig] = (
                        digitos[12 + nrDig] == 0);

                    else
                        CNPJOk[nrDig] = (
                        digitos[12 + nrDig] == (
                        11 - resultado[nrDig]));

                }

                return (CNPJOk[0] && CNPJOk[1]);
            }
            catch
            {
                return false;
            }
        }
    }
}