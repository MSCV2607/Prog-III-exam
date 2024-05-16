using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcialProgIII3._0
{
    internal class Persona
    {
        public string nombre {  get; set; }
        public DateTime fechaNac {  get; set; }

        public Persona(string nombre, DateTime fechaNac)
        {
            this.nombre = nombre;
            this.fechaNac = fechaNac;
        }
    }
}
