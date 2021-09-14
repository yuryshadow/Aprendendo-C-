using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
            Console.WriteLine("Insira a temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            // (C * 9 /5) + 32 = F
            f = (c * 9 / 5) + 32;

            //c + 275,15
            k = c + 276.15;

            Console.WriteLine(c + "graus celcius = " + f + " graus gahrenheit");
            Console.WriteLine(c + "graus celcius = " + k + " graus kelvin");
            Console.WriteLine("--------------------------------------");

            Console.ReadLine();
        }
    }
}
