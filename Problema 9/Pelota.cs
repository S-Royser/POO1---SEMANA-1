using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    internal class Pelota
    {
        private string marca;
        private double gramos;
        private double presionLibras;
        private double diametroCentimetros;
        private double precio;

        public string Marca { get => marca; set => marca = value; }
        public double Gramos { get => gramos; set => gramos = value; }
        public double PresionLibras { get => presionLibras; set => presionLibras = value; }
        public double DiametroCentimetros { get => diametroCentimetros; set => diametroCentimetros = value; }
        public double Precio { get => precio; set => precio = value; }

        public Pelota(string marca, double gramos, double presionLibras, double diametroCentimetros, double precio)
        {
            this.marca = marca;
            this.gramos = gramos;
            this.presionLibras = presionLibras;
            this.diametroCentimetros = diametroCentimetros;
            this.precio = precio;
        }

        public double Radio()
        {
            return diametroCentimetros / 2;
        }

        public double Volumen()
        {
            return (4 * 3.1416 * Radio() * Radio() * Radio() / 3);
        }

        public double Descuento()
        {
            return precio * 0.1;
        }

        public double ImportePagar()
        {
            return precio - Descuento();
        }

        public static void Listado(Pelota p)
        {
            Console.WriteLine("Marca: " + p.marca);
            Console.WriteLine("Gramos: " + p.gramos);
            Console.WriteLine("Presion libras: " + p.presionLibras);
            Console.WriteLine("Diametro en centimetros: " + p.diametroCentimetros);
            Console.WriteLine("Precio: " + p.precio);
            Console.WriteLine("Radio: " + p.Radio());
            Console.WriteLine("Volumen: " + p.Volumen());
            Console.WriteLine("Descuento: " + p.Descuento());
            Console.WriteLine("Importe a pagar: " + p.ImportePagar() + "\n");
        }

    }
}
