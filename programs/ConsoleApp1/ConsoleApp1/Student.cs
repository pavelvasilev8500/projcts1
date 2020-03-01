using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        
        List<double> list = new List<double>();
        private string name = "Name Surname";

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double GetAvgMark()
        {
            Mark.Marks(list);
            double a = 0;
            for (int i = 0; i < list.Count; i++)
            {
                a = a + list[i];
            }
            return a = a / list.Count;
           
        }

        public double ResetAllMarks()
        {
            double a1 = 10;
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = 0;
                a1 = list[i];
            }
            return a1;
        }
    }
}
