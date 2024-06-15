using System;
using System.Media;

namespace Gestion_Hospital
{
    public class Pediatra : Empleados
    {
        public Pediatra(string nombre, string marca, string color, string tipo, int id) : base(nombre, marca, color, tipo, id)
        {
        }

        public override void HacerSonido()
        {
            Console.Clear();
            Console.WriteLine("El vehiculo esta haciendo un sonido");
            SoundPlayer player      = new SoundPlayer();
            player.SoundLocation    = "SonidoCamion.wav";
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