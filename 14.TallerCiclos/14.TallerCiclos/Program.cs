using System;
using System.ComponentModel.Design;


namespace _14.TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritmo que prermits calcular el promedio de calificaciones, el algoritmo le permmite al usuarioingresar cyabtas calificaciones desee, en el momento en que selccione que no desea continuar capturandoi calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente 


            //double sumacalificaciones = 0f;
            //double calificación = 0f;
            //double contador = 0f;

            //string respuesta;



            //while (true)
            //{
            //    Console.WriteLine("Ingrese una calificación");
            //    calificación = double.Parse(Console.ReadLine());
            //    sumacalificaciones += calificación;
            //    contador++;
            //    Console.WriteLine("desea ingresar otra calificación? (s/n):");
            //    respuesta = Console.ReadLine();
            //    if (respuesta.ToLower() != "s")
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine("su promedio es: " + (sumacalificaciones / contador));


            //2 punto
            int numero = 0;
            int divisor = 1;
            int contador = 0;

            Console.WriteLine("ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            while(true)
            {
                if(numero % divisor==0 )
                {
                    contador++;
                }
                else
                {
                    break;
                }

                
            } 

            
           
        }
    }
}
