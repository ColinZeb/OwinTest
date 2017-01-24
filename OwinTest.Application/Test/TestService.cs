using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinTest.Test
{
    public class TestService : ITestService
    {
        public bool GetTrue()
        {
            return true;
        }

        public IQueryable<Movie> QueryMovie()
        {
            return new[]
            {
                new Movie { ID = 1, Name = "GodFather" , Year = 1989 },
                new Movie { ID = 2, Name = "The Shawshank Redemption" , Year = 1994}
            }.AsQueryable();
        }

        public void ThrowException()
        {
            throw new NotSupportedException();
        }
    }
}
