using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinTest.Test
{
    public interface ITestService
    {
        bool GetTrue();

        void ThrowException();


        IQueryable<Movie> QueryMovie();
    }
}
