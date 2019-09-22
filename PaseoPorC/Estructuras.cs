using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseoPorC
{
    class Estructuras
    {
        public  Estructuras() { 
        var coords1 = new Coordenadas();
        var coords2 = new Coordenadas(10, 10);

        // Display results.
        Console.Write("Coordenadas 1: ");
            Console.WriteLine($"Latitud = {coords1.latitud}, Longitud = {coords1.longitud}");

            Console.Write("Coordenadas 2: ");
            Console.WriteLine($"Latitud = {coords2.latitud}, Longitud = {coords2.longitud}");

            // Keep the console window open in debug mode.
            Console.WriteLine("Pulsa una tecla para finalizar.");
            Console.ReadKey();

            }
       
    }
}
public struct Coordenadas
{
    public int latitud,longitud;

    public Coordenadas(int lat, int lon)
    {
        latitud = lat;
        longitud=lon;
    }
}