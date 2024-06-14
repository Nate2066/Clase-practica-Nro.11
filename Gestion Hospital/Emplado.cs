using System;

namespace Gestion_Hospital
{
    public class Empleado
    {

        string Nombre;
        byte Experiencia;
        double Salario;

        public Empleado(string nombre, byte experiencia, double salario)
        {
            Nombre = nombre;
            Experiencia = experiencia;
            Salario = salario;
        }

        public virtual void CalcularSalario()
        {

            Salario = Salario * (Experiencia / 100);
        }
        public virtual void Examinar()
        {
            Console.WriteLine($"Nombre: {Nombre} \nAños de experiencia: {Experiencia}");
            Console.ReadKey();
        }
    }
}