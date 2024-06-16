using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Eventos
{
    internal class Program
    {
        static void Main()
        {
            //Variables principales
            //El "default" asigna los valores por defecto a una variable, en caso de un string seria un espacio y en caso de un int seria un "0", se hace uso de esta para asignar mas facilmente un valor por defecto
            string Tipo = default;
            string Asunto = default;
            int ID = default;

            bool Salir = false;
            bool Volver = false;
            bool Cancelar = false;

            Concierto Concierto = new Concierto(Tipo, Asunto, ID);
            Piñata Piñata = new Piñata(Tipo, Asunto, ID);
            Conferencia Conferencia = new Conferencia(Tipo, Asunto, ID);

            //Bienvenida
            Console.WriteLine("---------Bienvenido al sistema de gestion de Eventos----------");
            Console.WriteLine("Precione cualquier tecla para continuar");
            Console.ReadKey();
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("==========GESTION DE EVENTOS==========");
                    Console.WriteLine("*Que desea realizar?                  \n");
                    Console.WriteLine("1.   Ver lista de Eventos");
                    Console.WriteLine("2.   Agregar nuevo Evento\n");
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
                                    Console.WriteLine("==========Lista de Eventos==========" + "\n");
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
                                                    Console.WriteLine("-Concierto-");
                                                    Concierto.MostrarLista();
                                                    Console.WriteLine("\n" + "Seleccione uno para ver o eliminar" + "\n6. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info" + "\n2. borrar" + "\n3. Calcular Costo" + "\n4. Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            Concierto.MostrarInfo(Convert.ToByte(opc - 1));

                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            Concierto.BorrarInfo(Convert.ToByte(opc - 1));
                                                        }
                                                        else if (opc2 == 3)
                                                        {
                                                            Concierto.CalcularCosto(Convert.ToByte(opc - 1));
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
                                                    Console.WriteLine("-Conferencia-");
                                                    Conferencia.MostrarLista();
                                                    Console.WriteLine("\n" + "Seleccione uno para ver o eliminar" + "\n0. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info" + "\n2. borrar" + "\n3. Calcular Costo" + "\nClick para Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            Conferencia.MostrarInfo(Convert.ToByte(opc - 1));

                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            Conferencia.BorrarInfo(Convert.ToByte(opc - 1));
                                                        }
                                                        else if (opc2 == 3)
                                                        {
                                                            Conferencia.CalcularCosto(Convert.ToByte(opc - 1));

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
                                                    Console.WriteLine("-Piñata-");
                                                    Piñata.MostrarLista();
                                                    Console.WriteLine("\n" + "Seleccione uno para ver o eliminar" + "\n6. Volver");
                                                    byte opc = Convert.ToByte(Console.ReadLine());
                                                    if (opc > 0 && opc < 6)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("1. Mostrar info" + "\n2. borrar" + "\n3. Calcular Costo" + "\nClick para Volver");
                                                        byte opc2 = Convert.ToByte(Console.ReadLine());
                                                        if (opc2 == 1)
                                                        {
                                                            Piñata.MostrarInfo(Convert.ToByte(opc - 1));

                                                        }
                                                        else if (opc2 == 2)
                                                        {
                                                            Piñata.BorrarInfo(Convert.ToByte(opc - 1));
                                                        }
                                                        else if (opc2 == 3)
                                                        {
                                                            Piñata.CalcularCosto(Convert.ToByte(opc - 1));
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
                                    Console.WriteLine("==========Agregar Evento==========\n");
                                    MenuEleccion();
                                    byte opcEvento = Convert.ToByte(Console.ReadLine());
                                    string asunto;

                                    switch (opcEvento)
                                    {
                                        case 1:
                                            AgregarEvento(out asunto); 
                                            Concierto.AgregarInfo("Concierto", asunto);
                                            break;
                                        case 2:
                                            AgregarEvento(out asunto); 
                                            Conferencia.AgregarInfo("Conferencia", asunto);
                                            break;
                                        case 3:
                                            AgregarEvento(out asunto); 
                                            Piñata.AgregarInfo("Piñata", asunto);
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
        public static void MensajeError() 
        {
            Console.Clear();
            Console.WriteLine("Error! opcion invalida");
            Console.ReadKey();
        }
        public static void MenuEleccion() 
        {
            Console.Clear();
            Console.WriteLine("*Elija una opcion*");
            Console.WriteLine("1. Concierto");
            Console.WriteLine("2. Conferencia");
            Console.WriteLine("3. Piñata\n");
            Console.WriteLine("4. Volver");
            Console.WriteLine("====================================");
        }
        static void AgregarEvento(out string nombre) 
        {
            Console.Clear();
            Console.WriteLine("Asunto del evento");
            Console.Write(">>");
            nombre = Console.ReadLine();
        }
    }
}
