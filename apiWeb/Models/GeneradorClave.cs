using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;

namespace apiWeb.Models
{
    public class GeneradorClave
    {
        public string level { get; set; }

        public int longitud { get; set; }
        
        public GeneradorClave(string pLevel, int longitud)
        {
            this.level = pLevel;
            this.longitud = longitud;
        }

        public string GenerarClave(string pLevel, int pLongitud)
        {

            StringBuilder password = new StringBuilder("");
            Random aleatorio = new Random();
            char[] lista = {'a', 'b', 'c', 'd','e', 'f','g', 'h','i', 'j','k', 'l','m', 'n','ñ', 'o','p', 'q','r', 's','t', 'u','v', 'w','x', 'y','z', 'A','B', 'C','D', 'E','F', 'G','H', 'I','J', 'K','L', 'M','N', 'Ñ','O', 'P','Q', 'R','S', 'T','U', 'V','W', 'X','Y', 'Z','0', '1','2', '3','4', '5','6', '7','8', '9','!','"','#','$','%','&','\'','(',')','*','+',',','-','.','/',':',';','<','=','>','?','@','[','\\',']','^','_','`','{','|','}','~'};

            for (int i = 0; i < pLongitud; i++)
            {
                if (pLevel.Equals("SIMPLE"))
                {
                    password.Append(lista[aleatorio.Next(54, 63)]);
                }
                if (pLevel.Equals("ADVANCED"))
                {
                    password.Append(lista[aleatorio.Next(0, 63)]);
                }
                if (pLevel.Equals("MAX"))
                {
                    password.Append(lista[aleatorio.Next(0, lista.Length - 1)]);
                }
            }
          
            return password.ToString();
        }
    }
}