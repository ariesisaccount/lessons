using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("adding two numbers?");
            Console.WriteLine();
            decimal value = RequestInput ("Enter number", 1, 1000000000);
            decimal value2 = RequestInput ("Enter other number", 1, 100000000);
            var calculation = GetCalculation();
            var amount = getresult(calculation, value, value2);
            
            Console.WriteLine ($"sum: {amount:N2}");
            
            Console.ReadKey (true);
        }

        private static decimal getresult(Calculation calculation, decimal value, decimal value2)
        {
            switch(calculation)
            {
                case Calculation.add:
                    return value + value2;
                
                case Calculation.subtract:
                    return value - value2;
                
                case Calculation.multiply:
                    return value * value2;
                
                case Calculation.divide:
                    return value / value2;
                default:
                    throw new InvalidOperationException();
            }
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

        static Calculation GetCalculation(){
         Console.WriteLine("select Calculation");
         Console.WriteLine("1. add");
         Console.WriteLine("2. subtract");
         Console.WriteLine("3. multiply");
         Console.WriteLine("4. divide");
         Console.Write("enter selection: ");
         var input = Console.ReadLine();
         return (Calculation)Convert.ToInt32(input);
        }
    }
}
