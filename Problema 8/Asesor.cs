using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    internal class Asesor
    {
        private int codigo;
        private string nombre;
        private int horasTrabajadas;
        private double precioHora;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double PrecioHora { get => precioHora; set => precioHora = value; }

        public Asesor(int codigo, string nombre, int horasTrabajadas, double precioHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.precioHora = precioHora;
        }

        public double SueldoBruto()
        {
            return horasTrabajadas * precioHora;
        }

        public double Descuento()
        {
            return SueldoBruto() * 0.15;
        }

        public double SueldoNeto()
        {
            return SueldoBruto() - Descuento();
        }

        public static void Listado(Asesor a)
        {
            Console.WriteLine("Nombre: " + a.nombre);
            Console.WriteLine("Codigo: " + a.codigo);
            Console.WriteLine("Hortas trabajas: " + a.horasTrabajadas);
            Console.WriteLine("Precio por horas: " + a.precioHora);
            Console.WriteLine("Sueldo bruto: " + a.SueldoBruto());
            Console.WriteLine("Descuento: " + a.Descuento());
            Console.WriteLine("Sueldo Neto: " + a.SueldoNeto() + "\n");
        }

    }
}
