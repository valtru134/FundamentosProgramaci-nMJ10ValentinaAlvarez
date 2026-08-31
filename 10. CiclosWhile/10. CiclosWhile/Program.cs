using System;


namespace _10.CiclosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escribe un algoritmo en el que el computador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. Utilizar la función Random para elegir el número aleatorio.
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int intentos = 0;
            int contador = 0;

            Console.WriteLine("Adivine el número entre 1 y 100");

            while (intentos != numeroSecreto )
            {
                Console.WriteLine("Escribe el número que crees:");
                intentos = int.Parse(Console.ReadLine());
                contador = contador + 1;

                if (intentos < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo, intenta de nuevo");
                }
                else if(intentos > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto, intentelo de nuevo");

                }
                else
                {
                    Console.WriteLine("Felicidades, ha adivinado el número");
                }
            }
        }
    }
}
