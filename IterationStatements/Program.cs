using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();
            
            //Create a variable of type int and initialize the variable with a value of 0 - DONE
            var myNum= 0;


            // Create a do-while loop - DONE
            do
            {
                myNum++;
                numbers.Add(myNum);
                // Increment your variable by 1 - DONE
                // Then add your variable to "numbers" - DONE
            } while (myNum < 100);
            // While your variable is less than 100 - DONE



            // Create a while loop - DONE
            // While your variable is less than 200 - DONE
            while (myNum<200)
            {
                myNum++;
                numbers.Add(myNum);
                // Increment your variable by 1 - DONE
                // Then add your variable to "numbers" - DONE
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop - DONE
            // Write your variable to the console - DONE
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop - DONE
            // in your initializer set the value of i to 199 -DONE
            // in your conditional, as long as i is less than or equal to the length of "numbers" -DONE
            // and as long as i is greater than or equal to 0 -DONE
            // Decrement i by 1 -DONE
            for (int i=199;i <=myNum && i>=0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
                // Write to the console "numbers" at index i - DONE
            }
        }
    }
}
