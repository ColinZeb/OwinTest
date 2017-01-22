using Abp.WebApi.Controllers;
using OwinTest.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinTest.Controllers
{
    public class IOCController : AbpApiController
    {
        private ITestService Test { get; set; }

        public IOCController(ITestService test)
        {
            if (test == null)
            {
                throw new ArgumentNullException(nameof(test));
            }
            Test = test;    
        }
        public IHttpActionResult Get()
        {
            if (Test.GetTrue())
            {
                return Ok("got it");
            }
            return BadRequest();
        }

        public IHttpActionResult Post()
        {
            Test.ThrowException();
            return Ok();
        }
    }
}
