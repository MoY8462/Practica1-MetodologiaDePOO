using System;

namespace Práctica_1
{

    //Class Perico es una clase hija de Class Animal

    class Perico : Animal
    {
        #region Atributos
        private string especie;
        #endregion

        #region Encapsulamiento
        public string Especie { get => especie; set => especie = value; }
        #endregion

        #region Constructores
        public Perico()
        {
            Patas = 2;
            Vertebrado = true;
        }
        public Perico(string nombre, byte edad, string color) 
        {
            Nombre = nombre;
            Edad = edad;
            Color = color;
            Patas = 2;
            Vertebrado = true;
        }
        public Perico(byte edad) 
        {
            Edad = edad;
        }
        #endregion

        #region Métodos
        public override void Datos()
        {
            Console.WriteLine("\n\t\t Este animal es un perico\n"); 
            base.Datos();
            Console.WriteLine("\t\t Ingresa la especie del perico: ");
            Especie = Console.ReadLine();
        }

        public override void Mostrar()
        { 
            base.Mostrar();
            Console.WriteLine("\n\t\t Especie: "+Especie);
        }

        //Metodo que permite saber si el Perico puede volar
        public void Volar()
        {
            char jaula;int i = 1;

            while (i == 1)
            {
                Console.WriteLine("\n\t\t" + Nombre + " está dentro de su jaula? (S/N)");
                jaula = char.Parse(Console.ReadLine());
                Char.ToUpper(jaula);
                if (jaula == 'S')
                {
                    Console.WriteLine("\n\t\t" + Nombre + " está volando");
                    i = 2;
                }
                else if (jaula== 'N')
                {
                    Console.WriteLine("\n\t\t" + Nombre + " no está volando");
                    i = 2;
                }
                else
                {
                    Console.WriteLine("\n\t\tInténtalo de nuevo");
                }
            }
        }


        #endregion
    }
}
