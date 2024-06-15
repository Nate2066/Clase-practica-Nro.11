using System;


namespace GestionHospital
{
    internal class Pediatra : Empleado
    {
        public Pediatra(string tipo, string nombre, byte exp, int id) : base(tipo, nombre, exp, id)
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
