using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Skriv in en massa skit:");

            string input = Console.ReadLine();
            long totalSum = 0;
            for (int firstIndex = 0; firstIndex < input.Length; firstIndex++)
            {
                if (!char.IsNumber(input, firstIndex))
                {
                    continue;
                }
                for (int lastIndex = firstIndex + 1; lastIndex < input.Length; lastIndex++)
                {
                    if (!char.IsNumber(input[lastIndex]))
                    { 
                        break;
                    }
                    
                    if (!input[firstIndex].Equals(input[lastIndex])) 
                    {
                        continue;
                    }

                    if (firstIndex > 0)
                    {
                        var startString = input.Substring(0, firstIndex);
                        Console.ForegroundColor = ConsoleColor.White; 
                        Console.Write(startString);
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    var numberstring = input.Substring(firstIndex , lastIndex - firstIndex + 1);
                    
                    totalSum += long.Parse(numberstring);

                    Console.Write(numberstring);
                    if (lastIndex < input .Length)
                    {
                        var endString = input.Substring(lastIndex + 1);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(endString);
                    }

                    Console.WriteLine();

                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Totalen är: {totalSum}");
        }
    }
}