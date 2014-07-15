using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            int k, n;
            Console.WriteLine("Введите первое слово:");
            s1 = Console.ReadLine();
            Console.WriteLine("Введите второе слово:");
            s2 = Console.ReadLine();
            if (s1.Length != s2.Length)
                Console.WriteLine("Нельзя");
            else
            {
                k = 0;
                n = s1.Length;
                while (s2.IndexOf(s1[0]) >= 0)
                {
                    s2.Remove(s1.IndexOf(s2[0]), 1);
                    s1.Remove(0, 1);
                    k = k + 1;
                }
                if (k == n)
                    Console.WriteLine("Можно");
                else
                    Console.WriteLine("Нельзя");
            }
            Console.ReadLine();
        }
    }
}
