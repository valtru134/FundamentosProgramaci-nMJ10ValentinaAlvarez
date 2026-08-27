using System;


namespace _8.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int acumulador = 0;
            // int numero = 0;

            // Console.WriteLine("Ingrese el número a sumar");
            // numero = int.Parse(Console.ReadLine());

            // while (numero>=0)
            {
                //acumulador += numero;
                // Console.WriteLine("Ingrese el numero a sumar");
                // numero = int.Parse(Console.ReadLine());
            }
            // Console.WriteLine($"La suma de los numeros ingresados es: {acumulador}");

            int acumulador = 0;
            int numero = 0;
            int contador = 0;
            int cantidad = 0;
0;
            Console.WriteLine("ingrese la cantidad de números que va introducir");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los número");

            while (cantidad != 0)
            {
                
                Console.WriteLine("Ingrese el número");
                numero = int.Parse(Console.ReadLine());
                cantidad = --cantidad;
            }
            if(numero>0)
            {
                Console.WriteLine($"Los numeros mayores que 0 son {numero > 0}");
            }
            if (numero < 0)
            {
                Console.WriteLine($"Los numeros mayores que 0 son {numero < 0}");
            }
            if (numero == 0)
            {
                Console.WriteLine($"Los numeros mayores que 0 son {numero == 0}");
            }
        }
    }
}
