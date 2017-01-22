using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace OwinTest.Filters
{
    public class ApiFilter : ActionFilterAttribute
    {

        public override bool AllowMultiple
        {
            get
            {
                return false;
            }
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            // to do something
            var url = actionContext.Request.RequestUri.AbsolutePath;
            base.OnActionExecuting(actionContext);
        }
    }
}
