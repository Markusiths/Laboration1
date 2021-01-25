using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //ändrar textens färg till vit

            Console.Write("Please Enter Your input Here: ");

            string input = Console.ReadLine();
            long totalSum = 0;
            //startar på "0" för att få första input-siffran på startindex "0" dvs första möjliga startposition
            for (int firstIndex = 0; firstIndex < input.Length; firstIndex++)
                //for-loop för att få hela maskineriet i rörelse. Fortsätter så länge "firstIndex" är mindre (i form av antal tecken) än det som användaren angett och ökar med 1 för varje loop.
            {
                if (!char.IsNumber(input, firstIndex))
                    //om "input" inte är en siffra på "firstIndex" position så går den vidare till nästa instruktion
                {
                    continue;
                }
                for (int lastIndex = firstIndex + 1; lastIndex < input.Length; lastIndex++)
                    //for-loop för "lastIndex". dvs loopen som letar sista siffran för att sedan skapa ett tal utifrpn två lika siffror
                {
                    if (!char.IsNumber(input[lastIndex])) //varför används "[]" i denna if-loopen. betyder det att "lastIndex" är en array?
                        
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