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
            byte OpcionPrimerMenu;

            //Bienvenida
            Console.WriteLine("---------Binenvenido al sistema de gestion de vehiculos----------");
            Console.WriteLine(".Click para continuar");
            Console.ReadKey();
            do
            {
                try
                {
                    //Menu bien perron Bv
                    Console.Clear();
                    Console.WriteLine("==========GESTION DE VEHICULOS==========");
                    Console.WriteLine("*Que desea realizar?                    " + "\n");
                    Console.WriteLine("1.   Ver lista de vehiculos");
                    Console.WriteLine("2.   Agregar nuevo vehiculo");
                    Console.WriteLine("3.   Eliminar vehiculo");
                    Console.WriteLine("4.   Interactuar con vehiculo" + "\n");
                    Console.WriteLine("                             5.  *Salir*");
                    Console.WriteLine("========================================");
                    OpcionPrimerMenu = Convert.ToByte(Console.ReadLine());

                    switch (OpcionPrimerMenu)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
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
