using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Eventos
{
    public class Evento
    {
        private string[] Tipo = new string[5];
        private string[] Tarea = new string[5];
        private double Salario = default;

        public Evento(string tipo, string nombre, int id)
        {
            Tipo[id] = tipo;
            Tarea[id] = nombre;
        }
        public virtual void CalcularCosto(int costo)
        {
            Console.WriteLine($"El costo es de {costo} dolares");
            Console.ReadKey();
        }
        public virtual void MostrarInfo(int opcion)
        {
            Console.Clear();
            Console.WriteLine("==========Informacion del Evento==========\n");
            Console.WriteLine($"* Tipo:                {Tipo[opcion]}");
            Console.WriteLine($"* Nombre:               {Tarea[opcion]}");
            Console.WriteLine("\n" + "============================================");
            Console.ReadKey();
        }
        public virtual void MostrarLista()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. {Tipo[i]} {Tarea[i]}");
            }
            Console.WriteLine("");
        }
        public virtual void AgregarInfo(string tipo, string nombre)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Tipo[i] == default && Tarea[i] == default)
                {
                    Tipo[i] = tipo;
                    Tarea[i] = nombre;
                    break;
                }
                else if (Tipo[4] != default && Tarea[4] != default)
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
            Tarea[opcion] = default;

            Console.WriteLine("Datos del evento borrados con exito");
            Console.ReadKey();
        }
    }
}
