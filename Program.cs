using System;
using System.Linq;
using System.Collections.Generic;

namespace Практическая_16._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<country> c = new List<country>();
            country c1 = new country("Россия ", 146023195);
            country c2 = new country("Сингапур", 6058739);
            country c3 = new country("США", 335028178);
            country c4 = new country("Франция", 65790152);
            country c5 = new country("Индия", 1408044253);
            country c6 = new country("Бразилия", 215681045);
            country c7 = new country("Египет", 105838455);
            c.Add(c1);
            c.Add(c2);
            c.Add(c3);
            c.Add(c4);
            c.Add(c5);
            c.Add(c6);
            c.Add(c7);
            Console.WriteLine("введи n");
            int n = int.Parse(Console.ReadLine());
            List<string> s1 = new List<string>();
            List<int> s2 = new List<int>();
            for (int i = 0; i < c.Count; i++)
            {
                s1.Add(c[i].name);
                s2.Add(c[i].chisl);
            }
            Console.WriteLine();
            IEnumerable<int> events = from i in s2
                                      where i > n
                                      select i;
            foreach (int i in events)
            {
                Console.WriteLine(i);
            }
        }
    }
}
