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
        public Perico(string nombre) : base(nombre)
        {
            Nombre = nombre;
        }
        public Perico(byte edad) : base(edad)
        {
            Edad = edad;
        }
        #endregion

        #region Métodos

        //Llama al método datos de class animal y registra el valor del atributo especie
        public override void Datos()
        {
            Console.WriteLine("\nEste animal es un perico\n"); 
            base.Datos();
            Console.WriteLine("\nIngresa la especie del perico: ");
            Especie = Console.ReadLine();
        }

        public override void Mostrar()
        { 
            base.Mostrar();
            Console.WriteLine("especie: "+Especie);
        }

        //Metodo que permite saber si el Perico puede volar
        public void Volar()
        {
            char jaula;
            Console.WriteLine(Nombre+" está dentro de su jaula? (S/N)");
            jaula = char.Parse(Console.ReadLine());
            if (jaula == 'S')
            {
                Console.WriteLine(Nombre + " está volando");
            }
            else
            {
                Console.WriteLine(Nombre + " está volando");
            }
        }


        #endregion
    }
}
