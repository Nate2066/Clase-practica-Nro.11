using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    public class Vehiculo
    {
        private string[] Nombre = new string[5];
        private string[] Marca = new string[5];
        private string[] Color = new string[5];
        private string TipoDeVehiculo;

        public Vehiculo(string pNombre, string pMarca, string pColor, int pNumeroID)
        {
            Nombre[pNumeroID] = pNombre;
            Marca[pNumeroID] = pMarca;
            Color[pNumeroID] = pColor;
        }

        public virtual void Pitar()
        {

        }
        public virtual void HacerSonido()
        {

        }
        public virtual void MostrarInfo(int pNumeroAsignado)
        {
            Console.Clear();
            Console.WriteLine("==========Informacion del vehiculo==========" + "\n");
            Console.WriteLine("* Nombre: " + Nombre[pNumeroAsignado]);
            Console.WriteLine("* Marca:  " + Marca[pNumeroAsignado]);
            Console.WriteLine("* Color:  " + Color[pNumeroAsignado]);
            Console.WriteLine("\n" + "============================================");
            Console.ReadKey();
        }
    }
}
