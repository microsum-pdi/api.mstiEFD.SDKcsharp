namespace api.mstiEFD.SDKcsharp.Extensions
{
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Obtém todas as messagens de erro das InnerException encadeadas
        /// </summary>
        /// <param name="e">InnerException</param>
        /// <returns>retorna a ultima mensagem</returns>
        public static string GetAllInnerExceptionMessage(this Exception e)
        {
            if (e?.InnerException == null)
            {
                return e?.Message;
            }
            else
            {
                return e?.Message + "\n" + GetAllInnerExceptionMessage(e?.InnerException);
            }
        }
    }
}