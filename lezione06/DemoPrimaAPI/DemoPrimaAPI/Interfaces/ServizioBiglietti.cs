using DemoPrimaAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoPrimaAPI.Interfaces
{
    public class ServizioBiglietti : IServizioBiglietti
    {
        private List<BigliettoConcerto> concerti = new List<BigliettoConcerto> { 
            new BigliettoConcerto { Id = 1, Artista = "U2", Disponibile = true, Prezzo = 70}
        };

        public void AggiungiBiglietto(BigliettoConcerto bigliettoConcerto)
        {
            concerti.Add(bigliettoConcerto);
        }

        public List<BigliettoConcerto> EstraiBiglietti()
        {
            return concerti;
        }

        public BigliettoConcerto EstraiBiglietto(int id)
        {
           return concerti.FirstOrDefault( x=> x.Id == id);
        }

        public bool ModificaBiglietto(BigliettoConcerto bigliettoModificato)
        {
            var biglietto = concerti.FirstOrDefault(b => b.Id == bigliettoModificato.Id);
            if(biglietto != null)
            {
                biglietto.Artista = bigliettoModificato.Artista;
                biglietto.Prezzo = bigliettoModificato.Prezzo;
                biglietto.Disponibile = bigliettoModificato.Disponibile;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
