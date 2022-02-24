using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.ReqRes
{
    public class ReqResNewUser
    {
        [Required(ErrorMessage = "Nome obbligatorio")]
        public string name { get; set; }
        public string job { get; set; }
        public DateTime date { get; set; } = DateTime.Today;
    }

    public class ReqResResponse
    {
        public string id { get; set; }
        public string job { get; set; }
        public string name { get; set; }
        public DateTime createdAt { get; set; }
    }
}
