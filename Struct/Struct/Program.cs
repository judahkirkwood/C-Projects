using System;

namespace Struct
{
    // Struct called Number with property "Amount" using type decimal
    struct Number
    {
        public Number(decimal amount)
        {
            Amount = amount;
        }

        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of data type Number
            Number myNumber = new Number();

            // Assign an amount to the Amount property
            myNumber.Amount = 42.75m;

            // Print to the console
            Console.WriteLine($"Amount: {myNumber.Amount}");

            Console.ReadLine();
        }
    }
}
