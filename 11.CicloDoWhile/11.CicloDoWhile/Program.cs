using System;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int contador = 1;
            //int acumulador = 0;
            //do
            {
                //acumulador += contador;
                //contador++;
            } //while (contador <= 5);



            //Console.WriteLine($"La suma de los cinco primeros números enteros es: " + acumulador);

           //Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar

            //int numero = 0;
            //int contador = 1;
            //string respuesta = "";
            
            
            

            //do
            {

              //  Console.WriteLine("Infgrese el número que deseea multiplicar");
                //numero = int.Parse(Console.ReadLine());

                //do
                {
                  //  Console.WriteLine(numero + "x" + contador + " : " + (numero * contador));
                    //contador++;
                } //while (contador <= 10);

                //Console.WriteLine("¿deseas hacer otra tabla? (si o no)");
                //respuesta = Console.ReadLine();


            } //while (contador == "si");


            //Crear uyn algorimo que permita clarcular y mostrar por pantalla los números primos hasta el número 100
            int contador = 1;
            int contador2 = 1;
            int contadorDivisiones = 0;
            do
            {
                do
                {
                    if(contador%contador2==0)
                    {
                        contadorDivisiones++;
                    }

                    contador2++;
                } while (contador2 <= contador);

                contador2 = 1;

                if(contadorDivisiones==2)
                {
                    Console.WriteLine(contador);
                }
                contadorDivisiones = 0;
                //Console.WriteLine(contador);
                contador++;
            } while (contador <= 100);



        }
    }
}
