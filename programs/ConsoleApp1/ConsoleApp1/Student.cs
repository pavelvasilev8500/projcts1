using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public sealed class Student
    {
        public ArrayList studentinfo = new ArrayList();

        public void StudentInfo()
        {
            foreach (object o in studentinfo)
            { Console.Write(o); }
            Console.WriteLine("\n");
            foreach(Mark mark in Marks)
            { Console.WriteLine($"{ mark.Subject}-{mark.Value}\n"); }
        }

        public List<Mark> Marks
        {
            get;
        } = new List<Mark>();

        public double GetAvgMark()
        {
            double a = 0;
            for (int i = 0; i < Marks.Count; i++)
            {
                a = a + Marks[i].Value;
            }
            return a = a / Marks.Count;
           
        }

        public void ResetAllMarks()
        {
            for (int i = 0; i < Marks.Count; i++)
            {
                Marks[i].Value = 0;
            }
        }
    }
}
