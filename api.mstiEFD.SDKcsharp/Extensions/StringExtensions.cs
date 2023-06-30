using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Path = System.IO.Path;

namespace api.mstiEFD.SDKcsharp.Extensions
{
    public static class StringExtensions
    {

        /// <summary>
        /// Obtem uma substring com o tamanho máximo indicado
        /// </summary>
        /// <param name="source">string informada</param>
        /// <param name="maxLength">tamanho maximo da string de retorno</param>
        /// <returns>retorna uma string com no máximo maxLength</returns>
        public static string GetTamanhoMaximo(this string source, int maxLength)
        {
            if (source.Length <= maxLength)
            {
                return source;
            }

            return source.Substring(0, maxLength);
        }


        /// <summary>
        /// Verifica se uma string é nula, vazia ou espaço em branco
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNullOrEmptyOrWhiteSpace(this string text)
        {
            if (string.IsNullOrEmpty(text) && string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Verifica se uma string não é nula, vazia ou espaço em branco
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmptyOrWhiteSpace(this string text)
        {
            if (!string.IsNullOrEmpty(text) && !string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Substitui a primeira ocorrência pelo valor informado
        /// </summary>
        /// <param name="text">string de busca</param>
        /// <param name="search">padrão a ser buscado</param>
        /// <param name="replace">valor para substituir no lugar da string buscada</param>
        /// <returns></returns>
        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        /// <summary>
        /// <para>Substitui uma parte da string, somente se a palavra inteira coincidir com a pesquisa</para> 
        /// <para>Exemplo 01: string 'Microsum Tecnologia'</para> 
        /// <para>caso o valor de Find neste caso seja 'Microsum' a substituição sera feita pelo valor </para> 
        /// <para>passado no parametro Replace com sucesso.</para> 
        /// 
        /// <para>Exemplo02: string 'MicrosumTecnologia'</para> 
        /// <para>caso o valor de Find neste caso seja 'Microsum' a substituição não será feita pois</para> 
        /// <para>neste caso não foi encontrado uma palavra inteira 'Microsum' na string</para> 
        /// </summary>
        /// <returns></returns>
        public static string ReplaceExact(this string Valor, string Find, string Replace)
        {
            if (string.IsNullOrEmpty(Valor))
            {
                return "";
            }
            string Retorno = Regex.Replace(Valor.Replace("@", ""), @"\b" + Find.Replace("@", "") + @"\b", Replace).Trim();

            return Retorno;
        }

        /// <summary>
        /// Retorna a string convertida para Base64
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string FromStringToBase64(this string valor)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(valor));
        }

        /// <summary>
        /// Extrai o conteudo de uma string codificada em Base64
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string ToStringFromBase64(this string valor)
        {
            var valueBytes = System.Convert.FromBase64String(valor);
            return Encoding.UTF8.GetString(valueBytes);
        }

        /// <summary>
        /// Converte a primeira letra de uma string em maiuscula
        /// </summary>
        public static string GetStringComPrimeiraLetraMaiuscula(this string str)
        {
            return char.ToUpper(str[0]) + str.Remove(0, 1);
        }

        /// <summary>
        /// Retorna somente a parte numérica da string
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string SomenteNumeros(this string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return null;
            }
            return string.Join("", Regex.Split(valor, @"[^\d]"));
        }

        /// <summary>
        /// Remove todos os números de uma string
        /// </summary>
        public static string SomenteLetrasSemNumeros(this string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return null;
            }

            return Regex.Replace(valor, @"[\d-]", string.Empty);
        }

        /// <summary>
        /// Verifica se uma string pode está no padrão hexadecimal
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool IsHexadecimal(this string valor)
        {
            //create Regular Expression Match pattern object
            Regex myRegex = new Regex("^[a-fA-F0-9]+$");
            //boolean variable to hold the status
            bool isValid = false;
            if (string.IsNullOrEmpty(valor))
            {
                isValid = false;
            }
            else
            {
                isValid = myRegex.IsMatch(valor);
            }
            return isValid;
        }

        /// <summary>
        /// Verifica se a string passada no parâmetro é composta apenas de caracteres numéricos
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static bool IsNumeric(this string inputStr)
        {
            if (string.IsNullOrEmpty(inputStr) || string.IsNullOrWhiteSpace(inputStr)) return false;

            int periodCount = 0;
            int sinalCount = 0;

            return inputStr.Trim()
                .ToCharArray()
                .Where(c =>
                {
                    if (c == '.') periodCount++;

                    if (c == '-') sinalCount++;

                    return (Char.IsDigit(c) || c == '.' || c == '-') && periodCount <= 1 && sinalCount <= 1;
                })
                .Count() == inputStr.Trim().Length;

            /*if (input == null) throw new ArgumentNullException("input");

            string teste = input.ToString();
            BigInteger temp_big_int;
            var is_number = BigInteger.TryParse(teste, out temp_big_int);
            return is_number;*/
        }

        /// <summary>
        /// Gera o dígito verificador no padrão Mod 11
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string DVMod11(this string valor)
        {
            {
                int intTotalNumero = 0;

                // se nao for um valor numerico sai da função
                if (!valor.IsNumeric())
                {
                    throw new Exception("Falha na geração do Dígito Verificador");
                }

                // Inicia o multiplicador
                int intMultiplicador = 2;
                int contFor = valor.Length - 1;
                // pega cada caracter do numero a partir da direita

                while (contFor >= 0)
                {
                    // extrai o caractere atual
                    int intNumero = Int32.Parse(valor.ToString().Substring(contFor, 1));

                    // multiplica pelo multiplicador
                    intNumero = intNumero * intMultiplicador;

                    // Incrementa o multiplicador
                    intMultiplicador++;

                    // se o resultado for maior que nove soma os algarismos do resultado
                    if (intMultiplicador > 9)
                        intMultiplicador = 2;

                    // soma o resultado para totalização
                    intTotalNumero += intNumero;

                    contFor--;
                }

                // calcula o resto da divisao do total por 11
                int intResto = intTotalNumero % 11;

                int ValorDigito = 11 - intResto;
                // verifica as exceções ( 0 -> DV=0 1 -> DV=0 e retorna o DV
                switch (intResto)
                {
                    case 0:
                    case 1:
                        {
                            return "0";
                        }
                    default:
                        {
                            return ValorDigito.ToString();
                        }
                }
            }
        }

        /// <summary>
        /// Formata a linha digitável para o padrão utilizado nas impressões de boletos
        /// 
        /// 00190000090312855721619120217179188540000012345 => 00190.00009 03128.557216 19120.217179 1 88540000012345
        /// </summary>
        /// <param name="linhaDigitavel"></param>
        /// <returns></returns>
        public static string FormataLinhaDigitavelBoletos(this string linhaDigitavel)
        {
            if (!linhaDigitavel.IsNumeric()) { throw new Exception("Só é possível formatar a linha digitável de conteúdos numéricos"); }
            if (linhaDigitavel.Length != 47) { throw new Exception("Necessário uma linha digitável de 47 caracteres numéricos"); }

            return linhaDigitavel.Substring(0, 5) + "." +
                   linhaDigitavel.Substring(5, 5) + " " +
                   linhaDigitavel.Substring(10, 5) + "." +
                   linhaDigitavel.Substring(15, 6) + " " +
                   linhaDigitavel.Substring(21, 5) + "." +
                   linhaDigitavel.Substring(26, 6) + " " +
                   linhaDigitavel.Substring(32, 1) + " " +
                   linhaDigitavel.Substring(33, 14);
        }

        /// <summary>
        /// Recebe o valor no formato "12345" e retorna no padrão "123,45"
        /// </summary>
        /// <param name="valorOriginal"></param>
        /// <returns></returns>
        public static string ConverteValorInteiroParaDecimal(this string valorOriginal)
        {
            if (valorOriginal == null) return null;
            if (valorOriginal == "0") return "0,00";

            return valorOriginal.ToString().Substring(0, valorOriginal.ToString().Length - 2)
                   + "," +
                   valorOriginal.ToString().Substring(valorOriginal.ToString().Length - 2, 2);

        }

        /// <summary>
        /// Recebe a data no formato "yyyy.MM.dd" e retorna no padrão "dd/mm/aaaa"
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string FormataDataComBarras(this string data)
        {
            {
                return data.Substring(8, 2)
                       + "/" +
                       data.Substring(5, 2)
                       + "/" +
                       data.Substring(0, 4);
            }
        }

        /// <summary>
        /// Verifica se o conteudo da string, é igual a um dos itens do array "values"
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="BuscaAproximada"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool ContainedInList(this string valor, bool BuscaAproximada, ICollection<string> values)
        {
            string[] array = new string[values.Count];
            values.CopyTo(array, 0);

            return ContainedInList(valor, BuscaAproximada, array);
        }

        /// <summary>
        /// Verifica se o conteudo da string, é igual a um dos itens do array "values"
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="BuscaAproximada"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool ContainedInList(this string valor, bool BuscaAproximada, params string[] values)
        {
            for (int i = 0; i < values.Count(); i++)
            {
                if (BuscaAproximada)
                {
                    if (values[i].Contains(valor)) return true;
                }
                else
                {
                    if (valor == values[i]) return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Retorna a string somente com caracteres padrões (sem acentos)
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string RemoverAcentos(this string valor)
        {
            if (string.IsNullOrEmpty(valor))
                return valor;

            valor = Regex.Replace(valor, "[áàâãª]", "a");
            valor = Regex.Replace(valor, "[ÁÀÂÃÄ]", "A");
            valor = Regex.Replace(valor, "[éèêë]", "e");
            valor = Regex.Replace(valor, "[ÉÈÊË]", "E");
            valor = Regex.Replace(valor, "[íìîï]", "i");
            valor = Regex.Replace(valor, "[ÍÌÎÏ]", "I");
            valor = Regex.Replace(valor, "[óòôõöº]", "o");
            valor = Regex.Replace(valor, "[ÓÒÔÕÖ]", "O");
            valor = Regex.Replace(valor, "[úùûü]", "u");
            valor = Regex.Replace(valor, "[ÚÙÛÜ]", "U");
            valor = Regex.Replace(valor, "[Ç]", "C");
            valor = Regex.Replace(valor, "[ç]", "c");

            return valor;
        }

        /// <summary>
        /// Obtem o hash sha1 da string passada no parâmetro "input"
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Sha1(this string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        /// <summary>
        /// Verifica se uma string passada é uma letra maiuscula
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool IsLetraMaiuscula(this string valor)
        {
            string resto = Regex.Replace(valor, @"[A-Z]", string.Empty);

            if (resto.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Retorna um array de bytes de uma string informada
        /// </summary>
        /// <param name="value"></param>
        /// <returns>array de bytes</returns>
        public static byte[] GetBytes(this string value)
        {
            return Encoding.ASCII.GetBytes(value);
        }



        /// <summary>
        /// Converte uma string em Base64 para um array de bytes
        /// </summary>
        /// <param name="value">string codificada em Base64</param>
        /// <returns>array de bytes</returns>
        public static byte[] GetBytesFromBase64(this string value)
        {
            try
            {
                Byte[] bytes = Convert.FromBase64String(value);

                return bytes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Verifica se uma data passada em determinado formato é válida ou não
        /// </summary>
        /// <param name="dataString"></param>
        /// <param name="formato"></param>
        /// <returns></returns>
        public static bool IsValidDate(this string dataString, string formato)
        {
            DateTime dateTime;

            if (DateTime.TryParseExact(dataString, formato, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Retorna caracteres de uma string apartir da esquerda
        /// </summary>
        /// <param name="str"></param>
        /// <param name="tamanho">Quantidade de caracteres</param>
        /// <returns></returns>
        public static string TrimLeft(this string str, int tamanho)
        {
            if (string.IsNullOrEmpty(str)) str = string.Empty;
            str = str.Trim();
            return str.Substring(0, Math.Min(tamanho, str.Length));
        }

        /// <summary>
        /// Retorna caracteres de uma string apartir da direita
        /// </summary>
        /// <param name="str"></param>
        /// <param name="tamanho">Quantidade de caracteres</param>
        /// <returns></returns>
        public static string TrimRight(this string str, int tamanho)
        {
            if (string.IsNullOrEmpty(str)) str = string.Empty;
            str = str.Trim();
            return (str.Length >= tamanho)
                ? str.Substring(str.Length - tamanho, tamanho)
                : str;
        }

        /// <summary>
        /// Conversão de string para decimal
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public static decimal ToDecimal(this string valor, string cultureInfo = "en-US")
        {
            try
            {
                decimal valorConvertido = decimal.Parse(valor, CultureInfo.GetCultureInfo(cultureInfo));

                return valorConvertido;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao converter: " + valor + " em decimal " + ex.Message);
            }
        }

        /// <summary>
        /// Transforma uma string no formato "150099" em um decimal no formato: "1500.99"
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static decimal GeraDecimalAtravesDeValorStringSemVirgula(this string valor)
        {
            try
            {
                if (valor == "0") return decimal.Zero;

                int parteInteira = int.Parse(valor.Substring(0, valor.Length - 2));
                int parteDecimal = int.Parse(valor.Substring(valor.Length - 2, 2));

                decimal retorno = decimal.Parse($"{parteInteira},{parteDecimal}");
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao converter: " + valor + " em decimal " + ex.Message);
            }
        }

        /// <summary>
        /// Converte uma string em enum do tipo T
        /// </summary>
        /// <typeparam name="T">Tipo da enum para conversão</typeparam>
        /// <param name="enumString">string para converter na enum</param>
        /// <returns></returns>
        public static T ToEnum<T>(this string enumString)
        {
            return (T)Enum.Parse(typeof(T), enumString);
        }

        /// <summary>
        /// Verifica se a string corresponde à um JSON válido
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        public static bool IsJsonValid(this string strInput)
        {
            if (string.IsNullOrWhiteSpace(strInput)) { return false; }
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    return false;
                }
                catch (Exception) //some other exception
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Remove caracteres especiais de um string que será usada para criar pastas ou arquivos
        /// </summary> 
        /// <param name="strInput">String a ser tratada </param>
        /// <returns></returns>
        public static string RemoverCaracteresEspeciais(this string strInput)
        {
            if (string.IsNullOrEmpty(strInput))
                return strInput;

            //Remove acentos da string
            strInput = RemoverAcentos(strInput);

            //Remove os caracteres invalidos para criação de pastas e arquivos no Windows
            char[] CharInvalidos = Path.GetInvalidFileNameChars();

            foreach (char c in CharInvalidos)
            {
                strInput = strInput.Replace(c.ToString(), "");
            }

            return strInput;
        }


        /// <summary>
        /// Remove todos os espaços em branco de uma string
        /// </summary>
        /// <param name="input">string a ser tratada</param>
        /// <returns></returns>
        public static string RemoveEspacosEmBranco(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }


        /// <summary>
        /// Remove Caracteres especificos de uma string
        /// </summary>
        /// <param name="input">string inicial</param>
        /// <param name="caracteresParaRemover">array de caracteres que devem ser removidos da string original</param>
        /// <returns>string sem os caracteres informados em caracteresParaRemover</returns>
        public static string RemoveCaracteresEspecificos(this string input, string[] caracteresParaRemover)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(input);

            for (int i = 0; i < caracteresParaRemover?.Length; i++)
            {
                stringBuilder = stringBuilder.Replace(caracteresParaRemover[i], string.Empty);
            }

            return stringBuilder.ToString();
        }
    }
}
