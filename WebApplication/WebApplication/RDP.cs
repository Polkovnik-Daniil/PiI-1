﻿using System;
using System.Web;

namespace WebApplication
{
    public class RDP : IHttpHandler
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
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //разместите здесь вашу реализацию обработчика.
            HttpResponse httpResponse = context.Response;
            httpResponse.Write("IISHANDLER");
            httpResponse.Write($"\n</br>{context.Request.UserHostAddress}");
            string ParamA = context.Request.QueryString["ParamA"],
                   ParamB = context.Request.QueryString["ParamB"];
            httpResponse.Write($"\n</br>PARAMA = {ParamA}</br>PARAMB = {ParamB}");

        }

        #endregion
    }
}