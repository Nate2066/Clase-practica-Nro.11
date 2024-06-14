using System;

namespace Gestion_Hospital
{
    public class Empleado
    {

        string Nombre;
        byte Experiencia, Edad;
        double Salario;

        public Empleado(string nombre, byte edad, byte experiencia)
        {
            Nombre = nombre;
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