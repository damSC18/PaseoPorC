using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseoPorC
{


    class PropiedadesDeClase
    {
        private string profesion;
        private string especialidad;

        private string clave;

        public string producto
        { get; set; }

        public decimal precio
        { get; set; }

        public PropiedadesDeClase() { }
        // Constructror que utiliza una lambda
        public PropiedadesDeClase(string _profesion) => profesion = _profesion;

        public PropiedadesDeClase(string _profesion, string _especialidad)
        {
            profesion = _profesion;
            especialidad = _especialidad;
        }
        public string Profesion
        {
            get => profesion;
            set => profesion = value;
        }

        public string Especialidad
        {
            get => especialidad;
            set => especialidad = value;
        }

        // Propiead de solo lectura que devuelve los campos de la clase: No necesitamos ni get ni return
        public string Datos => $"{profesion} de {especialidad}";


        public String trabajoContraseña
        {
            get
            {
                if (clave.Length < 8 && clave.IndexOf("_") < 1)
                { return "Contraseña Erronea"; }
                else { return "Contraseña Correcta"; }

            }
            set
            {
                clave = value;
            }
        }



    }
}
