using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRazorLibrary.Models
{
    public static class MiaClasse
    {
        [JSInvokable]
        public static string[] RecuperaListastringhe()
        {
            return new string[] { "elemento1", "elemento2", "elemento3" };
        }


        [JSInvokable]
        public static Task<string[]> RecuperaListastringheAsync()
        {
            return Task.FromResult(new string[] { "elemento1", "elemento2", "elemento3" });
        }


        [JSInvokable]
        public static string RecuperaHtmlInfoWindow(string id)
        {
            return $"<h3> Dettaglio punto {id}</h3>";
        }
    }
}
