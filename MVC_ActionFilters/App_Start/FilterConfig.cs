using MVC_ActionFilters.Filters;
using System.Web;
using System.Web.Mvc;

namespace MVC_ActionFilters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //在 FilterConfig.cs 加上我們新寫的 Attribute 方法
            filters.Add(new LogOutputAttribute());
        }
    }
}
