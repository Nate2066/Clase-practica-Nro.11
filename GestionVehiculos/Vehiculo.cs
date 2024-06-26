﻿using System;
using System.Media;


namespace GestionVehiculos
{
    public class Vehiculos
    {
        
        private string[] Nombre = new string[5];
        private string[] Marca = new string[5];
        private string[] Color = new string[5];
        private string TipoDeVehiculo;

        public Vehiculos(string pNombre, string pMarca, string pColor, string pTipoDeVehiculo, int pNumeroID)
        {
            Nombre[pNumeroID] = pNombre;
            Marca[pNumeroID] = pMarca;
            Color[pNumeroID] = pColor;
            TipoDeVehiculo = pTipoDeVehiculo;
        }
        public virtual void HacerSonido()
        {
            SoundPlayer player = new SoundPlayer();
        }
        public virtual void MostrarInfo(int pNumeroAsignado)
        {
            Console.Clear();
            Console.WriteLine("==========Informacion del vehiculo==========" + "\n");
            Console.WriteLine("* Nombre: " + Nombre[pNumeroAsignado]);
            Console.WriteLine("* Marca:  " + Marca[pNumeroAsignado]);
            Console.WriteLine("* Color:  " + Color[pNumeroAsignado]);
            Console.WriteLine("* Tipo:   " + TipoDeVehiculo);
            Console.WriteLine("\n" + "============================================");
            Console.ReadKey();
        }
        public virtual void MostrarLista()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + ". " + Nombre[i] + "(" + Marca[i] + ")");
            }
            Console.WriteLine("");
        }
        public virtual void AgregarInfo(string pNombre, string pMarca, string pColor)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Nombre[i] == default && Marca[i] == default && Color[i] == default)
                {
                    Nombre[i] = pNombre;
                    Marca[i] = pMarca;
                    Color[i] = pColor;
                    TipoDeVehiculo = "Terrestre";
                    break;
                }
                else if (Nombre[4] != default && Marca[4] != default && Color[4] != default)
                {
                    Console.Clear();
                    Console.WriteLine("Ya no tiene espacios para agregar otro vehiculo de este tipo");
                    Console.ReadKey();
                    break;
                }
            }
        }
        public virtual void BorrarInfo(int NumeroIdentificador)
        {
            Console.Clear();
            Nombre[NumeroIdentificador] = default;
            Marca[NumeroIdentificador] = default;
            Color[NumeroIdentificador] = default;
            TipoDeVehiculo = default;
            Console.WriteLine("Datos de vehiculo borrados con exito");
            Console.ReadKey();
        }
    }
}
