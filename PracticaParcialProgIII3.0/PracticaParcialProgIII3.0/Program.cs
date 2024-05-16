using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticaParcialProgIII3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, soy Baltazar, el gran vidente de tu ciudad\nSi deseas conocer tu horoscopo semanal te pedire unos datos.[Presiona Enter]");
            int rta = 0;
            Console.ReadKey();

            string[] bienEstar = new string[5];
            string[] dinero = new string[5];
            string[] amor = new string[5];

            SignoZodiaco aries = new SignoZodiaco(new DateTime(DateTime.Now.Year, 1, 1), new DateTime(DateTime.Now.Year, 1, 31), "Aries", "Piscis");
            bienEstar[0] = aries.darBienestar();
            dinero[0] = aries.darDinero();
            amor[0] = aries.darAmor();
            SignoZodiaco tauro = new SignoZodiaco(new DateTime(DateTime.Now.Year, 2, 1), new DateTime(DateTime.Now.Year, 2, 28), "Tauro", "Aquarius");
            bienEstar[1] = tauro.darBienestar();
            dinero[1] = tauro.darDinero();
            amor[1] = tauro.darAmor();
            SignoZodiaco geminis = new SignoZodiaco(new DateTime(DateTime.Now.Year, 3, 1), new DateTime(DateTime.Now.Year, 3, 31), "Gemins", "Capricornio");
            bienEstar[2] = geminis.darBienestar();
            dinero[2] = geminis.darDinero();
            amor[2] = geminis.darAmor();
            SignoZodiaco cancer = new SignoZodiaco(new DateTime(DateTime.Now.Year, 4, 1), new DateTime(DateTime.Now.Year, 4, 30), "Cancer", "Sagitario");
            bienEstar[3] = cancer.darBienestar();
            dinero[3] = cancer.darDinero();
            amor[3] = cancer.darAmor();
            SignoZodiaco leo = new SignoZodiaco(new DateTime(DateTime.Now.Year, 5, 1), new DateTime(DateTime.Now.Year, 5, 31), "Leo", "Scorpio");
            bienEstar[4] = leo.darBienestar();
            dinero[4] = leo.darDinero();
            amor[4] = leo.darAmor();


            SignoZodiaco[] arraySigno = new SignoZodiaco[5];
            arraySigno[0] = aries;
            arraySigno[1] = tauro;
            arraySigno[2] = geminis;
            arraySigno[3] = cancer;
            arraySigno[4] = leo;

            do
            {
                Console.WriteLine("\nDanos tu nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("¿En que año naciste?");
                int Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("¿Que mes naciste?");
                int M = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("¿Que dia naciste?");
                int D = Convert.ToInt32(Console.ReadLine());

                Persona persona = new Persona(nombre, new DateTime(Y, M, D));


                int j = 0;

                for (int i = 0; i < arraySigno.Length; i++)
                {
                    if (persona.fechaNac.Month == arraySigno[i].inicio.Month)
                    {
                        j = i;
                    }

                }


                Console.WriteLine($"\nOh estoy viendo lo que se aproxima en este {DateTime.Now.Day} para ti joven {persona.nombre} con el signo {arraySigno[j].nombre}");
                Console.WriteLine($"\n********Bien Estar******** \n{bienEstar[j]}");
                Console.WriteLine($"\n********Dinero******** \n{dinero[j]}");
                Console.WriteLine($"\n********Amor******** \n{amor[j]}");

                Console.WriteLine($"\nRecuerda mantener a las personas del signo {arraySigno[j].signoAsociado} cerca tuyo");


                Console.WriteLine("\nDesea salir o probar con otra persona? \n1)Probar con otra persona\n2)Salir");
                rta = Convert.ToInt32(Console.ReadLine());
            } while (rta == 1);

            Console.WriteLine("Muchas gracias por usar el programa.");
        }
    }
}
