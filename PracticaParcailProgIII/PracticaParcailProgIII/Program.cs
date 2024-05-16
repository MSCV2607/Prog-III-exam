using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcailProgIII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona comprador1 = new Persona("Mauro", 123456, 20000);
            Aleatorio aleatorio = new Aleatorio(comprador1);

            

            Console.WriteLine($"Bienvenido {comprador1.nombre}. Por motivo de nuestro aniversario te vamos a pedir que elijas 5 numeros. Del 0 al 50");

            
            aleatorio.numeroPersona();
            aleatorio.ran();

            aleatorio.aciertos();
            aleatorio.Imprimor();

        }
    }
}
