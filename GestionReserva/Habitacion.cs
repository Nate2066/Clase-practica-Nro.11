using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReserva
{
    public class Habitacion
    {
        private int NumeroHabitacion = 5;
        private string TipoHabitacion;
        private double Precio;

        public Habitacion(string TipoHabitacion, double Precio)
        {
            this.TipoHabitacion = TipoHabitacion;
            this.Precio = Precio;
        }

        public virtual void HacerReservacion() { }
        public virtual void CalcularPrecioTotal() { }
        public virtual void MostrarRecibo(double pPrecio)
        {
            Console.Clear();
            Console.WriteLine("-----------Recibo habitacion-----------");
            Console.WriteLine(TipoHabitacion + "\n");
            Console.WriteLine("Numero de Habitacion: " + NumeroHabitacion);
            Console.WriteLine("Precio: " + pPrecio);
            Console.WriteLine("\n" + "---------------------------------------");
        }
    }
}
