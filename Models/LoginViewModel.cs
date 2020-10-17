using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Sensor.Models
{
    public class LoginViewModel
    {
        public string Utilizador { get; set; }
        public string Senha { get; set; }
        public bool LembrarMe { get; set; }
    }
}