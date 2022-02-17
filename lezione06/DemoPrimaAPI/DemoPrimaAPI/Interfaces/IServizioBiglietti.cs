using DemoPrimaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DemoPrimaAPI.Interfaces
{
    
    public interface IServizioBiglietti 
    {
        List<BigliettoConcerto> EstraiBiglietti();
        BigliettoConcerto EstraiBiglietto(int id);
        void AggiungiBiglietto(BigliettoConcerto bigliettoConcerto);
        bool ModificaBiglietto(BigliettoConcerto bigliettoModificato);
    }
}
