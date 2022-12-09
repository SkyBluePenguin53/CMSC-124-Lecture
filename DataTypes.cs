using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*******************************************************************
                        EXPLORATION OF C#
                        
                Created by: Ron Gerlan F. Naragdao
                        December 9, 2022
*******************************************************************/


/*******************************************************************
When using Visual Code Studio, type dotnet run in console to run C#.
*******************************************************************/

namespace Csharp
{
    public class DataTypes
    {
        public void printDataTypes()
        {
            const double PI = 3.141592653589793D;

            //User login style string input and output.
            Console.Write("Enter your name: ");
            var message = Console.ReadLine();
            Console.WriteLine("Hello, " + message + "!\n");

            //Multiplication with PI
            Console.Write("Enter a multiplicand for PI: ");
            int multiplicand = Convert.ToInt32(Console.ReadLine());
            double product = PI*multiplicand;
            Console.WriteLine("The product is " + multiplicand + "π or " + product + ".\n"); //This is poggers.

            //Division with format.
            //Cannot be written as dividend divisor in console.
            //Must be typed separately.
            Console.Write("Enter the dividend for division: ");
            int dividend = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the divisor for division: ");
            int divisor = Convert.ToInt16(Console.ReadLine());
            int quotient = dividend/divisor;
            int remainder = dividend%divisor;
            Console.WriteLine("The quotient is "+quotient+" with remainder "+remainder+".\n");

            //Math comparison (max and min)
            Console.Write("Enter the first number for comparison: ");
            int op1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the second number for comparison: ");
            int op2 = Convert.ToInt16(Console.ReadLine());
            int maxNum = Math.Max(op1,op2);
            int minNum = Math.Min(op1,op2);
            Console.WriteLine("The highest number is "+maxNum+".");
            Console.WriteLine("The lowest number is "+minNum+".\n");

            //Math processing
            Console.Write("Enter a number to be processed in Math: ");
            double mathNum = Convert.ToDouble(Console.ReadLine());
            double mathSqrt = Math.Sqrt(mathNum);
            double mathAbs = Math.Abs(mathNum);
            double mathRound = Math.Round(mathNum);
            Console.WriteLine("The square root of "+mathNum+" is "+mathSqrt);
            Console.WriteLine("The absolute value of "+mathNum+" is "+mathAbs);
            Console.WriteLine(mathNum+" rounded to the nearest whole number is "+mathRound+".");
        }
    }
}