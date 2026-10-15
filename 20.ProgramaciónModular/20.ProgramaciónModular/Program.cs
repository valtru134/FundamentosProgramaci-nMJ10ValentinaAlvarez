using System;


namespace _20.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz de n filas por m columnas, que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz.
            int n = Capfilas();
            int m = CapColumnas();

            int[,] matriz = new int[n, m];

            BorrarPantalla();
            LlenarMatriz(matriz, n, m);
            MostrarMatriz(matriz, n, m);
        }

        static int Capfilas()
        {
            Console.Write("Ingrese el número de filas (n): ");
            return int.Parse(Console.ReadLine());
        }

        static int CapColumnas()
        {
            Console.Write("Ingrese el número de columnas (m): ");
            return int.Parse(Console.ReadLine());
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void LlenarMatriz(int[,] matriz, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int numero;
                    
                    do
                    {
                        Console.Write($"Ingrese un múltiplo de 5 para la posición [{i},{j}]: ");
                        numero = int.Parse(Console.ReadLine());

                        if (EsMultiplo(numero) == false);
                        {
                            Console.WriteLine("Dato inválido. Debe ser múltiplo de 5.");
                        }
                    } while (EsMultiplo(numero) == false);

                    matriz[i, j] = numero;
                }
            }

            
            BorrarPantalla();
        }
        static bool EsMultiplo(int numero)
        {
            return numero % 5 == 0;
        }

        static void MostrarMatriz(int[,] matriz, int n, int m)
        {
            Console.WriteLine("--- Matriz Final de Múltiplos de 5 ---");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }



}

