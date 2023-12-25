using QALight_SnizhanaM;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Lesson1
{
    public class Program
    {
        //Variables and data types. Part 1.

        static void Main(string[] args)
        {
            /*string studentName = "Sophia";
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

            //HOMEWORK2. WORK WITH STRINGS
            var workWithStrings = "HOMEWORK 2. PART 1. WORK WITH STRINGS.";
            Console.WriteLine(workWithStrings);
            var greeting = "Hello, How Are YoU?";
            var splitGreeting = greeting.Split(',').Last();
            Console.WriteLine(splitGreeting);

            var trimSplitGreeting = splitGreeting.Trim();
            Console.WriteLine(trimSplitGreeting);

            var toLowerGreeting = trimSplitGreeting.ToLower();
            Console.WriteLine(toLowerGreeting);

            var cutHello = greeting.Substring(0, 5);
            Console.WriteLine(cutHello);

            //HOMEWORK2. CLASSES
            var inheritance = "HOMEWORK 2. PART 2. WORK CLASSES.";
            Console.WriteLine(inheritance);

            
            var car = new Car();
            var bike = new Bike();

            var carService = new CarService();

            carService.MakeService(car);
            carService.MakeService(bike);*/
            

            //HOMEWORK 3.

            

            var boeing = new Boeing("Boeing 757-200", "982 km/h", "10760 meters", "1990");
            boeing.ShowPlaneInfo();
            Console.WriteLine($"{boeing}\n");
            var yearOfIncident1 = boeing.GetYearOfIssue();
            Console.WriteLine($"In {yearOfIncident1} the hijacked aircraft struck a parked China Southwest Airlines Boeing 707\n");




            var airbus = new Airbus("Airbus A319-114", "871 km/h", "11168 meters", "2003");
            airbus.ShowPlaneInfo();
            Console.WriteLine($"{airbus}\n");
            var yearOfIncident2 = airbus.GetYearOfIssue();
            Console.WriteLine($"In {yearOfIncident2} was damaged by maintenance personnel");


            var eurocopter = new Eurocopter_EC225_Super_Puma("passenger transport helicopter", "275.5 km/h", "5,900 m", "2023");
            eurocopter.ShowHelicopterInfo();
            Console.WriteLine($"{eurocopter}\n");
            var yearOfHelicopterIncident1 = eurocopter.GetYearOfHelicopterIssue();
            Console.WriteLine($"Eurocopter_EC225 crashed into a kindergarten in Brovary in {yearOfHelicopterIncident1}");

            var chopper = new Chopper_6("Eurocopter AS-350 Astar", "289 km/h", "4,600 m", "2023");
            chopper.ShowHelicopterInfo();
            Console.WriteLine($"{chopper}\n");
            var yearOfHelicopterIncident2 = chopper.GetYearOfHelicopterIssue();
            Console.WriteLine($"Chopper 6 crashed into a wooded area of Burlington County, in New Jersey, in {yearOfHelicopterIncident2}");

            var hangar = new Hangar();
            hangar.AddFlyingTransport(boeing);
            hangar.AddFlyingTransport(airbus);
            hangar.AddFlyingTransport(eurocopter);
            hangar.AddFlyingTransport(chopper);

            

        }

        /*public static int Sum(string firstNumber, string secondNumber)
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
            Console.WriteLine($"{firstNumb + secondNumb} \n");
        }*/




    }

}
