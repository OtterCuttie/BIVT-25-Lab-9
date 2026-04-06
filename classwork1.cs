using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student[]
            {
                new Student ("A","a",new  int[,]{ { 1, 2, 3 }, { 3,5,6} }),
                new Student("B", "b",new int[,]{ { 1, 2, 3 }, { 3, 5, 6 } }),
                new Student("C", "c",new int[,]{ { 1, 2, 3 }, { 3, 5, 6 } })
            };
            student[0][0, 0] = 5;
            foreach (var s in student)
            {
                Console.WriteLine(s[0,1]);
            }
        }
        public class Student
        {
            string _name;
            string _surname;
            int[,] _marks;
            public int[,] Marks => _marks;
            public double[] AverageMarks
            {
                get
                {
                    if (_marks == null || _marks.GetLength(0) == 0 || _marks.GetLength(1) == 0)
                        return null;
                    var average = new double[_marks.GetLength(0)];
                    for(int i=0; i < average.Length; i++)
                    {
                        for (int j = 0; j < _marks.GetLength(1); j++)
                        {
                            average[i] += (double)_marks[i, j] / _marks.GetLength(1);
                        }
                    }
                    return average;
                }
            }
            public Student(string name,string surname, int[,] marks = null)
            {

            }
        }
    }
}
