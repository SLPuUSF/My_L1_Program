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

            /* Exercise 2
            Input a number (n) from the user and check if it is even or odd.

            Write your code here
            */
            Console.WriteLine("Exercise 2: ");
            Console.WriteLine("Input a number: ");
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
            Console.WriteLine("");

            /* 
            Exercise 3
            Input 3 numbers from the user (x,y,z) and find the greatest of them.

            Write your code here
            */
            Console.WriteLine("Exercise 3");
            Console.WriteLine("Input 3 numbers with 'x, y, z' format:");
            string data = Console.ReadLine();
            var dataSet = data.Split(' ');
            int numberOne = int.Parse(dataSet[0]);
            int numberTwo = int.Parse(dataSet[1]);
            int difference = numberOne - numberTwo;
            if (difference > 0)
            {
                Console.WriteLine("The greatest number is :" + numberOne.ToString());
            }

            else
            {
                Console.WriteLine("The greatest number is :" + numberTwo.ToString());
            }
            Console.WriteLine("");

            /*Exercise 4
            Input a value (n) from the user and calculate the sum of first n natural numbers.
            Eg. n=5. sum = 1+2+3+4+5 = 15

            Write your code here
            */
            Console.WriteLine("Exercise 4");
            Console.WriteLine("Input a value(n)");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = (1 + input) * input / 2;
            Console.WriteLine("the sum of first " + input + "nutural numbers is :" + sum);



            /*
            Exercise 5
            Input a value (n) from the user and display the following * pattern:
            Input n=5
            // Output
            // *
            // **
            // ***
            // ****
            // *****

            Write your code here
            */
            Console.WriteLine("Exercise 5");
            Console.WriteLine("Input a value(n)");
            int number = Convert.ToInt32(Console.ReadLine());
            string starts = "*";
            for (int count = 1; count <= number; count++)
            {
                for (int index = count; index > 0; index--)
                {
                    starts += starts;
                }
                Console.WriteLine(starts);
                starts = "*";
            }




            // Exercise 6
            // Input a value (n) from the user and display the following * pattern:
            // Input n=5
            // Output
            //     *
            //    **
            //   ***
            //  ****
            // *****

            // Write your code here
            Console.WriteLine("Exercise 6");
            Console.WriteLine("Input a value(n)");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            string oneStarts = "*";
            string blanks = " ";
            string line = null;
            for (int count = 1; count <= inputNum; count++)
            {
                for (int i = inputNum - count; i > 0; i--)
                {
                    blanks += blanks;
                }
                for (int index = count; index > 0; index--)
                {
                    oneStarts += oneStarts;
                }
                line = blanks + oneStarts;

                Console.WriteLine(line);
                starts = "*";
                blanks = " ";
                line = null;
            }
        }
    }
}
