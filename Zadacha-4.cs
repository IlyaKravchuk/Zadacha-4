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
            bool r;
            Console.WriteLine("Введите первое слово:");
            s1 = Console.ReadLine();
            Console.WriteLine("Введите второе слово:");
            s2 = Console.ReadLine();
            if (s1.Length != s2.Length)
                Console.WriteLine("Нельзя");
            else
            {
                r = false;
                for (k = 0; k < s2.Length; k++)
                {
                    r = false;
                    for (n = 0; n < s2.Length; n++)
                        if (s1[k] == s2[n])
                            r = true;
                    if (!r)
                        break;
                }

                if (r == true)
                    Console.WriteLine("Можно");
                else
                    Console.WriteLine("Нельзя");
            }
            Console.ReadLine();
        }
    }
}
