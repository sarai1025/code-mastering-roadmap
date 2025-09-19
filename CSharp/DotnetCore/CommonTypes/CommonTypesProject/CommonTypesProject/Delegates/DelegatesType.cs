using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypesProject.Delegates
{
    public static class DelegatesType
    {
        public delegate void PrintDelegate();
        public delegate int CalculateTotalDelegate(int amount);

        public static void Execute()
        {
            if (DateTime.Now.Hour < 17)
            {
                StartInteraction(PrintFarewellAtMorning);
            }
            else
            {
                StartInteraction(PrintFarewellAtEvening);
            }

            //PrintDelegate printDelegate = PrintFarewellAtMorning;
            //printDelegate += PrintFarewellAtEvening;
            //printDelegate();

            //printDelegate = Guardar;
            //printDelegate();
        }

        public static void Guardar() { }

        public static void StartInteraction(PrintDelegate printFarewall)
        {
            Console.WriteLine("How many items you will buy?");
            int.TryParse(Console.ReadLine(), out int amount);

            CalculateTotalDelegate calculate = CalculateCost;
            var cost = calculate(amount);
            calculate = CalculateTotalTax;
            var total = calculate(cost);

            Console.WriteLine($"Total cost without tax: {cost}");
            Console.WriteLine($"Total cost: {total}");

            printFarewall();
        }

        public static int CalculateCost(int amount)
        {
            return amount * 5000;
        }

        public static int CalculateTotalTax(int cost)
        {
            return cost * 2;
        }

        public static void PrintFarewellAtMorning()
        {
            Console.WriteLine("Good bye, Have a nice day!");
        }

        public static void PrintFarewellAtEvening()
        {
            Console.WriteLine("Good bye, have a good night!");
        }

    }
}
