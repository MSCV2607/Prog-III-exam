using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    internal class Fecha
    {
        public DateTime fechaI {  get; set; }
        public DateTime fechaF {  get; set; }

        public Fecha(DateTime fechaI, DateTime fechaF)
        {
            this.fechaI = fechaI;
            this.fechaF = fechaF;
        }

        

    }
}
