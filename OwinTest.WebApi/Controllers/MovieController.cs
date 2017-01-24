using OwinTest.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.OData;

namespace OwinTest.Controllers
{
    public class MovieController:ODataController
    {
        private ITestService Test { get; set; }
        public MovieController(ITestService test)
        {
            Test = test;
        }
        public IQueryable<Movie> GetMovie()
        {
            return Test.QueryMovie();
        }
    }
}
