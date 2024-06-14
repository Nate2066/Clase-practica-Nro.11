//By Nate :D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables principales
            bool Salir = false;
            //El "default" asigna los valores por defecto a una variable, en caso de un string seria un espacio y en caso de un int seria un "0", se hace uso de esta para asignar mas facilmente un valor por defecto
            string NombreVehiculo = default;
            string MarcaVehiculo = default;
            string ColorVehiculo = default;
            string TipoVehiculo = default;
            int NumeroID = default;

            AutoMovil auto = new AutoMovil(NombreVehiculo, MarcaVehiculo, ColorVehiculo, TipoVehiculo, NumeroID);
            Camion camion = new Camion(NombreVehiculo, MarcaVehiculo, ColorVehiculo, TipoVehiculo, NumeroID);
            Motocicleta moto = new Motocicleta(NombreVehiculo, MarcaVehiculo, ColorVehiculo, TipoVehiculo, NumeroID);

            //Bienvenida
            Console.WriteLine("---------Binenvenido al sistema de gestion de vehiculos----------");
            Console.WriteLine(".Click para continuar");
            Console.ReadKey();
            do
            {
                bool Volver = false;
                bool Cancelar = false;
                try
                {
                    //Menu bien perron Bv
                    Console.Clear();
                    Console.WriteLine("==========GESTION DE VEHICULOS==========");
                    Console.WriteLine("*Que desea realizar?                    " + "\n");
                    Console.WriteLine("1.   Ver lista de vehiculos");
                    Console.WriteLine("2.   Agregar nuevo vehiculo" + "\n");
                    Console.WriteLine("                             3.  *Salir*");
                    Console.WriteLine("========================================");
                    byte OpcionPrimerMenu = Convert.ToByte(Console.ReadLine());

                    switch (OpcionPrimerMenu)
                    {
                        case 1:
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("==========Lista de vehiculos==========" + "\n");
                                    Console.WriteLine("*Elija una opcion*");
                                    Console.WriteLine("1. Motocicletas");
                                    Console.WriteLine("2. Automoviles");
                                    Console.WriteLine("3. Camiones" + "\n");
                                    Console.WriteLine("4. Volver");
                                    byte opcSegundoMenu = Convert.ToByte(Console.ReadLine());

                                    switch (opcSegundoMenu)
                                    {
                                        case 1:
                                            do
                                            {
                                                try
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("-Motocicletas-");
                                                    moto.MostrarLista();
                                                    Console.WriteLine("\n" + "Seleccione uno para ver o eliminar" + "\n6. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info" + "\n2. borrar" + "\nClick para Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if(opc2 == 1)
                                                        {
                                                            moto.MostrarInfo(opc - 1);

                                                        }
                                                        else if(opc2 == 2)
                                                        {
                                                            moto.BorrarInfo(opc - 1);
                                                        }
                                                    }
                                                    else if(opc == 6)
                                                    {
                                                        Cancelar = true;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Error! opcion invalida");
                                                        Console.ReadKey();
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Error! opcion invalida");
                                                    Console.ReadKey();
                                                }
                                                catch (OverflowException)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Error! opcion invalida");
                                                    Console.ReadKey();
                                                }
                                            } while (!Cancelar);
                                            break;
                                        case 2:
                                            do
                                            {
                                                try
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("-Automoviles-");
                                                    auto.MostrarLista();
                                                    Console.WriteLine("\n" + "Seleccione uno para ver o eliminar" + "\n6. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info" + "\n2. borrar" + "\n3. Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            auto.MostrarInfo(opc - 1);

                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            auto.BorrarInfo(opc - 1);
                                                        }
                                                    }
                                                    else if (opc == 6)
                                                    {
                                                        Cancelar = true;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Error! opcion invalida");
                                                        Console.ReadKey();
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Error! opcion invalida");
                                                    Console.ReadKey();
                                                }
                                                catch (OverflowException)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Error! opcion invalida");
                                                    Console.ReadKey();
                                                }
                                            } while (!Cancelar);
                                            break;
                                        case 3:
                                            do
                                            {
                                                try
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("-Camiones-");
                                                    camion.MostrarLista();
                                                    Console.WriteLine("\n" + "Seleccione uno para ver o eliminar" + "\n6. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info" + "\n2. borrar" + "\n3. Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            camion.MostrarInfo(opc - 1);

                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            camion.BorrarInfo(opc - 1);
                                                        }
                                                        else if(opc2 == 3) { }
                                                    }
                                                    else if (opc == 6)
                                                    {
                                                        Cancelar = true;
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Error! opcion invalida");
                                                        Console.ReadKey();
                                                    }
                                                }
                                                catch (FormatException)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Error! opcion invalida");
                                                    Console.ReadKey();
                                                }
                                                catch (OverflowException)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Error! opcion invalida");
                                                    Console.ReadKey();
                                                }
                                            } while (!Cancelar);
                                            break;
                                        case 4:
                                            Volver = true;
                                            break;
                                        default:
                                            Console.Clear();
                                            Console.WriteLine("Error! opcion invalida");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Error! opcion invalida");
                                    Console.ReadKey();
                                }
                                catch (OverflowException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Error! opcion invalida");
                                    Console.ReadKey();
                                }
                            } while (!Volver);
                            break;
                        case 2:
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("==========Agregar Vehiculo==========" + "\n");
                                    Console.WriteLine("*Elija un tipo de vehiculo*");
                                    Console.WriteLine("1. Motocicleta");
                                    Console.WriteLine("2. Automovil");
                                    Console.WriteLine("3. Camion" + "\n");
                                    Console.WriteLine("4. Volver");
                                    Console.WriteLine("====================================");
                                    byte opcTipoVehiculo = Convert.ToByte(Console.ReadLine());

                                    switch (opcTipoVehiculo)
                                    {
                                        case 1:
                                            Console.Clear();
                                            NombreVehiculo = "Motocicleta";
                                            Console.WriteLine("Marca de vehiculo?");
                                            Console.Write(">>");
                                            MarcaVehiculo = Console.ReadLine();
                                            Console.WriteLine("Color de vehiculo?");
                                            Console.Write(">>");
                                            ColorVehiculo = Console.ReadLine();
                                            moto.AgregarInfo(NombreVehiculo, MarcaVehiculo, ColorVehiculo);
                                            break;
                                        case 2:
                                            Console.Clear();
                                            NombreVehiculo = "Automovil";
                                            Console.WriteLine("Marca de vehiculo?");
                                            Console.Write(">>");
                                            MarcaVehiculo = Console.ReadLine();
                                            Console.WriteLine("Color de vehiculo?");
                                            Console.Write(">>");
                                            ColorVehiculo = Console.ReadLine();
                                            auto.AgregarInfo(NombreVehiculo, MarcaVehiculo, ColorVehiculo);
                                            break;
                                        case 3:
                                            Console.Clear();
                                            NombreVehiculo = "Camion";
                                            Console.WriteLine("Marca de vehiculo?");
                                            Console.Write(">>");
                                            MarcaVehiculo = Console.ReadLine();
                                            Console.WriteLine("Color de vehiculo?");
                                            Console.Write(">>");
                                            ColorVehiculo = Console.ReadLine();
                                            camion.AgregarInfo(NombreVehiculo, MarcaVehiculo, ColorVehiculo);
                                            break;
                                        case 4:
                                            Cancelar = true;
                                            break;
                                        default:
                                            Console.Clear();
                                            Console.WriteLine("Error! opcion invalida");
                                            Console.ReadKey();
                                            break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Error! opcion invalida");
                                    Console.ReadKey();
                                }
                                catch (OverflowException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Error! opcion invalida");
                                    Console.ReadKey();
                                }
                            } while (!Cancelar);
                            break;
                        case 3:
                            Console.Clear();
                            Salir = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Error! opcion invalida");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Error! opcion invalida");
                    Console.ReadKey();
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("Error! opcion invalida");
                    Console.ReadKey();
                }
            } while (!Salir);
        }
    }
}
