using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ActionFilters.Filters
{
    public enum Drinks
    {
        TEA,
        CAFE,
        WATER
    }

    public class HelloWorldAttribute : ActionFilterAttribute
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Drinks OrderDrink { get; set; } //注意這個 Property

        public HelloWorldAttribute(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string n = this.Name;
            string drinks = this.OrderDrink.ToString();

            filterContext.HttpContext.Response.Write($"Log one thing: Test:{drinks}");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
    }
}