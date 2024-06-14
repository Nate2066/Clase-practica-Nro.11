using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    public class Camion : Vehiculos
    {
        public Camion(string pNombre, string pMarca, string pColor, string pTipoDeVehiculo, int pNumeroID) : base(pNombre, pMarca, pColor, pTipoDeVehiculo, pNumeroID)
        {

        }

        public override void HacerSonido()
        {
            base.HacerSonido();
        }
        public override void MostrarInfo(int pNumeroAsignado)
        {
            base.MostrarInfo(pNumeroAsignado);
        }
        public override void Pitar()
        {
            base.Pitar();
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
