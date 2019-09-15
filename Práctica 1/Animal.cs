using System;

namespace Práctica_1
{
    abstract class Animal
    {
        #region Atributos
        private byte patas, edad;
        private string nombre, color;
        private bool vertebrado;
        #endregion

        #region Encapsulamiento
        public byte Patas { get => patas; set => patas = value; }
        public byte Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Color { get => color; set => color = value; }
        public bool Vertebrado { get => vertebrado; set => vertebrado = value; }
        #endregion

        #region Constructores
        public Animal() { }
        public Animal(string nombre)
        {
            Nombre = nombre;
        }
        public Animal(byte edad)
        {
            Edad = edad;
        }
        #endregion

        #region Métodos
        public void Comer()
        {
            Console.WriteLine(Nombre+" está comiendo");
        }

        public void Dormir()
        {
            Console.WriteLine(Nombre+" está comiendo");
        }

        public void TomarAgua()
        {
            Console.WriteLine(Nombre+" está tomando agua");
        }

        //Método para que el usuario defina los datos del animal
        public virtual void Datos()
        {
            Console.WriteLine("Ingresa el nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa la edad del perico");
            Edad = byte.Parse(Console.ReadLine());
        }

        //Método que muestra todos los datos del animal
        public virtual void Mostrar()
        {
            Console.WriteLine("Las características de tu animal son: " +
                "\npatas: "+Patas+"\nedad: "+Edad+"\nnombre: "+Nombre+"\ncolor: "+Color);
            if (vertebrado == true)
            {
                Console.WriteLine("vertebrado: sí");
            }
            else
            {
                Console.WriteLine("vertebrado: no");
            }
        }

        #endregion
    }
}
