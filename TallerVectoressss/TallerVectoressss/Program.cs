using System;
using System.Runtime.InteropServices;


namespace TallerVectoressss
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] numeros = new int[15];

            //int max = int.MinValue;
            //int min = int.MaxValue;

            //Console.WriteLine("ingrese un numero entero");
            //Console.ReadLine();

            //for (int i =0; i< numeros.Length; i++)
            //{
            //    Console.Write($"Número {i + 1}: ");
            //    numeros[i] = int.Parse( Console.ReadLine() );
            //    if (numeros[i] > max)
            //    {
            //        max = numeros[i];
            //    }
            //    if  (numeros[i] < min)
            //    {
            //        min = numeros[i];
            //    }

            //}
            //Console.WriteLine($"el valor maximo es {max}");
            //Console.WriteLine($"el valor minimo es {min}");
            //Console.ReadKey();


            //int[] nums1 = new int[5];
            //int[] nums2 = new int[5];
            //int[] numsiguales = new int[5];

            //Console.WriteLine(" ingrese los numeros del vector 1");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"ingrese el numero para el p{i + 1} del vector 1");
            //    nums1[i] = int.Parse(Console.ReadLine());

            //}


            //Console.WriteLine("ahora ingrese los del vector 2");


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"ingrese el numero para el p{i + 1} del vector 2");
            //    nums2[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    if (nums1[i] == nums2[i])
            //    {
            //        numsiguales[i]++;
            //    }
            //    Console.WriteLine($" hay {numsiguales[i]} numeros iguales");
            //}
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    Console.WriteLine($"Posición cantidad de numeros iguales p{i + 1}: {nums1[i]} | {nums2[i]} ");

            //}

            //Console.ReadKey()

            int[] vector = new int[20];
            Random vis = new Random();
            Console.WriteLine("ingrese 20 números enteros del negayivos o negativos");

            
            vector[0] = vis.Next(-100, 100);

            int promedio = 0; 





            
        }
            
        
    }
}


