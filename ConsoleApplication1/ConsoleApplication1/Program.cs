using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            Console.WriteLine("Programa Promedio de 3 Notas");
            Console.WriteLine("Digite Nota 1:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite Nota 2:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite Nota 3:");
            nota3 = float.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio >= 3.5)
            {
                Console.WriteLine("es promocionado del Diploamado");
            }
            else
            {
                Console.WriteLine("No es promocionado del diplomado");
            }
            Console.ReadKey();
        }
    }
}
