using System;

namespace GestionHospital
{
    public class Doctor : Empleado
    {
        public Doctor(string tipo, string nombre, byte exp, int pNumeroID) : base(tipo, nombre, exp, pNumeroID)
        {

        }

        public override void CalcularSalario(byte exp)
        {
            base.CalcularSalario(exp);
        }
        public override void MostrarInfo(int opcion)
        {
            base.MostrarInfo(opcion);
        }
        public override void MostrarLista()
        {
            base.MostrarLista();
        }
        public override void AgregarInfo(string tipo, string nombre, byte exp)
        {
            base.AgregarInfo(tipo, nombre, exp);
        }
        public override void BorrarInfo(int opcion)
        {
            base.BorrarInfo(opcion);
        }
    }
}
