using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    //[Route("v1/[controller]")]
    [Route("[controller]/[action]")]
    public class EsperimentiController
    {

        [Route("")]
        public string Index()
        {
            return "Esperimenti";
        }

        //[Route("myabout/[action]")]
        //[Route("[action]")]
        public string About()
        {
            return "About";
        }

        [Route("{nome?}")]
        public string Ricerca(string nome)
        {
            return $"Hai inserito {nome}";
        }


    }
}
