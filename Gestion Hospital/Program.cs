
using System;

namespace GestionHospital
{
    internal class Program
    {
        static void Main()
        {
            //Variables principales
            //El "default" asigna los valores por defecto a una variable, en caso de un string seria un espacio y en caso de un int seria un "0", se hace uso de esta para asignar mas facilmente un valor por defecto
            string Tipo = default;
            string Nombre = default;
            byte Exp = default;
            int ID = default;

            bool Salir = false;
            bool Volver = false;
            bool Cancelar = false;

            Doctor Doctor = new Doctor(Tipo, Nombre, Exp, ID);
            Enfermero Enfermero = new Enfermero(Tipo, Nombre, Exp, ID);
            Pediatra Pediatra = new Pediatra(Tipo, Nombre, Exp, ID);

            //Bienvenida
            Console.WriteLine("---------Bienvenido al sistema de gestion de hospital----------");
            Console.WriteLine("Precione cualquier tecla para continuar");
            Console.ReadKey();
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("==========GESTION DE EMPLEADOS==========");
                    Console.WriteLine("*Que desea realizar?                  \n");
                    Console.WriteLine("1.   Ver lista de Empleados");
                    Console.WriteLine("2.   Agregar nuevo Empleado\n");
                    Console.WriteLine("                             0.  *Salir*");
                    Console.WriteLine("========================================");

                    switch (Convert.ToByte(Console.ReadLine()))
                    {
                        case 1:
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("==========Lista de Empleados==========" + "\n");
                                    MenuEleccion();

                                    byte opcMenu = Convert.ToByte(Console.ReadLine());

                                    switch (opcMenu)
                                    {
                                        case 1:
                                            do
                                            {
                                                try
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("-Doctores-");
                                                    Doctor.MostrarLista();
                                                    Console.WriteLine("\n" + "Seleccione uno para ver o eliminar" + "\n6. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info" + "\n2. borrar" + "\n3. Calcular salario" + "\n4. Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            Doctor.MostrarInfo(Convert.ToByte(opc - 1));

                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            Doctor.BorrarInfo(Convert.ToByte(opc - 1));
                                                        }
                                                        else if (opc2 == 3)
                                                        {
                                                            Doctor.CalcularSalario(Convert.ToByte(opc - 1));
                                                        }
                                                    }
                                                    else if (opc == 6)
                                                    {
                                                        Cancelar = true;
                                                    }
                                                    else
                                                    {
                                                        MensajeError();
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    MensajeError();
                                                }
                                                catch (OverflowException)
                                                {
                                                    MensajeError();
                                                }
                                            } while (!Cancelar);
                                            break;
                                        case 2:
                                            do
                                            {
                                                try
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("-Pediatras-");
                                                    Pediatra.MostrarLista();
                                                    Console.WriteLine("\n" + "Seleccione uno para ver o eliminar" + "\n0. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info" + "\n2. borrar" + "\n3. Calcular salario" + "\nClick para Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            Pediatra.MostrarInfo(Convert.ToByte(opc - 1));

                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            Pediatra.BorrarInfo(Convert.ToByte(opc - 1));
                                                        }
                                                        else if (opc2 == 3)
                                                        {
                                                            Pediatra.CalcularSalario(Convert.ToByte(opc - 1));

                                                        }
                                                    }
                                                    else if (opc == 0)
                                                    {
                                                        Cancelar = true;
                                                    }
                                                    else
                                                    {
                                                        MensajeError();
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    MensajeError();
                                                }
                                                catch (OverflowException)
                                                {
                                                    MensajeError();
                                                }
                                            } while (!Cancelar);
                                            break;
                                        case 3:
                                            do
                                            {
                                                try
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("-Enfermeros-");
                                                    Enfermero.MostrarLista();
                                                    Console.WriteLine("\n" + "Seleccione uno para ver o eliminar" + "\n6. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info" + "\n2. borrar" + "\n3. Calcular salario" + "\nClick para Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            Enfermero.MostrarInfo(Convert.ToByte(opc - 1));

                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            Enfermero.BorrarInfo(Convert.ToByte(opc - 1));
                                                        }
                                                        else if (opc2 == 3)
                                                        {
                                                            Enfermero.CalcularSalario(Convert.ToByte(opc - 1));
                                                        }
                                                    }
                                                    else if (opc == 6)
                                                    {
                                                        Cancelar = true;
                                                    }
                                                    else
                                                    {
                                                        MensajeError();
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    MensajeError();
                                                }
                                                catch (OverflowException)
                                                {
                                                    MensajeError();
                                                }
                                            } while (!Cancelar);
                                            break;
                                        case 4:
                                            Volver = true;
                                            break;
                                        default:
                                            MensajeError();
                                            break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    MensajeError();
                                }
                                catch (OverflowException)
                                {
                                    MensajeError();
                                }
                            } while (!Volver);
                            break;
                        case 2:
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("==========Agregar Empleado==========\n");
                                    MenuEleccion();
                                    byte opcEmpleado = Convert.ToByte(Console.ReadLine());
                                    string nombre;
                                    byte exp;

                                    switch (opcEmpleado)
                                    {
                                        case 1:
                                            AgregarEmpleado(out nombre, out exp); // El parametro hace que un metodo devuelva multiples valores
                                            Doctor.AgregarInfo("Doctor", nombre, exp);
                                            break;
                                        case 2: 
                                            AgregarEmpleado(out nombre, out exp); // Algo como un multi-return
                                            Pediatra.AgregarInfo("Pediatra", nombre, exp);
                                            break;
                                        case 3:
                                            AgregarEmpleado(out nombre, out exp); //permiten que un método modifique las variables y luego las devuelva al llamador.
                                            Enfermero.AgregarInfo("Enfermero", nombre, exp);
                                            break;
                                        case 4:
                                            Cancelar = true;
                                            break;
                                        default:
                                            MensajeError();
                                            break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    MensajeError();
                                }
                                catch (OverflowException)
                                {
                                    MensajeError();
                                }
                            } while (!Cancelar);
                            break;
                        case 0:
                            Console.Clear();
                            Salir = true;
                            break;
                        default:
                            MensajeError();
                            break;
                    }
                }
                catch (FormatException)
                {
                    MensajeError();
                }
                catch (OverflowException)
                {
                    MensajeError();
                }
            } while (!Salir);
        }
        public static void MensajeError() // usado en los try-catch
        {
            Console.Clear();
            Console.WriteLine("Error! opcion invalida");
            Console.ReadKey();
        }
        public static void MenuEleccion() // usado en los menus de eleccion de empleados
        {
            Console.Clear();
            Console.WriteLine("*Elija una opcion*");
            Console.WriteLine("1. Doctor");
            Console.WriteLine("2. Pediatra");
            Console.WriteLine("3. Enfermero\n");
            Console.WriteLine("4. Volver");
            Console.WriteLine("====================================");
        }
        static void AgregarEmpleado(out string nombre, out byte exp) // comun al momento de agrgar un empleado independiente del cargo
        {
            Console.Clear();
            Console.WriteLine("Nombre del empleado");
            Console.Write(">>");
            nombre  = Console.ReadLine();
            Console.WriteLine("Años de experiencia");
            Console.Write(">>");
            exp     = Convert.ToByte(Console.ReadLine());
        }
    }
}