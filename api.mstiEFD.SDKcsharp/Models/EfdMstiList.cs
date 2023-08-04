namespace api.mstiEFD.SDKcsharp.Models
{
    public class EfdMstiList<T>: List<T>
    {
        /// <summary> 
        /// Quantidade total de registros que a lista poderá obter
        /// 
        /// <para>Utilizado para controles de paginação</para> 
        /// </summary> 
        public int Capacidade { get; set; }

        public void WithElements(IEnumerable<T> elements)
        {
            AddRange(elements);
        }
    }
}
