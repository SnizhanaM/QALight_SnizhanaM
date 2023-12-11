using System;
using System.Security.Cryptography.X509Certificates;

namespace Lesson1
{
    public class Program
    {
        //Variables and data types. Part 1.

        static void Main(string[] args)
        {
            string studentName = "Sophia";
            int studentAge = 20;
            double averageGrade = 80.5;

            Console.WriteLine($"Student's name is {studentName}. {studentName} is {studentAge} years old. Her average grade is {averageGrade}.");

            //Variables and data types. Part 2.

            int result = Sum("10", "20");
            Console.WriteLine($"The result of the method Sum is {result}.");
        }

        public static int Sum(string firstNumber, string secondNumber)
        {
            int firstInt = Convert.ToInt32(firstNumber);
            int secondInt = Convert.ToInt32(secondNumber);
            return firstInt + secondInt;
        }


    }
}
