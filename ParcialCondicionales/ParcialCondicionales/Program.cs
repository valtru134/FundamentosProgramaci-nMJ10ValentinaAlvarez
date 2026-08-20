using System;
using System.CodeDom;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desarrolle un programa en C# que permita a un usuario seleccionar una sala y un juego de acuerdo con su edad, y determine el precio que debe pagar.
            // a. El programa debe solicitar al usuario: Edad, expresada como un número entero positivo.

            int edad = 0;
            string sala = null;
            string sala1 = " sala 1";
            string sala2 = " sala 2";
            string sala3 = "sala3";
            string sala4 = "sala 4";
            string sala5 = " sala 5";
            string juegos = null;
            bool juego10 = true; 
            bool juego1 = true;
            bool juego2 = true;
            bool juego3 = true;
            bool juego4 = true;
            bool juego5 = true;
            bool juego6 = true;
            bool juego7 = true;
            bool juego8 = true;
            bool juego9 = true;

            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt16(Console.ReadLine());

            //b. Determinación de las salas habilitadas De acuerdo con la edad ingresada, se determinarán las salas a las que el usuario puede acceder

            if (edad >= 1 && edad <= 5)
            {
                Console.WriteLine("ingrese a la " + sala1);
                Console.WriteLine("tienes disponible el juego1 y juego5");
                juegos = Console.ReadLine();

                if (juego1)
                {
                    Console.WriteLine("elegiste el juego1");
                }
                else if (juego5)
                {
                    Console.WriteLine("elegiste el juego5");
                }
                else
                {
                    Console.WriteLine("elija un juego valido");
                }


            }
            else if (edad >= 6 && edad <= 16)
            {
                Console.WriteLine("ingrese a la " + sala2);

                if (juego3)
                {
                    Console.WriteLine("elegiste el juego1");
                }
                else if (juego6)
                {
                    Console.WriteLine("elegiste el juego5");
                }
                else
                {
                    Console.WriteLine("elija un juego valido");
                }
            }
            else if (edad >= 17 && edad <= 25)
            {
                Console.WriteLine("elija entre la sala3 o la sala4");
                sala =  Console.ReadLine();

                if (sala3 != sala4)
                {
                    Console.WriteLine("ingrese a la sala 3");
                }
                else 
                {
                    Console.WriteLine("ingrese a la sala 4");
                }

            }
            else if(edad >= 26)
            {
                Console.WriteLine("ingrese a la " + sala5);
            }
            else 
            {
                Console.WriteLine("error");
                
            }
        }
    }
}
