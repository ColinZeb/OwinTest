using Abp.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OwinTest.Web.Controllers
{
    public class RouteController:AbpApiController
    {
        [Route("api/att")]
        public IHttpActionResult Get()
        {
            if (Request.RequestUri.AbsolutePath.StartsWith(@"/api/att",  StringComparison.OrdinalIgnoreCase))
            {
                return Ok("it's work");
            }
            return BadRequest();
        }
    }
}