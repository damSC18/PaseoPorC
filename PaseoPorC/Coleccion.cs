using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseoPorC

{ 

class Coleccion<M>
{
    // Declara un  array  .
    private M[] arr = new M[100];

    // Propiedad que guarda los datos en el array
    public M this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }

        public int nregitros() {
            return arr.Length;
        }
        
}
}