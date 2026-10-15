using System;
using System.Threading;


namespace TellerModular
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    string palabra = IngresarPalabra();
        //    char[] vectorCaracteres = ConvertirAVector(palabra);
        //    ContarVocalesYConsonantes(vectorCaracteres);
        //}       
        //static string IngresarPalabra()
        //{
        //    Console.Write("Ingrese una palabra: ");
        //    return Console.ReadLine().ToLower(); // Pasamos a minúsculas para facilitar la comparación
        //}

        //static char[] ConvertirAVector(string palabra)
        //{
        //    return palabra.ToCharArray();
        //}

        //static void ContarVocalesYConsonantes(char[] vector)
        //{
        //    int vocales = 0;
        //    int consonantes = 0;

        //    foreach (char c in vector)
        //    {
        //        if (char.IsLetter(c))
        //        {
        //            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        //            {
        //                vocales++;
        //            }
        //            else
        //            {
        //                consonantes++;
        //            }
        //        }
        //    }

        //    Console.WriteLine($"Cantidad de vocales: {vocales}");
        //    Console.WriteLine($"Cantidad de consonantes: {consonantes}");
        //}
        //static string[] tareas = new string[10];
        //static int cantidad = 0;

        //static void Main(string[] args)
        //{

        //    int opcion = 0;


        //    while (opcion != 4)
        //    {
        //        Console.WriteLine("\n--- MENU DE TAREAS ---");
        //        Console.WriteLine("1. Agregar tarea");
        //        Console.WriteLine("2. Mostrar lista");
        //        Console.WriteLine("3. Eliminar ultima tarea");
        //        Console.WriteLine("4. Salir");
        //        Console.Write("Elija una opcion: ");
        //        opcion = int.Parse(Console.ReadLine());

        //        if (opcion == 1)
        //        {
        //            AgregarTarea();
        //        }
        //        else if (opcion == 2)
        //        {
        //            MostrarTareas();
        //        }
        //        else if (opcion == 3)
        //        {
        //            EliminarTarea();
        //        }
        //    }


        //}

        //static void AgregarTarea()
        //{
        //    if (cantidad < tareas.Length)
        //    {
        //        Console.Write("Escriba la descripcion de la tarea: ");
        //        tareas[cantidad] = Console.ReadLine();
        //        cantidad++;
        //        Console.WriteLine("¡Tarea agregada con exito!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("¡La lista esta llena!");
        //    }
        //}

        //// Módulo para mostrar tareas
        //static void MostrarTareas()
        //{
        //    Console.WriteLine("\n--- LISTA DE TAREAS ---");
        //    if (cantidad == 0)
        //    {
        //        Console.WriteLine("No hay tareas guardadas.");
        //    }
        //    else
        //    {
        //        for (int i = 0; i < cantidad; i++)
        //        {
        //            Console.WriteLine((i + 1) + ". " + tareas[i]);
        //        }
        //    }
        //}

        //// Módulo para eliminar la última tarea
        //static void EliminarTarea()
        //{
        //    if (cantidad > 0)
        //    {
        //        cantidad--;
        //        Console.WriteLine("¡Ultima tarea eliminada!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No hay tareas para eliminar.");
        //    }
        //}

        static void Main(string[] args)
        {
            int opcion = MostrarMenu();

            if (opcion >= 1 && opcion <= 3)
            {
                double valor = PedirValor();
                RealizarConversion(opcion, valor);
            }
            else
            {
                Console.WriteLine("Opcion invalida.");
            }
        }

        static int MostrarMenu()
        {
            Console.WriteLine("Elija la conversion:");
            Console.WriteLine("1. Kilogramos a Gramos");
            Console.WriteLine("2. Metros a Kilometros");
            Console.WriteLine("3. Horas a Segundos");
            Console.Write("Opcion: ");
            return int.Parse(Console.ReadLine());
        }

        static double PedirValor()
        {
            Console.Write("Ingrese el valor a convertir: ");
            return double.Parse(Console.ReadLine());
        }

        static void RealizarConversion(int opcion, double valor)
        {
            double resultado = 0;

            if (opcion == 1)
            {
                resultado = valor * 1000;
                Console.WriteLine(valor + " kilogramos son " + resultado + " gramos.");
            }
            else if (opcion == 2)
            {
                resultado = valor / 1000;
                Console.WriteLine(valor + " metros son " + resultado + " kilometros.");
            }
            else if (opcion == 3)
            {
                resultado = valor * 3600;
                Console.WriteLine(valor + " horas son " + resultado + " segundos.");
            }
        }
    }
}