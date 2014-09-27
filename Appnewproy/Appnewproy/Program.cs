using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero, num;
            Console.WriteLine("Programa que Pasa de Numero a caracter");
            Console.WriteLine("Escriba un Numero del 1 al 5 en numero");
            numero = Console.ReadLine();
            num = numero.ToUpper();

            switch (num)
            {
                case "1":
                    Console.WriteLine("UNO");
                    break;
                case "2":
                    Console.WriteLine("DOS");
                    break;
                case "3":
                    Console.WriteLine("TRES");
                    break;
                case "4":
                    Console.WriteLine("CUATRO");
                    break;
                case "5":
                    Console.WriteLine("CINCO");
                    break;
                default:
                    Console.WriteLine("Numero Fuera de Rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}
