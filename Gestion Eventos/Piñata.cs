using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Eventos
{
    internal class Piñata : Evento
    {
        public Piñata(string tipo, string nombre, int id) : base(tipo, nombre, id)
        {
        }

        public override void CalcularCosto(int costo)
        {
            Console.WriteLine("Gratis :D");
            Console.ReadKey();
        }
        public override void MostrarInfo(int opcion)
        {
            base.MostrarInfo(opcion);
        }
        public override void MostrarLista()
        {
            base.MostrarLista();
        }
        public override void AgregarInfo(string tipo, string nombre)
        {
            base.AgregarInfo(tipo, nombre);
        }
        public override void BorrarInfo(int opcion)
        {
            base.BorrarInfo(opcion);
        }
    }
}
