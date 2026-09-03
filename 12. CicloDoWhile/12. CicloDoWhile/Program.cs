using System;


namespace _12.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que le pida a un grupo de usuarios su nombre,número de cuenta, el saldo y "Es apto para el crédrito"
            //Si el saldo es mayor o igual a 3.000.000 sacar un mensaje que diga el nombre sel usuario, el número de cuenta, el saldo y "Es apto para el credito"
            //Si el daldo es menor a 3.000.000 sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "No es apto para el crédito"
            //El algoritmo debe permitir prenguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más
            // Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de saldos


            //string nombre;
            //double numeroCuenta = 0;
            //double saldo = 0;
            //int totalUsuarios = 0;
            //double sumaSaldos = 0;
            //double promedioSaldos = 0;
            //do
            //{
            //    Console.WriteLine("Ingrese su nombre: ");
            //    nombre = Console.ReadLine();

            //    Console.WriteLine("Ingrese su número de cuenta: ");
            //    numeroCuenta = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Ingrese su saldo: ");
            //    saldo = double.Parse(Console.ReadLine());

            //    if (saldo >= 3000000)
            //    {
            //        Console.WriteLine($"El usuario {nombre} con número de cuenta {numeroCuenta} tiene un saldo de {saldo} y es apto para el crédito.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"El usuario {nombre} con número de cuenta {numeroCuenta} tiene un saldo de {saldo} y no es apto para el crédito.");
            //    }

            //    totalUsuarios++;
            //    sumaSaldos += saldo;
            //    Console.WriteLine("¿Desea ingresar otro usuario? (si/no)");
            //} while (Console.ReadLine() == "si");

            //if (totalUsuarios > 0)
            //{
            //    promedioSaldos = sumaSaldos / totalUsuarios;
            //}

            //Console.WriteLine("------ RESULTADOS FINALES -------");
            //Console.WriteLine($"Número total de usuarios ingresados: {totalUsuarios}");
            //Console.WriteLine($"Promedio de saldos: {promedioSaldos:N0}");



            // crear un algoritmo que: permita al usuario ingresar una contraseña, Se repita hasta que la contraseña sea correcta (por ejemplo:1234) y mostrar cuantos intentos se realizaron para ingresar la contraseña correcta

            int contraseña = 0;
            int acumulador = 0;
            do
            {
                Console.WriteLine("Ingrese la contraseña: ");
                contraseña = int.Parse(Console.ReadLine());
                acumulador++;
            } while (contraseña != 1234);


            Console.WriteLine("Felicidades ingresaste la contraseña correcta");
            Console.WriteLine($"Número de intentos para ingresar la contraseña correcta: {acumulador}");
        }
    }
}
