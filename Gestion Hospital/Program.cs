using System;

namespace Gestion_Hospital
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable base
            bool Salir = false;
            Gestor gestor = new Gestor();

            //Bienvenida
            Console.WriteLine("---------Bienvenido al sistema de gestion de empleados----------");
            Console.WriteLine("Enter para continuar");
            Console.ReadKey();
            do
            {
                try
                {
                    //Menú :P
                    Console.Clear();
                    Console.WriteLine("==========GESTION DE EMPLEAOS==========");
                    Console.WriteLine("*Que desea realizar\n");
                    Console.WriteLine("1.   Ver lista de empleados");
                    Console.WriteLine("2.   Agregar nuevo empleado");
                    Console.WriteLine("3.   Eliminar empleados");
                    Console.WriteLine("4.   Examimar empleados");
                    Console.WriteLine("                             5.  *Salir*");
                    Console.WriteLine("========================================");

                    switch (Convert.ToByte(Console.ReadLine()))
                    {
                        case 1:
                            gestor.VerEmpleados();
                            break;
                        case 2:
                            gestor.AgregarEmpleado();
                            break;
                        case 3:
                            gestor.EliminarEmpleado();
                            break;
                        case 4:
                            gestor.ExaminarEmpleado();
                            break;
                        case 5:
                            Salir = true;
                            break;
                        default:
                            Console.WriteLine("Error! opcion invalida");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Error! opcion invalida");
                    Console.ReadKey();
                }
            } while (!Salir);
        }
    }
}