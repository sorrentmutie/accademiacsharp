using System;

namespace WebApplicationVuotaVersione5.Interfaces.Implementations
{
    public class StaticSalute : ISalute
    {
        public string GetSalute()
        {
            return "Ciao, Insiel";
        }
    }
}
