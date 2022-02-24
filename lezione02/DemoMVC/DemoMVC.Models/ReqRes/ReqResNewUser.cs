using System;

namespace DemoMVC.Models.ReqRes
{
    public class ReqResNewUser
    {
        public string name { get; set; }
        public string job { get; set; }
    }

    public class ReqResResponse
    {
        public string id { get; set; }
        public string job { get; set; }
        public string name { get; set; }
        public DateTime createdAt { get; set; }
    }
}
