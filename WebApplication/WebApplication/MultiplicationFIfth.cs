using System;
using System.Web;

namespace WebApplication
{
    public class MultiplicationFIfth : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                //разместите здесь вашу реализацию обработчика.
                HttpRequest request = context.Request;
                HttpResponse response = context.Response;
                int a = int.Parse(request.QueryString["a"]);
                int b = int.Parse(request.QueryString["b"]);
                response.Write($"<h1>{a * b}</h1>");
            }
            catch (Exception exception)
            {
                //возвращается на 
                
            }

        }

        #endregion
    }
}
