using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC_ActionFilters.Filters
{
    public class LogToFileAttribute : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            StringBuilder message = new StringBuilder();
            message.Append(DateTime.Now.ToString());
            message.AppendLine(filterContext.Exception.ToString());
            message.AppendLine("===================");
            string filePath = "~/App_Data/"+DateTime.Now.ToString("yyyy-MM-dd")+".txt";
            System.IO.File.AppendAllText(HttpContext.Current.Server.MapPath(filePath), message.ToString());
        }
    }
}