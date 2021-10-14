using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introGUI
{
    class Pelicula
    {
        private string nombre;
        private int anio;
        private bool recomendada;

        public Pelicula(string nombre, int anio, bool recomendada)
        {
            this.nombre = nombre;
            this.anio = anio;
            this.recomendada = recomendada;
        }

        public Pelicula(string nombre, int anio)
        {
            this.nombre = nombre;
            this.anio = anio;
            this.recomendada = false;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Anio { get => anio; set => anio = value; }
        public bool Recomendada { get => recomendada; set => recomendada = value; }

        public override string ToString()
        {
            string recomiendo = "";

            if(recomendada)
            {
                recomiendo = "- Película Recomendada";
            }

            return nombre + " - " + anio + recomiendo;
        }
    }
}
