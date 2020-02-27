using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
            Console.WriteLine("Name of student: " + p.Name + "\n" + "Mark of student: " +p.GetAvgMark());
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
