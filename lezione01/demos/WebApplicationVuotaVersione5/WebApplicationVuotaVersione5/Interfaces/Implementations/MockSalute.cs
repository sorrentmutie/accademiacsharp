using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVuotaVersione5.Interfaces.Implementations
{
    public class MockSalute : ISalute
    {
        public string GetSalute()
        {
            return "Mock Salute";
        }
    }
}
