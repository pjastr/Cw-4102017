using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rodzaj wprowadzanej temperatury, K - Kelvin, C - Celsjusz, F - Fahrenheit");
            ConsoleKeyInfo klawisz = Console.ReadKey();
            char temp = klawisz.KeyChar;
            Console.WriteLine(Environment.NewLine+"podaj wartość temperatury");
            double wartosc = Convert.ToDouble(Console.ReadLine());
            if (temp == 'K')
            {
                Console.WriteLine("coś tam-k");
            }
            else if (temp == 'C')
            {
                Console.WriteLine("coś tam-c");
            }
            else if (temp == 'F')
            {
                Console.WriteLine("coś tam-f");
            }

            Console.ReadKey();

        }
    }
}
