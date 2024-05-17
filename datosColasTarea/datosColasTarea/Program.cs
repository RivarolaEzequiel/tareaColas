using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datosColasTarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            Console.WriteLine("INGRESAR LA CANTIDAD DE PERSONAS EN LA FILA: ");
            int numeroPersonas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroPersonas; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona {0}:", i);
                string nombrePersona = Console.ReadLine();
                fila.Enqueue(nombrePersona);
            }
            Console.WriteLine("\n Atencion en el cajero autmatico: ");
            while (fila.Count > 0)
            {
                string siguientePersona = fila.Dequeue();
                Console.WriteLine("Atendido: {0}", siguientePersona);
            }
            Console.WriteLine("\n No hay mas personas en la fila.");
            Console.ReadKey();
        }
    }
}
