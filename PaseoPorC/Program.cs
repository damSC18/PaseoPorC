using System;


namespace PaseoPorC
{
    class Program
    {
        enum valores : int {maximo = 234, minimo =34 };
       
       public Program() { 
          Console.WriteLine("Aprendiendo C# -- Enumeraciones");
            int x = (int)valores.maximo;

            int y = (int)valores.minimo;

            Console.WriteLine("Máximo :{0}",x);
            Console.WriteLine("Minimo :{0}",y);

            // Recorrer la enum con foreach
            Console.WriteLine("Aprendiendo C# -- Enumeraciones con foreach");
            foreach (int numero in (valores[]) Enum.GetValues(typeof(valores))) {
                Console.WriteLine("Lista :{0}", numero);
            }          
            var s = Console.ReadKey();
        }
    }
}

