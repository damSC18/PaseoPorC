using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseoPorC
{
    class principal
    {
        static void Main()
        {

            new Program();
            // Operador condicional
            string resultado;
            int entrada=-2;
            resultado = (entrada >= 0) ? "Positivo" : "Negativo";

            Console.WriteLine($"Resultado : {entrada}-> {resultado}");

            //   Estructuras est = new Estructuras();
            //   Program enumeraciones = new Program();
            // Campos de la clase
            Console.WriteLine($"Numero PI:  {CamposDelaClase.numeroPi}");
            CamposDelaClase cdC = new CamposDelaClase();

            Console.WriteLine($"Numero  :  {cdC.numero}");
           Console.WriteLine($"Cadena  :  {cdC.LeerCadena()}");


            // Propiedades
            PropiedadesDeClase pc = new PropiedadesDeClase { producto = "Zapatillas", precio = 19.95m }; ;
            Console.WriteLine($"Datos de la propiedad  -> Producto :  {pc.producto}  -  Pecio : {pc.precio}");


            PropiedadesDeClase pc1 = new PropiedadesDeClase("Peluquero", "Señoras");
            Console.WriteLine($"Datos de poroesión  :  {pc1.Datos}  ");



            PropiedadesDeClase pc2 = new PropiedadesDeClase("Mantenimiento", "Ascensores");
            Console.WriteLine($"Datos de poroesión  :  {pc2.Profesion} de  {pc2.Especialidad} ");



            PropiedadesDeClase pc3 = new PropiedadesDeClase();
            pc3.trabajoContraseña = "12345_4568";
            Console.WriteLine($"Contraseña   :  {pc3.trabajoContraseña} ");

            pc3.trabajoContraseña = "12$4568";
            Console.WriteLine($"Contraseña   :  {pc3.trabajoContraseña} ");

            // Tratamiento de excepciones
            ClaseC cc = new ClaseC();



            // Coleccion 
            var colecionString = new Coleccion<object>();
            colecionString[0] = "Hola, Mundo";
            colecionString[1] = "Hola, Tierra";
            colecionString[2] = "Hola, Luna";
            colecionString[3] = "Hola, Marte";
            colecionString[4] = 123;
            colecionString[5] = true;
            int n = colecionString.nregitros();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(colecionString[i]);
            }

        
            Console.ReadKey();
        }
    }
}
