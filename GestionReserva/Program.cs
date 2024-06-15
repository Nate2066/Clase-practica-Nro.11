//By Nate :D

using GestionHotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReserva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Salir = false;
            Suite suite = new Suite(default, default, default, default);
            HabitacionSencilla habitacionSencilla = new HabitacionSencilla(default, default, default, default);
            Console.WriteLine("Bienvenido, click para continuar");
            Console.ReadKey();
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Que tipo de habitacion desea reservar?");
                    Console.WriteLine("1. Suite");
                    Console.WriteLine("2. HabitacionSencila");
                    byte opc = Convert.ToByte(Console.ReadLine());

                    if(opc == 1)
                    {
                        suite.HacerReservacion();
                        suite.CalcularPrecioTotal();
                        suite.MostrarRecibo();
                    }
                    if(opc == 2)
                    {
                        habitacionSencilla.HacerReservacion();
                        habitacionSencilla.CalcularPrecioTotal();
                        habitacionSencilla.MostrarRecibo();
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Error! opcion invalida");
                    Console.ReadKey();
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("Error! opcion invalida");
                    Console.ReadKey();
                }
            } while (!Salir);
        }
    }
}
