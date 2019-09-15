using System;

namespace Práctica_1
{
    abstract class Animal
    {
        //Class Animal es la clase Padre

        #region Atributos
        private byte patas, edad;
        private string nombre, color, alimento;
        private bool vertebrado;
        #endregion

        #region Encapsulamiento
        public byte Patas { get => patas; set => patas = value; }

        //Protege el valor que la edad puede tomar, al declararse que esta no puede ser mayor a 100 años
        public byte Edad { get => edad; set
            {
                if (value < 100)
                {
                    edad = value;
                }else
                {
                    Console.WriteLine("Ingresaste una edad invalida");
                }
            }
                
                }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Color { get => color; set => color = value; }
        public bool Vertebrado { get => vertebrado; set => vertebrado = value; }
        public string Alimento { get => alimento; set => alimento = value; }
        #endregion

        #region Constructores
        public Animal() {}
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

        //Método para que el usuario defina los datos del animal
        public virtual void Datos()
        {
            Console.WriteLine("\nIngresa el nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("\nIngresa la edad: ");
            Edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("\nIngresa el color: ");
            Color = Console.ReadLine();
            Console.WriteLine("\nIngrese el alimento: ");
            Alimento = Console.ReadLine();
        }

        //Método que muestra todos los datos del animal
        public virtual void Mostrar()
        {
            Console.WriteLine("Las características de tu animal son: " +
                "\npatas: " + Patas + "\nedad: " + Edad + "\nnombre: " + Nombre + "\ncolor: " + Color);
            if (vertebrado == true)
            {
                Console.WriteLine("vertebrado: sí");
            }
            else
            {
                Console.WriteLine("vertebrado: no");
            }
        }

        //Permite saber si el animal está comiendo
        public void Comer()
        {
            //Variable del método comer
            char alimentacion;
            Console.WriteLine("\n{0} tiene {1} en su bandeja? (S/N)\n", Nombre, Alimento);
            alimentacion = char.Parse(Console.ReadLine());
            if (alimentacion == 'S')
            {
                Console.WriteLine(Nombre+" está comiendo");
            }
            else
            {
                Console.WriteLine(Nombre+" no está comiendo");
            }
        }

        public void Dormir()
        {
            Console.WriteLine(Nombre+" está comiendo");
        }

        public void TomarAgua()
        {
            Console.WriteLine(Nombre+" está tomando agua");
        }
        #endregion
    }
}
