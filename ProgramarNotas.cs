using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Consola_POO_Rosado
{
    class ProgramarNotas
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }

        private static void Ejecutar()
        {
            Notas objLista = new Notas();


            char opcion = ' ';
            int numero = 1;
            Console.WriteLine("==========================");
            Console.WriteLine(" Notas de los Estudiantes ");
            Console.WriteLine("==========================");
            do
            {
                Notas objNota = new Notas();

                Console.WriteLine("Agrengando estudiante: " + numero++);
                Console.WriteLine("Ingrese Nombres: ");
                objNota.nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellidos: ");
                objNota.apellido = Console.ReadLine();
                Console.WriteLine("Ingrese Nota Actitudina: ");
                objNota.notaA = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Nota Procedimental: ");
                objNota.notaP = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Nota Conceptual: ");
                objNota.notaC = double.Parse(Console.ReadLine());

                objLista.Agregar(objNota);
                Console.WriteLine();

                Console.WriteLine("Desea seguir agregando otro estudiante... (S) o (N)");
                opcion = char.Parse(Console.ReadLine());

            } while (opcion.Equals('s') || opcion.Equals('S'));

            numero = 1;
            Console.WriteLine("==========================");
            Console.WriteLine(" Registro de Estudiantes ");
            Console.WriteLine("==========================");

            foreach (Notas e in objLista.Listar())
            {
                Console.WriteLine("N° : " + numero++);
                Console.WriteLine("Nombres : " + e.nombre);
                Console.WriteLine("Apellidos : " + e.apellido);
                Console.WriteLine("Nota Actitudinal : "+ e.notaA);
                Console.WriteLine("Nota Procedimental : " + e.notaP);
                Console.WriteLine("Nota Conceptual : " + e.notaC);
                objLista.CalcularPromedio(e.notaA, e.notaP, e.notaC);
                objLista.ObjtenerCondicion();
            }
            Console.ReadKey();
        }     
    }
}
