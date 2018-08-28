using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace WebApplication3
{
    public class TokenAuthorizeAttribute : AuthorizeAttribute
    {

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            IEnumerable<string> tokenValues;
            return actionContext.Request.Headers.TryGetValues("UserToken", out tokenValues)
                && tokenValues.Count() == 1 && tokenValues.First().Equals(StoreDB.UserToken);

        }
    }
}