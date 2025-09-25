using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypesProject.Delegates
{
    public static class DelegateFuncType
    {
        //This delegate is the same as...:
        public delegate int DelegateFuncTypeExample(int a, int b);

        //..As declaring as func:
        public static Func<int, int, int> FuncTypeExample;

        public static Func<DateTime> FuncPrintDateTime = () => DateTime.Now;

        public static void MethodDelegateFunc()
        {
            Console.WriteLine("Write a number:");
            var numA = int.TryParse(Console.ReadLine(), out int resultA) ? resultA : 0;
            Console.WriteLine("Write a second number:");
            var numB = int.TryParse(Console.ReadLine(), out int resultB) ? resultB : 0;

            FuncTypeExample = Sum;
            Console.WriteLine($"Sum: {FuncTypeExample(numA, numB)}");

            FuncTypeExample = Multiplication;
            Console.WriteLine($"Multiplication: {FuncTypeExample(numA, numB)}");

            Console.WriteLine();
            Console.WriteLine(FuncPrintDateTime());
        }

        private static int Sum(int numA, int numB)
        {
            return numA + numB;
        }
        
        private static int Multiplication(int numA, int numB)
        {
            return numA * numB;
        }
    }
}
