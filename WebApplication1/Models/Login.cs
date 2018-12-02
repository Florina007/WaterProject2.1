using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Login
    {
        public int ID { get; set; }
        public string Usename { get; set; }
        public string Password { get; set; }
        public int Accesability { get; set; }
    }
}