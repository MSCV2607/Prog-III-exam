using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticaParcialProgIII3._0
{
    internal class SignoZodiaco
    {
        public DateTime inicio {  get; set; }
        public DateTime fin {  get; set; }

        public string nombre;
        public string signoAsociado {  get; set; }

        public SignoZodiaco(DateTime inicio, DateTime fin, string nombre, string signoAsociado)
        {
            this.inicio = inicio;
            this.fin = fin;
            this.nombre = nombre;
            this.signoAsociado = signoAsociado;
        }

        Random rand = new Random();

        string nota1;
        public string darBienestar()
        {
            Thread.Sleep(500); //--> para darle pausa al programa
            int ran1 = rand.Next(1,4);
            
            if(ran1 == 1)
            {
                nota1 = "+ Te sentiras realizado este mes";
            }
            if(ran1 == 2)
            {
                nota1 = "- Cuidado es un mes muy malo para salir";
            }
            if(ran1 == 3)
            {
                nota1 = "? Bueno, no es un mal mes pero anda con cuidado";
            }
            return nota1;
        }

        string rtaDin;
        public string darDinero()
        {
            Thread.Sleep(500); //--> para darle pausa al programa
            int ran2 = rand.Next(1, 4);
           
            if (ran2 == 1)
            {
                rtaDin = "+ Ganaras mas dinero por tu esfuerzo";
            }
            if (ran2 == 2)
            {
                rtaDin = "- Tu dinero tendra menos valor que ayer";
            }
            if (ran2 == 3)
            {
                rtaDin = "? Si te esfuerzas ganaras dinero pero no prometo nada";
            }
            return rtaDin;
        }

        string rtaAmor;
        public string darAmor()
        {
            Thread.Sleep(500); //--> para darle pausa al programa
            int ran3 = rand.Next(1, 4);
            if (ran3 == 1)
            {
                rtaAmor = "+ Conoceras al amor de tu vida";
            }
            if (ran3 == 2)
            {
                rtaAmor = "- No es un buen mes para conocer a alguien";
            }
            if (ran3 == 3)
            {
                rtaAmor = "? Quizas conozcas a alguien pero sera de paso";
            }
            return rtaAmor;
        }
    }
}
