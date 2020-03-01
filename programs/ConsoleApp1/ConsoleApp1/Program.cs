using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
            Console.WriteLine("Name of student: " + p.Name + "\n" + "\n" + "Mark of student: " +p.GetAvgMark() + "\n");
            Mark p1 = new Mark();
            Console.WriteLine(p1.Subject_mark());
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
