using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcailProgIII
{
    internal class Aleatorio
    {
        Random rand = new Random();

        public Persona persona;
        double descuento = 0;

        int[] num = new int[5];

        public int[] numPer = new int[5];

        DateTime fechaA = DateTime.Now;



        public Aleatorio(Persona persona)
        {
            this.persona = persona;
        }

        public void ran() { 
  
            do
            {
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = rand.Next(0, 51);
                    
                }
            } while (num[0] == num[1] || num[0] == num[2] || num[0] == num[3] || num[0] == num[4] || num[1] == num[2] || num[1] == num[3] || num[1] == num[4] || num[2] == num[3] || num[2] == num[4] || num[3] == num[4]);

                for(int i=0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

        }


        public void numeroPersona()
        {
            for(int i = 0; i <numPer.Length; i++)
            {
                do
                {
                    Console.WriteLine("\nPor favor ingrese el número de la posicion " + (i + 1) + ":");
                    numPer[i] = Convert.ToInt32(Console.ReadLine());

                    if(numPer[i] < 0 || numPer[i] > 50)
                    {
                        Console.WriteLine($"ERROR: el numero de la posiciom {i+1} debe estar entre 0 y 50 (ambos incluidos) vuelva a intentarlo");
                    }

                } while (numPer[i] < 0 || numPer[i]>50);
                
            }
        }


        public void aciertos()
        {
            int j = 0;

            for(int i = 0; i < num.Length; i++) { 
            if (num[i] == numPer[i])
                {
                    j++;
                }
            }

            
            
            
            switch(j)
            {
                case 0:
                    Console.WriteLine("Que lastima no acertaste mas suerte la proxima.");
                    break;
                case 1:
                    Console.WriteLine("Felicidades acertasete 1 y tendras un descuento del 10%");
                    descuento = persona.compra * 0.1;
                   
                    break;
                case 2:
                    Console.WriteLine("Felicidades acertasete 2 y tendras un descuento del 20%");
                    descuento = persona.compra * 0.2;
                   
                    break;
                case 3:
                    Console.WriteLine("Felicidades acertasete 3 y tendras un descuento del 30%");
                    descuento = persona.compra * 0.3;
                   
                    break;
                case 4:
                    Console.WriteLine("Felicidades acertasete 4 y tendras un descuento del 40%");
                    descuento = persona.compra * 0.4;
                   
                    break;
                case 5:
                    Console.WriteLine("Felicidades acertasete 5 y tendras un descuento del 50%");
                    descuento = persona.compra * 0.5;
                    break;
               
            }

        }

        


        public void Imprimor()
        {
            Console.WriteLine("\n--TICKET--");
            Console.WriteLine($"El cliente {persona.nombre}, con DNI: {persona.DNI} posee un descuento de ${descuento} en su proxima compra");
            Console.WriteLine("Oferta valida hasta: " + fechaA.AddDays(30));
        }


    }
}
