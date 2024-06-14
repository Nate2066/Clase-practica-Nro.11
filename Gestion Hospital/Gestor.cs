
using System;

namespace Gestion_Hospital
{
    public class Gestor //Manejo de operaciones
    {
        public void VerEmpleados()
        {
            Console.WriteLine("Empleados:\n");
        }

        public void ExaminarEmpleado()
        {

        }

        public void AgregarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("---------Agregar empleados----------\n");

            Console.WriteLine("Ingrese el nombre del trabajador");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad del trabajador");
            byte Edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese edad del trabajador");
            byte Experiencia = Convert.ToByte(Console.ReadLine());

            Empleado empleado = new Empleado(Nombre,Edad,Experiencia);
            Console.ReadKey();
        }

        public void EliminarEmpleado()
        {

        }
    }
}
