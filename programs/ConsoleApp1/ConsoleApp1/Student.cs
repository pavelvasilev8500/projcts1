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
            for (int i = 1; i < 10; i++)
            {
                list.Add(i);
            }
            double a = 0;
            for (int i = 0; i < list.Count; i++)
            {
                a = a + list[i];
            }
            return a / list.Count;
        }

        public void ResetAllMarks()
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = 0;
            }
        }
    }
}
