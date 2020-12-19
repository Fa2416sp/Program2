using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            double L, d, d1, m, m1, m2, V1, V2, Sk, S1, S2, S;
            const double ro = 7.9;
            Console.WriteLine("Исходные данные");
            Console.WriteLine("Введите радиус и высоту");
            Console.Write("L = ");
            L = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            d = double.Parse(Console.ReadLine());
            Console.Write("d1 = ");
            d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Вычисления");
               V1 = Math.PI * (double)((Math.Pow(d, 2)) / 4) * L;
               V2 = Math.PI * (double)((Math.Pow((d - 2 * d1), 2)) / 4) * L;
               m1 = ro * V1;
               m2 = ro * V2;
               m = m1 - m2;
               S1 = Math.PI * d * L;
               S2 = Math.PI * (d - 2 * d1) * L;
               Sk = Math.PI * (double)(Math.Pow((d - 2 * d1), 2)) / 4;
               S = 2 * Sk + S1 + S2;
            Console.WriteLine("V1 = {0:##.##}", V1);
            Console.WriteLine("V2 = {0:##.##}", V2);
            Console.WriteLine("m1 = {0:##.##}", m1);
            Console.WriteLine("m2 = {0:##.##}", m2);
            Console.WriteLine("m  = {0:##.##}", m );
            Console.WriteLine("S1 = {0:##.##}", S1);
            Console.WriteLine("S2 = {0:##.##}", S2);
            Console.WriteLine("Sk = {0:##.##}", Sk);
            Console.WriteLine("S  = {0:##.##}", S );
            Console.ReadKey();
        }
    }
}