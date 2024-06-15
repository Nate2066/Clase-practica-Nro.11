using System;
using System.Media;

namespace Gestion_Hospital
{
    public class Empleados
    {
        private string[] Nombre = new string[5];
        private string[] Edad  = new string[5];
        private string[] Experiencia  = new string[5];
        private string   Tipo;

        public Empleados(string nombre, string marca, string color, string tipo, int id)
        {
            Nombre[id]          = nombre;
            Edad[id]            = marca;
            Experiencia[id]     = color;
            Tipo                = tipo;
        }
        public virtual void CalcularSalario()
        {
            SoundPlayer player = new SoundPlayer();
        }
        public virtual void MostrarInfo(int pNumeroAsignado)
        {
            Console.Clear();
            Console.WriteLine("==========Informacion del empleado==========\n"  );
            Console.WriteLine("* Nombre: " + Nombre[pNumeroAsignado]            );
            Console.WriteLine("* Marca:  " + Edad[pNumeroAsignado]              );
            Console.WriteLine("* Color:  " + Experiencia[pNumeroAsignado]       );
            Console.WriteLine("* Tipo:   " + Tipo                               );
            Console.WriteLine("\n============================================"  );
            Console.ReadKey();
        }
        public virtual void MostrarLista()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{(i + 1)}. {Nombre[i]} ({Edad[i]})");
            }
            Console.WriteLine("");
        }
        public virtual void AgregarInfo(string nombre, string edad, string experiencia, string tipo)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Nombre[i] == default && Edad[i] == default && Experiencia[i] == default)
                {
                    Nombre[i]   = $"{tipo} {nombre}";
                    Edad[i]    = edad;
                    Experiencia[i]    = experiencia;
                    break;
                }
                else if (Nombre[4] != default && Edad[4] != default && Experiencia[4] != default)
                {
                    Console.Clear();
                    Console.WriteLine("Ya no tiene espacios para agregar otro empleado de este tipo");
                    Console.ReadKey();
                    break;
                }
            }
        }
        public virtual void BorrarInfo(int NumeroIdentificador)
        {
            Console.Clear();
            Nombre[NumeroIdentificador]         = default;
            Edad[NumeroIdentificador]           = default;
            Experiencia[NumeroIdentificador]    = default;
            Tipo                                = default;

            Console.WriteLine("Datos del empleado borrados con exito");
            Console.ReadKey();
        }
    }
}