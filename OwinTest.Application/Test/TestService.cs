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

        public void ThrowException()
        {
            throw new NotSupportedException();
        }
    }
}
