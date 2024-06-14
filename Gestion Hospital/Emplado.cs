using System;

namespace Gestion_Hospital
{
    public class Empleado
    {

        public string Nombre;
        private byte Experiencia, Edad;
        private double Salario;

        public Empleado(string nombre/*, byte edad, byte experiencia*/)
        {
            Nombre = nombre;
        }

        public virtual void Completar(byte experiencia, byte edad)
        {
            Experiencia = experiencia;
            Edad = edad;
        }

        public virtual void CalcularSalario()
        {

            Salario = Salario * (Experiencia / 100);
        }
        public virtual void Examinar()
        {
            Console.WriteLine($"Nombre: {Nombre} \n Edad: {Edad}\nAños de experiencia: {Experiencia}");
            Console.ReadKey();
        }
    }
}