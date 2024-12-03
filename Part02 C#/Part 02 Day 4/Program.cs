using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_02_Day_4
{
    enum DayOfWeek { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1-7):"); 
            int num = int.Parse(Console.ReadLine()); 
            if (num >= 1 && num <= 7) 
            { 
                DayOfWeek day = (DayOfWeek)num;
                Console.WriteLine($"The day is: {day}"); 
            }
            else 
            {
                Console.WriteLine("Invalid input, please enter a number between 1 and 7."); 
            }

            /* What happens if the user enters a value outside the range of 1 to 7? 
               If the user enters a value outside the range of 1 to 7, the if condition will fail, 
               and the program will print an error message: "Invalid input, please enter a number between 1 and 7."
               This ensures that the program handles invalid inputs gracefully and prompts the user to enter a valid number.
            */


        }
    }
}


