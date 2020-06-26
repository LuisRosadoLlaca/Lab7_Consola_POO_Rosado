using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Consola_POO_Rosado
{
    class Notas
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        public double notaA { get; set; }
        public double notaP { get; set; }
        public double notaC { get; set; }

        public double promedio { get; set; }
        public string condicion { get; set; }//condicion del estudiante



        //public Notas(string nombre, string apellido, double notaA, double notaP, double notaC)
        //{
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.notaA = notaA;
        //    this.notaP = notaP;
        //    this.notaC = notaP;
        //}

        List<Notas> lista = new List<Notas>();

        public void Agregar(Notas objNota)
        {
            lista.Add(objNota);
        }


        public void CalcularPromedio(double notaA, double notaP, double notaC)
        {
            this.promedio = (notaA * 0.10) + (notaP * 0.35) + (notaC * 0.55);
            Console.WriteLine("Promedio : " + this.promedio);
        }
        public string ObjtenerCondicion()
        {
            if (this.promedio>=0 && this.promedio < 10.5)
            {
                condicion = "DESAPROBADO";
            }
            else if (this.promedio>=10.5 && this.promedio<=20)
            {
                condicion = "APROBADO";
            }
            else
            {
                condicion = "FUERA DE RANGO (0-20)";
            }
            return condicion;
        }

        public List<Notas> Listar()
        {
            return lista;
        }
    }
}
