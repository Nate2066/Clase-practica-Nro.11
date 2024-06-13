//By Nate :D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionVehiculos
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool Salir = false;
            bool Volver = false;
            do
            {
                try
                {
                    Console.Clear();
                    
                    Console.WriteLine("----------Gestion Vehiculos---------" +"\n"+ "\n1. Agregar Vehiculo" + "\n2. Eliminar Vehiculo" + "\n3. Mostrar Info de Vehiculo" + "\n4. Salir");
                    byte opc = Convert.ToByte(Console.ReadLine());

                    switch(opc)
                    {
                        case 1:
                            do
                            {
                                try
                                {
                                    string pNombreDeVehiculo = "";
                                    string pMarcaVehiculo = "";
                                    string pColorVehiculo = "";

                                    Console.Clear();
                                    Console.WriteLine("Que tipo de vehiculo desea agregar?" + "\n" + "\n1. MotoCicleta" + "\n2. Automovil" + "\n3. Camion" + "\n4. Volver");
                                    byte opc1 = Convert.ToByte(Console.ReadLine());
                                    if(opc1 == 1)
                                    {
                                        pNombreDeVehiculo = "Motocicleta";
                                    }
                                    else if(opc1 == 2)
                                    {
                                        pNombreDeVehiculo = "Automovil";
                                    }
                                    else if(opc1 == 3 )
                                    {
                                        pNombreDeVehiculo = "Camion";
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Error! opcion invalida");
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                    Console.WriteLine("Ingrese la marca de su vehiculo");
                                    pMarcaVehiculo = Console.ReadLine();

                                    Console.Clear();
                                    Console.WriteLine("Ingrese el color de su vehiculo");
                                    pColorVehiculo = Console.ReadLine();

                                    Console.Clear();
                                    if(pNombreDeVehiculo == "Motocicleta")
                                    {
                                        Vehiculo moto = new Vehiculo(pNombreDeVehiculo, pMarcaVehiculo, "Terrestre", pColorVehiculo);
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
                            break;
                        case 3:
                            break;
                    }
                }
                catch(FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Error! opcion invalida");
                    Console.ReadKey();
                }
                catch(OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("Error! opcion invalida");
                    Console.ReadKey();
                }
            } while (!Salir);
        }
    }
}
