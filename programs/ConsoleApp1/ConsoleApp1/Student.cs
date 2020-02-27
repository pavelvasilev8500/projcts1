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
            #region Array_of_marks

            #region Marks_of_first_Student
            list.Add(9);
            list.Add(5);
            list.Add(10);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(5);
            list.Add(6);
            #endregion

            #endregion

            double a = 0;
            for (int i = 0; i < list.Count; i++)
            {
                a = a + list[i];
            }
            return a = a / list.Count;
           
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
