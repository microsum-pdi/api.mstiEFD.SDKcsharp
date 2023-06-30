using api.mstiEFD.SDKcsharp.Enums;
using Newtonsoft.Json;

namespace api.mstiEFD.SDKcsharp.ViewModels
{
    /// <summary>
    /// Classe base para os retornos 
    /// </summary>
    public class EfdResultVM<T>
    {
        #region Propriedades
        /// <summary>
        /// Código HTTP da resposta para a requisição
        /// </summary>
        [JsonProperty(Order = 0)]
        public EHttpStatusCode HttpStatusCode { get; private set; }

        /// <summary> 
        /// Lista de mensagens de erros, alertas ou informações
        /// </summary>
        [JsonProperty(Order = 1)]
        public List<string> Messages { get; private set; }

        /// <summary> 
        /// Quantidade total de registros sendo retornados nesta requisição
        /// 
        /// <para>Utilizado para controles de paginação</para> 
        /// </summary> 
        [JsonProperty(Order = 2)]
        public int Count { get; private set; }

        /// <summary> 
        /// Quantidade total de registros existentes no repositório, que atendem aos critérios de pesquisa
        /// 
        /// <para>Utilizado para controles de paginação</para> 
        /// </summary> 
        [JsonProperty(Order = 3)]
        public int Total { get; private set; }

        /// <summary> 
        /// Lista de informações solicitadas
        /// 
        /// <para>Mesmo quando for solicitado apenas um recurso, será devolvido em uma lista</para> 
        /// </summary> 
        [JsonProperty(Order = 4)]
        public List<T> Data { get; private set; }

        #endregion

        public EfdResultVM()
        {
            HttpStatusCode = EHttpStatusCode.OK;
            Data = new List<T>();
            Messages = new List<string>();
        }

        #region Métodos acessórios
        /// <summary>
        /// Retorna o primeiro item da lista "Data", convertido para o tipo passado no parâmetro "T"
        /// </summary>
        /// <returns></returns>
        public T GetFirstData()
        {
            T Dado = Data.FirstOrDefault();

            if (Dado != null)
            {
                return Dado;
            }
            else
            {
                return default;
            }
        }
        #endregion

        #region BUILDERS
        public EfdResultVM<T> WithStatusCode(EHttpStatusCode statusCode)
        {
            HttpStatusCode = statusCode;
            return this;
        }

        public EfdResultVM<T> WithMessage(string message)
        {
            Messages.Add(message);
            return this;
        }

        public EfdResultVM<T> WithMessages(List<string> messages)
        {
            Messages.AddRange(messages);
            return this;
        }

        /// <summary>
        /// Possibilita ajustar a variável de controle de paginação. Útil quando o retorno é apenas um objeto. 
        /// Pois, por padrão, a propriedade capacity é iniciada com o valor 4
        /// </summary>
        /// <returns></returns>
        public EfdResultVM<T> WithTotal(int capacity)
        {
            Total = capacity;
            return this;
        }

        public EfdResultVM<T> WithData(T Dado)
        {
            Data.Add(Dado);

            AtualizaTotais();

            return this;
        }

        public EfdResultVM<T> WithDatas(List<T> Dados)
        {
            //Armazena os dados de paginação, para re-atribuí-los, logo abaixo
            int Capacidade = Dados.Capacity;

            Data.AddRange(Dados);

            //Ao acionar o método AddRange(), o valor da propriedade "Capacity" é perdido
            Data.Capacity = Capacidade;

            AtualizaTotais();

            return this;
        }

        private void AtualizaTotais()
        {
            Count = Data.Count;
            Total = Data.Capacity;
        }
        #endregion
    }
}