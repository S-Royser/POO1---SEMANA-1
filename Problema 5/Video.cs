using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    internal class Video
    {
        private int codigo;
        private string nombreVideo;
        private double duracion;
        private double precioSoles;
        private double tipoCambio;

        public int Codigo { get => codigo; set => codigo = value; }
        public string NombreVideo { get => nombreVideo; set => nombreVideo = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public double PrecioSoles { get => precioSoles; set => precioSoles = value; }
        public double TipoCambio { get => tipoCambio; set => tipoCambio = value; }

        public Video(int codigo, string nombreVideo, double duracion, double precioSoles, double tipoCambio)
        {
            this.codigo = codigo;
            this.nombreVideo = nombreVideo;
            this.duracion = duracion;
            this.precioSoles = precioSoles;
            this.tipoCambio = tipoCambio;
        }

        public double PrecioDolares()
        {
            return precioSoles * 3.35;
        }

        public static void Listado(Video v)
        {
            Console.WriteLine("Codigo: " + v.codigo);
            Console.WriteLine("Nombre del video: " + v.nombreVideo);
            Console.WriteLine("Duracion: " + v.duracion);
            Console.WriteLine("Precio en soles: " + v.precioSoles);
            Console.WriteLine("Tipo de cambio: " + v.tipoCambio);
            Console.WriteLine("Precio en dolares: " + v.PrecioDolares() + "\n");
      
        }


    }
}
