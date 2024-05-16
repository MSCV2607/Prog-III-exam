using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DateTime fechaI;
            DateTime fechaF;

            fechaI = (new DateTime(2024, 5, 16));
            fechaF = (new DateTime(2024, 5, 23));

            // Calcula cuántos días hay entre las dos fechas
            TimeSpan totalDias =(fechaF - fechaI);

            // Asegúrate de que hay al menos un día de diferencia
            if (totalDias.Days > 0)
            {
                DateTime[] arrayDt = new DateTime[totalDias.Days];

                int j = 0;

                while (fechaI < fechaF)
                {
                    if (fechaI.DayOfWeek == DayOfWeek.Sunday|| fechaI.DayOfWeek == DayOfWeek.Saturday)
                    {
                        fechaI = fechaI.AddDays(1);
                        continue;
                    }

                    arrayDt[j] = fechaI;
                    fechaI = fechaI.AddDays(1);
                    j++;
                }

                // Imprime las fechas almacenadas en el array
                for (int i = 0; i < arrayDt.Length; i++)
                {
                    Console.WriteLine(arrayDt[i]);
                }
            }
            else
            {
                Console.WriteLine("Las fechas son iguales o la segunda fecha es anterior a la primera.");
            }

            EsPrimo(3);

            Console.WriteLine(EsPrimo(4));

        }
        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            if (numero == 2)
            {
                return true;
            }

            if (numero % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
            /*
             // Imprime la diferencia en el formato especificado
        Console.WriteLine($"La diferencia entre las fechas es de {diferencia.ToString("dd.MM.yy")}.");
             */
        }
        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
