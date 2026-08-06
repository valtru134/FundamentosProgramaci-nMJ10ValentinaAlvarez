using System;


namespace _4.CondicionalesSimplesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUCTURAS DE CONTROL CONDICIONAL
            //Condicional simple
            //1.    Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18,se debe mostrar el siguente mensaje: "Bienvenido a mi sitio web"
            /* byte edad = 0;
             Console.WriteLine("Ingrese su edad");
             edad = Convert.ToByte(Console.ReadLine());

             if (edad >= 18)
             {
                 //Si la condición es verdadera 
                 Console.WriteLine("bienvenido a mi sitio web");
             }*/

            
            
            
            
            
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos monstrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos, de lo contratio escribir un mensaje usted no es apto para este sitio web

            /*byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                //Si la condición es verdadera 
                Console.WriteLine("bienvenido a mi sitio web");
            }
            else
            {
                //si la condicion no se cumple
                Console.WriteLine("no es apto para el contenido de este sitio");
            }*/

           
            
           
            
            
            
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos monstrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos


          /*  float sueldo = 0;
            string nombre = " ";

            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine("usted " + nombre + ", debe abonar impuestos debido a la cantidad de su sueldo");
            }
            else
            {
                Console.WriteLine("persona exenta de impuestos");
            }*/

           
            
            
            
            
            //crear un algoritmo que permita ingresar dos numeros,si e primer numero es mayor al segundo numero informar su suma y diferencia, en caso contrario informar el producto y la división del primer numero respecto al segundo numero

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("ingrese el número 1");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el número 2");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero1 > numero2)
            {
                Console.WriteLine(numero1 - numero2);
                Console.WriteLine(numero1 + numero2);
            }

            else
            {
                Console.WriteLine(numero1 * numero2);
                Console.WriteLine(numero1 / numero2);
            }



        }
    }
}
