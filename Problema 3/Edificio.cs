using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Edificio
    {

        private int codigo;
        private int numeroDepartamento;
        private int cantidadPisos;
        private double precioDolaresDepartamento;

        public int Codigo { get => codigo; set => codigo = value; }
        public int NumeroDepartamento { get => numeroDepartamento; set => numeroDepartamento = value; }
        public int CantidadPisos { get => cantidadPisos; set => cantidadPisos = value; }
        public double PrecioDolaresDepartamento { get => precioDolaresDepartamento; set => precioDolaresDepartamento = value; }

        public Edificio(int codigo, int numeroDepartamento, int cantidadPisos, double precioDolaresDepartamento)
        {
            this.codigo = codigo;
            this.numeroDepartamento = numeroDepartamento;
            this.cantidadPisos = cantidadPisos;
            this.precioDolaresDepartamento = precioDolaresDepartamento;
        }

        public double PrecioEdificio()
        {
            return numeroDepartamento * precioDolaresDepartamento;
        }

        public static void Listado(Edificio x)
        {
            Console.WriteLine("Codigo: " + x.codigo);
            Console.WriteLine("Numero de departamentos: " + x.numeroDepartamento);
            Console.WriteLine("Cantidad de pisos: " + x.cantidadPisos);
            Console.WriteLine("Precio dolares de departamento: " + x.precioDolaresDepartamento);
            Console.WriteLine("Precio del edificio: " + x.PrecioEdificio()+ "\n");
        }


    }
}
