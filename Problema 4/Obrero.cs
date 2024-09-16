using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    internal class Obrero
    {
        private int codigo;
        private string nombre;
        private int horasTrabajadas;
        private double tarifaHoras;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double TarifaHoras { get => tarifaHoras; set => tarifaHoras = value; }

        public Obrero(int codigo, string nombre, int horasTrabajadas, double tarifaHoras)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaHoras = tarifaHoras;
        }

        public double SueldoBruto()
        {
            return horasTrabajadas * tarifaHoras;
        }

        public double AFP()
        {
            return SueldoBruto() * 0.1;
        }

        public double EPS()
        {
            return SueldoBruto() * 0.05;
        }
        public double SueldoNeto()
        {
            return SueldoBruto() - AFP() - EPS();
        }
        public static void Listado(Obrero o)
        {
            Console.WriteLine("Codigo: " + o.codigo);
            Console.WriteLine("Nombre: " + o.nombre);
            Console.WriteLine("Horas trabajadas: " + o.horasTrabajadas);
            Console.WriteLine("Tarifa por horas: " + o.tarifaHoras);
            Console.WriteLine("Sueldo Bruto: " + o.SueldoBruto());
            Console.WriteLine("Descuento AFP: " + o.AFP());
            Console.WriteLine("Descuento EPS: " + o.EPS());
            Console.WriteLine("Sueldo neto: " + o.SueldoNeto() + "\n");
        }
    }
}
