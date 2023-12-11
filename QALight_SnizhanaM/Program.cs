﻿using QALight_SnizhanaM;
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

            Console.WriteLine($"Student's name is {studentName}. {studentName} is {studentAge} years old. Her average grade is {averageGrade}.\n");

            //Variables and data types. Part 2.

            int result = Sum("10", "20");
            Console.WriteLine($"The result of the method Sum is {result}.\n");

            //Arithmetic operations. Part 1.
            MathOperations(89.4, 45);

            //Arithmetic operations. Part 2.
            double averageNumberResult = AverageNumber(7, 9, 23.5);
            Console.WriteLine($"The Arithmetic Mean is {averageNumberResult}.\n");
            
            //Classes and methods. Part 1.
            Student student = new Student();
            student.GetStudentInfo();

            //Classes and methods. Part 2.

            Calculator calculatorAddition = new Calculator();
            var add = calculatorAddition.AddNumbers(89, 56);
            Console.WriteLine($"AddNumbers method result is {add}.");

            Calculator calculatorSubtraction = new Calculator();
            var subtract = calculatorSubtraction.SubtractNumbers(8975, 563);
            Console.WriteLine($"SubtractNumbers method result is {subtract}.");

            Calculator calculatorMultiplication = new Calculator();
            var multiply = calculatorMultiplication.MultiplyNumbers(89, 56);
            Console.WriteLine($"MultiplyNumbers method result is {multiply}.");

            Calculator calculatorDivision = new Calculator();
            var divide = calculatorDivision.DivideNumbers(89, 56);
            Console.WriteLine($"DivideNumbers method result is {divide}.\n");

            //Classes and methods. Part 3.
            Student Phillip = new Student();
            var sayingHello = Phillip.SayHelloToAnotherStudent("Oleh");
            Console.WriteLine($"{sayingHello}\n");

            //Classes and methods. Part 4.
            twoNumbersAddition("67", "89");
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
            
            double addition = numberOne + numberTwo;
            Console.WriteLine($"Result of addition is {addition}.");

            double subtraction = numberOne - numberTwo;
            Console.WriteLine($"Result of subtraction is {subtraction}.");

            double multiplication = numberTwo * numberOne;
            Console.WriteLine($"Result of multiplication is {multiplication}.");

            double division = numberTwo / numberOne;
            Console.WriteLine($"Result of division is {division}.\n");
        }
    public static double AverageNumber(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }
        
        
        //Classes and methods. Part 4.
        public static void twoNumbersAddition(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        public static void twoNumbersAddition(string first, string second)
        {
            int firstNumb = Convert.ToInt32(first); 
            int secondNumb = Convert.ToInt32(second);
            Console.WriteLine(firstNumb + secondNumb);
        }
    }

}
