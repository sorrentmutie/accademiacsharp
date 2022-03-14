using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDaTestare
{
    public class MiaClasse
    {
        private readonly ISmtpSender smtpSender;

        public MiaClasse(ISmtpSender smtpSender)
        {
            this.smtpSender = smtpSender;
        }

        public bool MioMetodo()
        {
            var check = false;
            // Logica per spedire una email
            //var smtpSender = new SmtpSender();
            if(check == true)
            {
                smtpSender.SendEmail("ciao");
            }
            // ....
            return true;
        }
    }
}
