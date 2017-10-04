using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("max: " + Math.Max(Math.Max(a, b), c));
            Console.WriteLine("min: " + Math.Min(Math.Min(a, b), c));

            //int max = a;
            //if (b > max) max = b;
            //if (c > max) max = c;
            
            //int min = a;
            //if (b < min) min = b;
            //if (c < min) min = c;

            

            //Console.WriteLine("Max " + max);
            //Console.WriteLine("Min " + min);
            //if ((a > b) && (a >= c)) Console.Write("Najwieksza liczba to:" + a);
            //if ((b > a) && (b >= c)) Console.Write("Najwieksza liczba to:" + b);
            //if ((c > b) && (c >= a)) Console.Write("Najwieksza liczba to:" + c);

            //if ((a < b) && (a <= c)) Console.Write("Najmniejsza liczba to:" + a);
            //if ((b < a) && (b <= c)) Console.Write("Najmniejsza liczba to:" + b);
            //if ((c < b) && (c <= a)) Console.Write("Najmniejsza liczba to:" + c);
            Console.ReadKey();

            /*if((a>b)&&(a>c) || (b<a)&&(b<c))
            {
                Console.WriteLine("Max "+ a);
                Console.WriteLine("Min " + b);
            }

            if ((b > a) && (b > c) || (a < b) && (a < c))
            {
                Console.WriteLine("Max " + b);
                Console.WriteLine("Min " + a);
            }
            if ((c > a) && (c > b) || (b < a) && (b < c))
            {
                Console.WriteLine("Max " + c);
                Console.WriteLine("Min " + b);
            }
            if ((a > b) && (a > c) || (b < a) && (b < c))
            {
                Console.WriteLine("Max " + c);
                Console.WriteLine("Min " + a);
            }

            if ((b > a) && (b > c) || (a < b) && (a < c))
            {
                Console.WriteLine("Max " + a);
                Console.WriteLine("Min " + c);
            }
            if ((c > a) && (c > b) || (b < a) && (b < c))
            {
                Console.WriteLine("Max " + b);
                Console.WriteLine("Min " + c);
            }
            if ((a > b) && (a > c) || (b < a) && (b < c))
            {
                Console.WriteLine("Max " + a);
                Console.WriteLine("Min " + b);
            }

            if ((b > a) && (b > c) || (a < b) && (a < c))
            {
                Console.WriteLine("Max " + b);
                Console.WriteLine("Min " + a);
            }
            if ((c > a) && (c > b) || (b < a) && (b < c))
            {
                Console.WriteLine("Max " + c);
                Console.WriteLine("Min " + b);
            }
            if ((a > b) && (a > c) || (b < a) && (b < c))
            {
                Console.WriteLine("Max " + a);
                Console.WriteLine("Min " + b);
            }

            if ((b > a) && (b > c) || (a < b) && (a < c))
            {
                Console.WriteLine("Max " + b);
                Console.WriteLine("Min " + a);
            }
            if ((c > a) && (c > b) || (b < a) && (b < c))
            {
                Console.WriteLine("Max " + c);
                Console.WriteLine("Min " + b);
            }
            if ((a > b) && (a > c) || (b < a) && (b < c))
            {
                Console.WriteLine("Max " + a);
                Console.WriteLine("Min " + b);
            }

            if ((b > a) && (b > c) || (a < b) && (a < c))
            {
                Console.WriteLine("Max " + b);
                Console.WriteLine("Min " + a);
            }
            if ((c > a) && (c > b) || (b < a) && (b < c))
            {
                Console.WriteLine("Max " + c);
                Console.WriteLine("Min " + b);
            }*/
            
        }
    }
}
