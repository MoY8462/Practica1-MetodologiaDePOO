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
                if (value < 300)
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
        public Animal() {
            Edad = 5;
            Color = "negro";
        }
        public Animal(string nombre, byte edad, byte patas, string color, string alimento, bool vertebrado)
        {
            Nombre = nombre;
            Edad = edad;
            Patas = patas;
            Color = color;
            Alimento = alimento;
            Vertebrado = vertebrado;
        }
        public Animal(string nombre)
        {
            Nombre = nombre;
        }
        public Animal(byte edad, bool vertebrado)
        {
            Edad = edad;
            Vertebrado = vertebrado;
        }
        #endregion

        #region Métodos

        //Método para que el usuario defina los datos del animal
        public virtual void Datos()
        {
            Console.Write("\nIngresa el nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("\nIngresa la edad: ");
            Edad = byte.Parse(Console.ReadLine());
            Console.Write("\nIngresa el color: ");
            Color = Console.ReadLine();
            Console.Write("\nIngrese el alimento: ");
            Alimento = Console.ReadLine();
        }

        //Método que muestra todos los datos del animal
        public virtual void Mostrar()
        {
            Console.WriteLine("\t\t\tLas características de tu animal son: " +
                "\n\t\t Patas: " + Patas + "\n\t\t Edad: " + Edad + "\n\t\t Nombre: " + Nombre +
                "\n\t\t Color: " + Color);
            if (vertebrado == true)
            {
                Console.WriteLine("\n\t\t Vertebrado: sí");
            }
            else
            {
                Console.WriteLine("\n\t\t Vertebrado: no");
            }
        }

        //Permite saber si el animal está comiendo
        public void Comer()
        {
            //Variable del método comer
            char alimentacion;
            int i = 1;

            while (i == 1)
            {
                Console.WriteLine("\n\n\t\t ¿{0} tiene {1} en su bandeja? (S/N)\n", Nombre, Alimento);
                alimentacion = char.Parse(Console.ReadLine());
                Char.ToUpper(alimentacion);
                if (alimentacion == 'S')
                {
                    Console.WriteLine(Nombre + " está comiendo");
                    i = 2;
                }
                else if(alimentacion == 'N')
                {
                    Console.WriteLine(Nombre + " no está comiendo");
                    i = 2;
                }
                else
                {
                    Console.WriteLine("Inténtalo de nuevo");
                }
            }
        }

        public void Dormir()
        {
            Console.WriteLine("\t\t"+Nombre+" está comiendo");
        }

        public void TomarAgua()
        {
            Console.WriteLine("\t\t"+Nombre+" está tomando agua");
        }
        #endregion
    }
}
