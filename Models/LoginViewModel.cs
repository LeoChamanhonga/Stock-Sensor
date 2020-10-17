using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stock_Sensor.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe o utilizador")]
        [Display(Name ="Utilizador")]
        public string Utilizador { get; set; }
        [Required(ErrorMessage ="Informe a Senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public bool LembrarMe { get; set; }
    }
}