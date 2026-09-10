using System;

namespace Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoproducto = 0;
            int cantidadUnidades = 0;
            int acumulador = 0;
            int lotesvalidos = 0;

            Console.WriteLine("ingrese el codigo del producto (ingrese -1 para salir): ");
            codigoproducto = int.Parse(Console.ReadLine());

            while (codigoproducto != -1)
            {

                Console.WriteLine("La cantidad de unidades: ");
                cantidadUnidades = int.Parse(Console.ReadLine());
                if (cantidadUnidades <= 0)
                {
                    
                    Console.WriteLine("Cantidad invalida no se sumera al inventario");
                }
                else 
                {
                    acumulador = cantidadUnidades + acumulador;
                    lotesvalidos++;

                }
                Console.WriteLine("ingrese el codigo del producto (ingrese -1 para salir): ");
                codigoproducto = int.Parse(Console.ReadLine());


            }
            
            Console.WriteLine("-----estadisticas------");
            Console.WriteLine("su total acumulado es:" + acumulador);
            Console.WriteLine("lotes validos: " + lotesvalidos);
            Console.ReadKey();


        }
    }
}
