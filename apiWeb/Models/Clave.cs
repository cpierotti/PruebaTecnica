using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiWeb.Models
{
    public class Clave
    {
        public string clave { get; set;}
        public string seguridad { get;set;}

    public Clave(string pClave, string pSeguridad)
        {
            this.clave=pClave;
            this.seguridad = pSeguridad;

        }

    }
}