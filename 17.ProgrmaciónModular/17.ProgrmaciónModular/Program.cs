using System;


namespace _17.ProgrmaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bienvenido al curso de fundamentos de programación");
            MostrarMensaje("Valentina");
            MostrarMensaje("Valentina", "Alvarez");
            Console.ReadKey();
            borrarPantalla();
        }

        // procedimiento sin parametro
        static void borrarPantalla()
        {
            Console.Clear();
        }

        //Procedimiento con parametros
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"bienvenido, {nombre}  al curso de fundamentos de programación");
        }

        static void MostrarMensaje(string nombre, string apellido)
        {
            Console.WriteLine($"bienvenido, {nombre} {apellido} al curso de fundamentos de programación");
        }
    }
}
