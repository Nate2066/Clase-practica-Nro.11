using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReserva
{
    public class HabitacionSencilla : Habitacion
    {
        private bool CamaDoble = false;
        private bool Desayuno = false;
        private double PrecioTotal = 500;
        public HabitacionSencilla(string pTipoHabitacion, double pPrecio, bool pCamaDoble, bool pDesayuno) : base (pTipoHabitacion, pPrecio)
        {
            CamaDoble = pCamaDoble;
            Desayuno = pDesayuno;
            //PDT: Los precios son precios hipoteticos
            pPrecio = PrecioTotal;
            pTipoHabitacion = "Habitacion sencilla";
        }

        public override void CalcularPrecioTotal()
        {
            if (CamaDoble == true) { PrecioTotal += 100; }
            if (Desayuno == true) { PrecioTotal += 100; }
            Console.WriteLine(PrecioTotal);
        }
        public override void MostrarRecibo(double Precio)
        {
            base.MostrarRecibo(PrecioTotal);
            if (CamaDoble == true) { Console.WriteLine("\n" + "Incluye Cama doble en la habitacion"); }
            if (Desayuno == true) { Console.WriteLine("Incluye Desayuno por la manana"); }
            Console.ReadKey();
        }
        public override void HacerReservacion()
        {
            Console.Clear();
            Console.WriteLine("Desea incluir cama doble por $100 mas?");
            Console.WriteLine("1. Si" + "\n2. No");
            byte opc = Convert.ToByte(Console.ReadLine());
            if(opc == 1)
            {
                CamaDoble = true;
            }
            else if(opc == 2) { }
            else
            {
                Console.Clear();
                Console.WriteLine("Error! opcion invalida");
                Console.ReadKey();
            }
            Console.WriteLine("Desea incluir desayuno por las mananas por $100 mas?");
            Console.WriteLine("1. Si" + "\n2. No");
            byte opc2 = Convert.ToByte(Console.ReadLine());
            if (opc2 == 1)
            {
                Desayuno = true;
            }
            else if (opc2 == 2) { }
            else
            {
                Console.Clear();
                Console.WriteLine("Error! opcion invalida");
                Console.ReadKey();
            }
        }
    }
}
