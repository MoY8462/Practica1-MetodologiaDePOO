using System;

namespace Práctica_1
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Animales\n");
            Perico miPerico = new Perico();
            miPerico.Datos();
            miPerico.Mostrar();
            miPerico.Comer();
            miPerico.Volar();
            miPerico.Dormir();
            miPerico.TomarAgua();
        }
    }
}
