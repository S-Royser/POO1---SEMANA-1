using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    internal class Paciente
    {
        private string nombre;
        private string apellido;
        private int edad;
        private double talla;
        private double peso;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Talla { get => talla; set => talla = value; }
        public double Peso { get => peso; set => peso = value; }

        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }

        public string MayorMenor()
        {
            if (edad < 18)
            {
                return "Menor edad";
            }
            else
                return "Mayor edad";
        }


        public static void Listado(Paciente p)
        {
            Console.WriteLine("Nombre: " + p.nombre);
            Console.WriteLine("Apellido: " + p.apellido);
            Console.WriteLine("Edada: " + p.edad);
            Console.WriteLine("Talla: " + p.talla);
            Console.WriteLine("Peso: " + p.peso);
            Console.WriteLine("Mayor de edad o Menor: " + p.MayorMenor() + "\n");

        }

    }

}
