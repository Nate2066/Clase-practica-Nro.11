using System;
using System.Media;

namespace GestionHospital
{
    public class Empleado
    {

        private string[] Tipo = new string[5];
        private string[] Nombre = new string[5];
        private byte[] Exp = new byte[5];

        public Empleado(string tipo, string nombre, byte exp, int id)
        {
            Tipo[id] = tipo;
            Nombre[id] = nombre;
            Exp[id] = exp;
        }
        public virtual void CalcularSalario(byte opcion)
        {

            byte exp = Exp[opcion];
            Console.WriteLine($"Su salario actual es de {10000 + (1000 * (exp / 100))}");
            Console.ReadKey();
        }
        public virtual void MostrarInfo(int opcion)
        {
            Console.Clear();
            Console.WriteLine("==========Informacion del Empleado==========\n");
            Console.WriteLine($"* Cargo:                {Tipo[opcion]}");
            Console.WriteLine($"* Nombre:               {Nombre[opcion]}");
            Console.WriteLine($"* Años de experiencia:  {Exp[opcion]}");
            Console.WriteLine("\n" + "============================================");
            Console.ReadKey();
        }
        public virtual void MostrarLista()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. {Tipo[i]} {Nombre[i]} ({Exp[i]})");
            }
            Console.WriteLine("");
        }
        public virtual void AgregarInfo(string tipo, string nombre, byte exp)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Tipo[i] == default && Nombre[i] == default && Exp[i] == default)
                {
                    Tipo[i] = tipo;
                    Nombre[i] = nombre;
                    Exp[i] = exp;
                    break;
                }
                else if (Tipo[4] != default && Nombre[4] != default && Exp[4] != default)
                {
                    Console.Clear();
                    Console.WriteLine("Capacidad maxima ya alcanzada");
                    Console.ReadKey();
                    break;
                }
            }
        }
        public virtual void BorrarInfo(int opcion)
        {
            Console.Clear();
            Tipo[opcion] = default;
            Nombre[opcion] = default;
            Exp[opcion] = default;

            Console.WriteLine("Datos de vehiculo borrados con exito");
            Console.ReadKey();
        }
    }
}