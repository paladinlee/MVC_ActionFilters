using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Security.Principal;

namespace MVC_ActionFilters.Filters
{
    public class MVC5Authv2Attribute : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            //GenericPrincipal 很奇怪，VS2017 不會跳出讓我挑選 using System.Security.Principal;
            filterContext.Principal = new GenericPrincipal(filterContext.HttpContext.User.Identity, new[] { "Admin" });
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            var user = filterContext.HttpContext.User;
            if((user==null)||(!user.Identity.IsAuthenticated && !user.IsInRole("Admin")))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}