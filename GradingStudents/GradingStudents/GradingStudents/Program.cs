using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Grades = new List<int>();
            List<int> RoundedGrades = new List<int>();
            Console.WriteLine("Enter the number of Students : \t");
            int nOofStudents = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("\n Enter the Grades of {0} students in new line: \n");

            int grade = 0;
            for (int i = 0; i < nOofStudents; i++)
            {
                grade = Convert.ToInt32(Console.ReadLine().Trim());
                Grades.Add(grade);
            }

            RoundedGrades = RoundGrades(Grades);

            Console.WriteLine("\n Rounded Grades are: ");

            foreach(int roundGrade in RoundedGrades)
            {
                Console.WriteLine(roundGrade);
            }

            Console.ReadLine();
        }

        static List<int> RoundGrades(List<int> grades)
        {
            //List<int> resultGrade = new List<int>();
            //int nextMultipleOf5 = 0;
            //int divident = 0;
            //int roundedGrade = 0;
            //foreach(int grade in grades)
            //{
            //    if (grade > 37)
            //    {
            //        roundedGrade = grade;
            //        divident = grade / 5;
            //        nextMultipleOf5 = (divident + 1) * 5;

            //        if ((nextMultipleOf5 - grade) < 3)
            //        {
            //            roundedGrade = nextMultipleOf5;
            //        }

            //        resultGrade.Add(roundedGrade);
            //    }
            //    else
            //    {
            //        resultGrade.Add(grade);
            //    }
            //}

            //return resultGrade;
            //return grades.Select(grade => grade < 38 || (grade % 5 < 3) ? grade : grade + (5 - grade % 5)).ToList<int>(); //Single Line Result from Comments!

            return grades.Select(grade => grade < 38 || (grade % 5 < 3) ? grade : grade + (5 - grade % 5)).ToList<int>(); //This is Fantastic!!!!!!
        }
    }
}
