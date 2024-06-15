using GestionReserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel
{
    public class Suite : Habitacion
    {
        private bool VistaMar = false;
        private bool AccesoPiscina = false;
        private double PrecioTotal = 1000;

        public Suite (string pTipoHabitacion, double pPrecio, bool pVistaMar, bool pAccesoPiscina) : base (pTipoHabitacion, pPrecio)
        {
            pPrecio = PrecioTotal;
            VistaMar = pVistaMar;
            AccesoPiscina = pAccesoPiscina;
        }
        public override void CalcularPrecioTotal()
        {
            if(VistaMar == true) { PrecioTotal += 100;  }
            if(AccesoPiscina == true) { PrecioTotal += 150; }
        }
        public override void MostrarRecibo()
        {
            base.MostrarRecibo();
            if (VistaMar == true) { Console.WriteLine("\n"+"Incluye vista al mar"); }
            if(AccesoPiscina == true) { Console.WriteLine("Incluye acceso a la piscina"); }
            Console.ReadKey();
        }
        public override void HacerReservacion()
        {
            Console.Clear();
            Console.WriteLine("Desea que su habitacion tenga vista al mar por $100 mas?");
            Console.WriteLine("1. Si" + "\n2. No");
            byte opc = Convert.ToByte(Console.ReadLine());
            if (opc == 1)
            {
                VistaMar = true;
            }
            else if (opc == 2) { }
            else
            {
                Console.Clear();
                Console.WriteLine("Error! opcion invalida");
                Console.ReadKey();
            }
            Console.WriteLine("Desea tener acceso a la piscina por $150 mas?");
            Console.WriteLine("1. Si" + "\n2. No");
            byte opc2 = Convert.ToByte(Console.ReadLine());
            if (opc2 == 1)
            {
                AccesoPiscina = true;
            }
            else if (opc2 == 2) { }
            else
            {
                Console.Clear();
                Console.WriteLine("Error! opcion invalida");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
