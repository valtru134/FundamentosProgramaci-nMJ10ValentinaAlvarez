using System;

namespace _19.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu ();
            
            RealizarOperaciones(CapturarOpción());

          
        }
        static float division()
        {
            Console.WriteLine("Ingrese el primer número: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 / numero2;
        }
        static float resta()
        {
            
            Console.WriteLine("Ingrese el primer número: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 - numero2;

         
        }
        static float suma()
        {
            float suma = 0;
            float numero= 0; 
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un número: ");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea seguir sumando: s: para continuar ");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');

            return suma;
        }

        static float multiplica()
        {
            float multiplicacion = 1;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un número: ");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Desea seguir multiplicando: s: para continuar ");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');

            return multiplicacion; 

        }
            static void RealizarOperaciones(int opcion)
            {
               while(opcion != 0)
               {
                  switch (opcion)
                  {
                    case 1:
                        Console.WriteLine($"la suma de los numeros ingresados es: {suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La resta de los números ingresados es {resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La multiplicación de los números ingresados es {multiplica()}");
                        break;
                    case 4:
                        Console.WriteLine($"La división de los números ingresados es {division()}");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                  }
               }
               Console.ReadKey();
               Console.Clear();
               MostrarMenu();
               opcion = CapturarOpción();
              
            }
             static int CapturarOpción()
             {
               return int.Parse (Console.ReadLine());
             }
             static void MostrarMenu()
             {
                 Console.WriteLine("--------------menú-------------");
                 Console.WriteLine("1. suma             2.Resta");
                Console.WriteLine("3. Multiplicación   4. División ");
                 Console.WriteLine("0. Salir");
                   Console.WriteLine("-------------------------------");
                   Console.WriteLine("Ingrese una opción: ");
             }
    }
}
