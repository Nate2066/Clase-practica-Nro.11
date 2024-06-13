using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionVehiculos
{
    internal class AutoMovil : Vehiculo
    {
        public AutoMovil(string pNombre, string pMarca, string pTipoDeVehiculo, string pColor) : base(pNombre, pMarca, pTipoDeVehiculo, pColor)
        {

        }
        public override void HacerSonido()
        {

        }
    }
}
