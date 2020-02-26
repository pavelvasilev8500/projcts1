using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
            Console.WriteLine(p.Name);
            Console.WriteLine("\n");
            Console.WriteLine(p.GetAvgMark());
            Console.ReadKey();
        }
    }
}
