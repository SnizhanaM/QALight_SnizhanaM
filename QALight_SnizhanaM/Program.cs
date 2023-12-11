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

            


            //Arithmetic operations. Part 2.
            double averageNumberResult = AverageNumber(7, 9, 23.5);
            Console.WriteLine($"The Arithmetic Mean is {averageNumberResult}.");
        }

        public static int Sum(string firstNumber, string secondNumber)
        {
            int firstInt = Convert.ToInt32(firstNumber);
            int secondInt = Convert.ToInt32(secondNumber);
            return firstInt + secondInt;
        }

        //Arithmetic operations. Part 1.
        public static void MathOperations(double numberOne, double numberTwo)
        {
            numberOne = 12;
            numberTwo = 27;
            double addition = numberOne + numberTwo;
            Console.WriteLine($"Result of addition is {addition}.");

            double subtraction = numberOne - numberTwo;
            Console.WriteLine($"Result of subtraction is {subtraction}.");

            double multiplication = numberTwo * numberOne;
            Console.WriteLine($"Result of multiplication is {multiplication}.");

            double division = numberTwo / numberOne;
            Console.WriteLine($"Result of division is {division}.");
        }
    public static double AverageNumber(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }
    }

}
