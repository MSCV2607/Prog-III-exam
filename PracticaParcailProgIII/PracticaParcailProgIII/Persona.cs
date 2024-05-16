using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcailProgIII
{
    internal class Persona
    {
        public string nombre { get; set; }
        public int DNI { get; set; }
        public double compra {  get; set; }

        public Persona(string nombre, int dNI, int compra)
        {
            this.nombre = nombre;
            DNI = dNI;
            this.compra = compra;
        }

        public Persona()
        {
        }
    }
}
