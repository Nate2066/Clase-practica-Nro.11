using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    internal class Motocicleta : Vehiculos
    {
        public Motocicleta(string pNombre, string pMarca, string pColor, string pTipoDeVehiculo, int pNumeroID) : base(pNombre, pMarca, pColor, pTipoDeVehiculo, pNumeroID)
        {

        }

        public override void HacerSonido()
        {
            Console.Clear();
            Console.WriteLine("El vehiculo esta haciendo un sonido");
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "SonidoMoto.wav";
            player.Load();
            player.Play();
            Console.ReadKey();
        }
        public override void MostrarInfo(int pNumeroAsignado)
        {
            base.MostrarInfo(pNumeroAsignado);
        }
        public override void MostrarLista()
        {
            base.MostrarLista();
        }
        public override void AgregarInfo(string pNombre, string pMarca, string pColor)
        {
            base.AgregarInfo(pNombre, pMarca, pColor);
        }
        public override void BorrarInfo(int NumeroIdentificador)
        {
            base.BorrarInfo(NumeroIdentificador);
        }
    }
}
