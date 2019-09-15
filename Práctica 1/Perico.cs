using System;

namespace Práctica_1
{
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
            Patas = 2;
            Vertebrado = true;
        }
        public Perico(byte edad) : base(edad)
        {
            Edad = edad;
            Vertebrado = true;
        }
        #endregion

        #region Métodos
        public void Volar()
        {
            Console.WriteLine(Nombre+" está volando");
        }

        public override void Datos()
        {
            base.Datos();
            Console.WriteLine("Ingresa el color");
            Color = Console.ReadLine();
            Console.WriteLine("Ingresa la especie del perico");
            Especie = Console.ReadLine();
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("especie: "+Especie);
        }
        #endregion
    }
}
