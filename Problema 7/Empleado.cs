using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    internal class Empleado
    {
        private int codigo;
        private string nombre;
        private int numeroCelular;
        private double sueldoSoles;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroCelular { get => numeroCelular; set => numeroCelular = value; }
        public double SueldoSoles { get => sueldoSoles; set => sueldoSoles = value; }

        public Empleado(int codigo, string nombre, int numeroCelular, double sueldoSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numeroCelular = numeroCelular;
            this.sueldoSoles = sueldoSoles;
        }

        public string MayorMenorIgual()
        {
            if (sueldoSoles == 3500) { return "Igual a 3500"; }
            else if (sueldoSoles > 3500) { return "Mayor a 3500"; }
            else
            { return "Menor a 3500"; } 
        }

        public static void Listado(Empleado e)
        {
            Console.WriteLine("Codigo: " + e.codigo);
            Console.WriteLine("Nombre: " + e.nombre);
            Console.WriteLine("Numero de celular: " + e.numeroCelular);
            Console.WriteLine("Sueldo en soles: " + e.sueldoSoles);
            Console.WriteLine("Mayor o Menor o Igual: " + e.MayorMenorIgual() + "\n");
        }

    }
}
