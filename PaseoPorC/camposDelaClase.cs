using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseoPorC
{
    class CamposDelaClase
    {
        public int numero = 123;
        private string cadena = "Cadena Protegida";
        public static Double numeroPi = 3.1416;



        public string LeerCadena()
        {
            return this.cadena;
        }
    }
}
