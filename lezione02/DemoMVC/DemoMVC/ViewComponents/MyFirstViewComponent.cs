using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DemoMVC.ViewComponents
{
    public class MyFirstViewComponent: ViewComponent
    {
        //public MyFirstViewComponent()
        //{

        //}

        public async Task<IViewComponentResult> InvokeAsync(int parametro)
        {
            var id = await FaiQualcosaDiAsincrono(parametro);
            // return Task.FromResult<IViewComponentResult>(View("Insiel"));
            return View("Insiel", id);
        }

        private async Task<int> FaiQualcosaDiAsincrono(int parametro)
        {
            await Task.Run(() => { });
            return parametro * 3;
        }


    }
}
