
using System;

namespace Gestion_Hospital
{
    public class Gestor //Manejo de operaciones
    {
        // Base 
        string[] empleados = new string[10];

        //Metodos

        public void VerEmpleados()
        {
            Console.WriteLine("---------Empleados----------\n");

            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine(empleados[i]);
            }
        }

        public void ExaminarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("---------Examinar empleados----------\n");
            Console.WriteLine("Ingrese el nombre del empleado a buscar");
            string nombre = Console.ReadLine();
            for (int i = 0; i < empleados.Length; i++)
            {
                if (nombre == empleados[i])
                {
                    Empleado Empleado = new Empleado(nombre);
                    Empleado.Examinar();

                    break;
                }
            }
            Console.ReadKey();
        }

        public void AgregarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("---------Agregar empleados----------\n");

            Console.WriteLine("Ingrese el nombre del trabajador");
            string Nombre = Console.ReadLine();

            Empleado empleado = new Empleado(Nombre);

            Console.WriteLine("Ingrese edad del trabajador");
            byte Edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese edad del trabajador");
            byte Experiencia = Convert.ToByte(Console.ReadLine());

            empleado.Completar(Experiencia, Edad);

            Console.WriteLine("Empleado añadido");
            Console.ReadKey();
        }

        public void EliminarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("---------Eliminar empleados----------\n");
            Console.WriteLine("Ingrese el nombre del empleado a buscar");

            string nombre = Console.ReadLine();

            foreach (string item in empleados)
            {
                if (nombre == item)
                {
                    Empleado Empleado = new Empleado(nombre);
                    Empleado.Examinar();
                    break;
                }
            }

            Console.WriteLine("Empleado eliminado");
            Console.ReadKey();
        }
    }
}