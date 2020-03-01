using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Mark
    {

        public static void Marks(List<double> list)
        {
            list.Add(10);
            list.Add(10);
            list.Add(10);
            list.Add(10);
            list.Add(10);
        }


        List<double> mark = new List<double>();
        List<string> subject = new List<string>();
        public string Subject_mark()
        {
            Mark.Marks(mark);

            #region Array_of_subjects

            #region Subjects_of_first_Student
            subject.Add("Q");
            subject.Add("W");
            subject.Add("E");
            subject.Add("R");
            subject.Add("T");
            #endregion

            #endregion

            for (int i = 0; i < subject.Count; i++)
            {
                Console.WriteLine(subject[i] + " = " + mark[i] + "\n");
            }

            return "";
        }
    }
}
