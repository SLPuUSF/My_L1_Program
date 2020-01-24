using System;

namespace My_L1_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Exercise 1
            Calculate the area of a triangle using Heron's formula
            Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            Eg. a=3, b=4, c=5. Area = 6

            Write your code here 
            */

            double a = 3;
            double b = 4;
            double c = 5;
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("Exercise 1:");
            Console.WriteLine("Area of Triangle: " + area.ToString());
            Console.WriteLine("");

            // Exercise 2
            // Input a number (n) from the user and check if it is even or odd.

            // Write your code here
            string userInput = Console.ReadLine();
            int num = int.Parse(userInput);
            int quot = num / 2;
            int remainder = num - num * quot;

            if (remainder != 0)
            {
                Console.WriteLine("the inputed number is odd.");
            }

            else
            {
                Console.WriteLine("the inputed number is even.");
            }


            /* 
            Exercise 3
            Input 3 numbers from the user (x,y,z) and find the greatest of them.

            Write your code here
            */

            var data = Console.ReadLine();
            var dataSet = line.Split(' ');
            var numberOne = int.Parse(dataSet[0]);
            var numberTwo = int.Parse(dataSet[1]);
            double difference = numberOne - numberTwo;
            if (difference > 0)
            {
                Console.WriteLine("The greatest number is :" + numberOne.ToString());
            }

            else
            {
                Debug.WriteLine("The greatest number is :" + numberTwo.ToString());
            }

        }
    }
}
