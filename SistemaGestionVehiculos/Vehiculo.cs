using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionVehiculos
{
    public class Vehiculo
    {
        private string Nombre;
        private string Marca;
        private string TipoDeVehiculo;
        private string Color;

        public Vehiculo(string Nombre, string Marca, string TipoDeVehiculo, string Color)
        {
            this.Nombre = Nombre;
            this.Marca = Marca;
            this.TipoDeVehiculo = TipoDeVehiculo;
            this.Color = Color;
        }

        public virtual void HacerSonido()
        {
            Console.Clear();
            Console.WriteLine("El vehiculo " + Nombre + " esta haciendo un sonido");
            Console.ReadKey();
        }
        public void MostrarInformacion()
        {
            Console.Clear();
            Console.WriteLine("Nombre: " + Nombre + "\nMarca: " + Marca + "\nTipoDeVehiculo: " + TipoDeVehiculo);
            Console.ReadKey();
        }
        public void Pitar()
        {
            Console.Clear();
            Console.WriteLine("Pip Pip!");
            Console.ReadKey();
        }
    }
}
