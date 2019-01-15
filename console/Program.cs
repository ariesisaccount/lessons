using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("adding two numbers?");
            Console.WriteLine();
            var value = RequestInput ("Enter number", 1, 1000000000);
            var value2 = RequestInput ("Enter other number", 1, 100000000);

            var amount = value + value2;
            Console.WriteLine ($"sum: {amount}");


Console.ReadKey (true);






        }
 static int RequestInput(string message, int minValue, int maxValue)
        {
            int? result = null;
            Console.Write($"{message}: ");
            while(result == null)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var val) && 
                    val >= minValue 
                    && val <= maxValue)
                {
                    result = val;
                }
                else
                {
                    Console.WriteLine($"Please enter a value from {minValue} to {maxValue}");
                }
            }
            return result.Value;
        }
    }
}
