using System;

namespace Gestion_Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables principales
            //El "default" asigna los valores por defecto a una variable, en caso de un string seria un espacio y en caso de un int seria un "0", se hace uso de esta para asignar mas facilmente un valor por defecto
            
            bool    Volver                  = false;
            bool    Cancelar                = false;
            bool    Salir                   = false;
            string  NombreEmpleado          = default;
            string  EdadEmpleado            = default;
            string  ExperienciaEmpleado     = default;
            string  TipoEmpleado            = default;
            int     ID                      = default;

            Doctor      doctor      = new Doctor    (NombreEmpleado, EdadEmpleado, ExperienciaEmpleado, TipoEmpleado, ID);
            Enfermero   enfermero   = new Enfermero (NombreEmpleado, EdadEmpleado, ExperienciaEmpleado, TipoEmpleado, ID);
            Pediatra    pediatra    = new Pediatra  (NombreEmpleado, EdadEmpleado, ExperienciaEmpleado, TipoEmpleado, ID);

            //Bienvenida
            Console.WriteLine("---------Binenvenido al sistema de gestion de empleados----------");
            Console.WriteLine(".Click para continuar");
            Console.ReadKey();
            do
            {
                try
                {
                    //Menu :P
                    Console.Clear();
                    Console.WriteLine("==========GESTION DE EMPLEADOS==========");
                    Console.WriteLine("*Que desea realizar?                  \n");
                    Console.WriteLine("1.   Ver lista de Empleados             ");
                    Console.WriteLine("2.   Agregar nuevo Empleado           \n");
                    Console.WriteLine("                             3.  *Salir*");
                    Console.WriteLine("========================================");

                    switch (Convert.ToByte(Console.ReadLine()))
                    {
                        case 1:
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("==========Lista de Empleados==========\n");
                                    Console.WriteLine("*Elija una opcion*                      ");
                                    Console.WriteLine("1. Doctores                             ");
                                    Console.WriteLine("2. Enfermeros                           ");
                                    Console.WriteLine("3. Pediatras                          \n");
                                    Console.WriteLine("4. Volver                               ");
                                    byte opcSegundoMenu = Convert.ToByte(Console.ReadLine());

                                    switch (opcSegundoMenu)
                                    {
                                        case 1:
                                            do
                                            {
                                                try
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("-Doctores-");
                                                    pediatra.MostrarLista();
                                                    Console.WriteLine("\nSeleccione uno para ver o eliminar \n6. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info  \n2. borrar \n3. Hacer sonido   \nClick para Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            doctor.MostrarInfo(opc - 1);
                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            doctor.BorrarInfo(opc - 1);
                                                        }
                                                        else if (opc2 == 3)
                                                        {
                                                            doctor.HacerSonido();
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
                                                    Console.WriteLine("-Enfermeros-");
                                                    doctor.MostrarLista();
                                                    Console.WriteLine("\nSeleccione uno para ver o eliminar    \n6. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info  \n2. borrar  \n3. Hacer sonido  \nClick para Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            enfermero.MostrarInfo(opc - 1);
                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            enfermero.BorrarInfo(opc - 1);
                                                        }
                                                        else if (opc2 == 3)
                                                        {
                                                            enfermero.HacerSonido();
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
                                        case 3:
                                            do
                                            {
                                                try
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("-Pediatras-");
                                                    enfermero.MostrarLista();
                                                    Console.WriteLine("\nSeleccione uno para ver o eliminar    \n6. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info  \n2. borrar \n3. Hacer sonido   \nClick para Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            pediatra.MostrarInfo(opc - 1);
                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            pediatra.BorrarInfo(opc - 1);
                                                        }
                                                        else if (opc2 == 3)
                                                        {
                                                            pediatra.HacerSonido();
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
                                    Console.WriteLine("*Elija un tipo de Empleado*           ");
                                    Console.WriteLine("1. Doctor                             ");
                                    Console.WriteLine("2. Enfermero                          ");
                                    Console.WriteLine("3. Pediatra                           ");
                                    Console.WriteLine("4. Volver                             ");
                                    Console.WriteLine("====================================  ");
                                    byte opcTipoEmpleado = Convert.ToByte(Console.ReadLine());

                                    switch (opcTipoEmpleado)
                                    {
                                        case 1:
                                            Console.Clear();
                                            Console.WriteLine("Nombre del Empleado         \n>>");
                                            NombreEmpleado  = $"Doctor {Console.ReadLine()}";
                                            Console.WriteLine("Edad del Empleado           \n>>");
                                            EdadEmpleado    = Console.ReadLine();
                                            Console.WriteLine("Experiencia del Empleado    \n>>");
                                            ExperienciaEmpleado = Console.ReadLine();

                                            pediatra.AgregarInfo(NombreEmpleado, EdadEmpleado, ExperienciaEmpleado);
                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine("Nombre del Empleado         \n>>");
                                            NombreEmpleado  = $"Enfermero {Console.ReadLine()}";
                                            Console.WriteLine("Edad del Empleado           \n>>");
                                            EdadEmpleado    = Console.ReadLine();
                                            Console.WriteLine("Experiencia del Empleado    \n>>");
                                            ExperienciaEmpleado = Console.ReadLine();

                                            doctor.AgregarInfo(NombreEmpleado, EdadEmpleado, ExperienciaEmpleado);
                                            break;
                                        case 3:
                                            Console.Clear();
                                            Console.WriteLine("Nombre del Empleado         \n>>");
                                            NombreEmpleado  = $"Pediatra {Console.ReadLine()}";
                                            Console.WriteLine("Edad del Empleado           \n>>");
                                            EdadEmpleado    = Console.ReadLine();
                                            Console.WriteLine("Experiencia del Empleado    \n>>");
                                            ExperienciaEmpleado = Console.ReadLine();

                                            enfermero.AgregarInfo(NombreEmpleado, EdadEmpleado, ExperienciaEmpleado);
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
                        case 3:
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
        public static void MensajeError()
        {
            Console.Clear();
            Console.WriteLine("Error! opcion invalida");
            Console.ReadKey();
        }
    }
}