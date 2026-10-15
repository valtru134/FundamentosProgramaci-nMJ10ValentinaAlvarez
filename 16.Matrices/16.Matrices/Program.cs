using System;


namespace _16.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese el número de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            
            Console.WriteLine("--- LLena la matriz ---");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

           
            Console.WriteLine("--- Matriz original ---");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(); 
            }

            
            Console.Write("Ingrese el valor umbral (N): ");
            int n = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] < n)
                    {
                        matriz[i, j] = n; 
                    }
                }
            }

            
            Console.WriteLine("--- Matriz Resultante---");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine(); 
            }
        }
    }
}
