using System.Runtime.InteropServices;

namespace Lecture2_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--print the sum of two numbers

            var num1 = 78;
            var num2 = 33;

            Console.WriteLine($"The sum of numbers {num1} and {num2} equals " + (num1 + num2) + "\n");


            //--print the result of dividing two numbers

            var num3 = 44;
            var num4 = -10;

            Console.WriteLine($"The result of division of numbers {num3} and {num4} equals " + (num3 / num4) + "\n");

            //--print the result of the specified operations
            // -1 + 4 * 6
            // (35 + 5) % 7
            // 14 + -4 * 6 / 11
            // 2 + 15 / 6 * 1 - 7 % 2

            Console.WriteLine("The result of expression \"-1 + 4 * 6\" equals " + (-1 + 4 * 6) + "\n");
            Console.WriteLine("The result of expression \"(35 + 5) % 7\" equals " + ((35 + 5) % 7) + "\n");
            Console.WriteLine("The result of expression \"14 + -4 * 6 / 11\" equals " + (14 + -4 * 6 / 11) + "\n");
            Console.WriteLine("The result of expression \"2 + 15 / 6 * 1 - 7 % 2\" equals " + (2 + 15 / 6 * 1 - 7 % 2) + "\n");

            //-- print the output of multiplication of three numbers which will be entered by the user 

            double? firstNum = null;
            double? secondNum = null;
            double? thirdNum = null;

            bool isInProgress = true;

            bool isFirstNumNotSet = true;
            bool isSecondNumNotSet = true;
            bool isThirdNumNotSet = true;

            while (isInProgress)
            {

                while (isFirstNumNotSet)
                {
                    try
                    {
                        Console.WriteLine("Please enter the FIRST number to multiply: ");
                        firstNum = double.Parse(Console.ReadLine());
                        isFirstNumNotSet = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid number");
                        isFirstNumNotSet = true;
                    }
                }

                while (isSecondNumNotSet)
                {
                    try
                    {
                        Console.WriteLine("Please enter the SECOND number to multiply: ");
                        secondNum = double.Parse(Console.ReadLine());
                        isSecondNumNotSet = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid number");
                        isSecondNumNotSet = true;
                    }
                }


                while (isThirdNumNotSet)
                {
                    try
                    {
                        Console.WriteLine("Please enter the THIRD number to multiply: ");
                        thirdNum = double.Parse(Console.ReadLine());
                        isThirdNumNotSet = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid number");
                        isThirdNumNotSet = true;
                    }
                }

                var result = firstNum * secondNum * thirdNum;

                Console.WriteLine($"The result of multiplication of {firstNum}, {secondNum}, {thirdNum} equals " + result);
                isInProgress = false;

            }

            Console.WriteLine("\n\n\n Swapping numbers with third variable");

            // --swap two numbers

            //with third variable

            double ? numFirst = null;
            double? numSecond = null; 
            double? numTemp = null;

            Console.WriteLine("Please enter the first number ");
            numFirst = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number ");
            numSecond = double.Parse(Console.ReadLine());

            Console.WriteLine($"The first number is {numFirst}, the second number is {numSecond}");
            Console.WriteLine("magic goes here");

            numTemp = numFirst;
            numFirst = numSecond;
            numSecond = numTemp;

            Console.WriteLine($"The first number is now {numFirst}, the second number is now {numSecond}");




            //with tuple
            Console.WriteLine("\n\n\n Swapping numbers with tuple");


            double? numFirst1 = null;
            double? numSecond1 = null;

            Console.WriteLine("Please enter the first number ");
            numFirst1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number ");
            numSecond1 = double.Parse(Console.ReadLine());

            Console.WriteLine($"The first number is {numFirst1}, the second number is {numSecond1}");
            Console.WriteLine("magic goes here");

            (numFirst1, numSecond1) = (numSecond1, numFirst1);

            Console.WriteLine($"The first number is now {numFirst1}, the second number is now {numSecond1}");


        }
    }
}
