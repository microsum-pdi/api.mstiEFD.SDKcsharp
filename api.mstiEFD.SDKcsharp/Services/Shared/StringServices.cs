using api.mstiEFD.SDKcsharp.Extensions;
using System.Globalization;
using System.Text;

namespace api.mstiEFD.SDKcsharp.Services.Shared
{
    public static class StringServices
    {
        public static bool ValorContidoNaLista(string? valor, params string[] valores)
        {
            if (string.IsNullOrEmpty(valor)) return false;
            return valor.ContainedInList(false, valores);
        }

        /// <summary>
        /// Este método usa a classe StringBuilder para criar uma nova string sem acentos.
        /// Normaliza a string de entrada para a forma de decomposição canônica (FormD) e, em seguida, 
        /// itera sobre cada caractere da string normalizada.
        /// Se o caractere não for um caractere de marcação não espaçador (ou seja, um acento), ele é adicionado à nova string1
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string RemoveAcentos(string texto)
        {
            StringBuilder sbReturn = new();
            var arrayText = texto.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }

        public static bool ValorContidoNaLista(int? valor, params string[] valores)
        {
            if (valor == null) return false;
            return valor.ToString().ContainedInList(false, valores);
        }

        public static string NumerosAleatorios(int tamanho)
        {
            var chars = "0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        public static string PreparaValor(decimal valor, int casasDecimais)
        {
            // Verifica se os valores de casasDecimais é positivo
            if (casasDecimais < 0)
            {
                throw new ArgumentException("O valor de casasDecimais deve ser positivo.");
            }

            valor = Math.Round(valor, casasDecimais);

            string formato = "{0:0.";
            for (int i = 0; i < casasDecimais; i++)
            {
                formato += "0";
            }
            formato += "}";

            return string.Format(formato, valor);
        }
    }
}