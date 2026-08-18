using System;


namespace _7.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taller condicionales punto 1
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Escriba el número 1");
            num1 = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Escriba el número 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba el número 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                if (num1 > num2 && num2 > num3 && num3 < num1)
                {
                    Console.WriteLine(num1 + " " + num2 + " " + num3 + " ");

                }
                if (num1 > num2 && num2 < num3 && num3 < num1)
                {
                    Console.WriteLine(num1 + " " + num3 + " " + num2 + " ");
                }
                if (num1 < num2 && num2 < num3 && num3 > num1)
                {
                    Console.WriteLine(num3 + " " + num2 + " " + num1 + " ");
                }
                if (num1 > num2 && num2 < num3 && num3 > num1)
                {
                    Console.WriteLine(num3 + " " + num1 + " " + num2 + " ");
                }
                if (num1 < num2 && num2 > num3 && num3 > num1)
                {
                    Console.WriteLine(num2 + " " + num3 + " " + num1 + " ");
                }
                if (num1 < num2 && num2 > num3 && num3 < num1)
                {
                    Console.WriteLine(num2 + " " + num1 + " " + num3 + " ");
                }
            }   

            else 
            {
                Console.WriteLine("Se deben ingresar números diferentes");
            
            }

            // punto 2

            int munición = 0;
            string invencible = "estado invencible ";

            

            Random rnd = new Random();
            munición = rnd.Next(1, 16);
            Console.WriteLine(munición);
        }
    }
}
