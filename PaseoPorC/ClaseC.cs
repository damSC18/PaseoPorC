using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseoPorC
{
    class ClaseC
    {

        ~ClaseC()
        {
            System.Diagnostics.Trace.WriteLine($"The  destructor is executing.");
        }
        int n;
        string c;
        public string nombre
        {
            get { return nombre; }
            set
            {
                try
                {
                    if (value.ToString().Trim() == "")
                    {
                        throw new CapturadorExcepciones("Cadena Vacia");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Datos {ex.Message}" );
                    Console.ReadKey();
                }
                finally  
                {
                    Console.WriteLine($"SIn errores");
                    Console.ReadKey();
                }
            }

        }
        public ClaseC()
        {
          
                nombre = "";

        try
            {
                int nn= 0;
                n = 4 / nn;


                throw new CapturadorExcepciones();
            }
            catch (Exception ex) {
                Console.WriteLine($"Datos {ex.Message} -- {ex.StackTrace}");
                Console.ReadKey();
            }
        }
       
    
}
}