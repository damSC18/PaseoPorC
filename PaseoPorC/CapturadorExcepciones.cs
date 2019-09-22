using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Necesario cargar  
using System.Runtime.Serialization;

namespace PaseoPorC
{
 
    class CapturadorExcepciones : Exception
    {
        public CapturadorExcepciones()
        {
        }

        public CapturadorExcepciones(string message) : base(message)
        {
             
           // Console.WriteLine("Error cadena Vacia");

        }

       

    }
}
 