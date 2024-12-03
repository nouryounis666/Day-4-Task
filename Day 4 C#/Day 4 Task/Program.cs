using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem 1
            //// using new int[size]
            //int[] array1 = new int[3];
            //array1[0] = 6;
            //array1[1] = 7;
            //array1[2] = 18;

            //Console.WriteLine(array1[0]);
            //Console.WriteLine(array1[1]);
            //Console.WriteLine(array1[2]);

            //// using initializer list
            //int[] array2 = {1,2,3};

            //Console.WriteLine($"{array2[0]}\n{array2[1]}\n{array2[2]}");

            //// using array syntax sugar 
            //int[] array3 = new int[] { 30, 40 ,50};

            //Console.WriteLine($"{array3[0]}\n{array3[1]}\n{array3[2]}");

            //// Demonstrating IndexOutOfRangeException
            //// This will throw an exception because index 3 is out of bounds
            //Console.WriteLine(array3[3]); // IndexOutOfRangeException

            ///* Question: What is the default value assigned to array elements in C#?
            //   Answer: The default value assigned to array elements in C# is 0 for Numeric types, 
            //           false for Boolean and null for Reference types.
            //*/ 
            #endregion

            #region Problem 2 
            //int[] arr01 = { 1, 2, 3 }; 
            //int[] arr02 = { 4, 5, 6 };

            //Console.WriteLine(arr01.GetHashCode());
            //Console.WriteLine(arr02.GetHashCode());

            //// Shallow copy
            //arr02 = arr01;

            //Console.WriteLine(arr01.GetHashCode());
            //Console.WriteLine(arr02.GetHashCode());

            //// Modify arr01 and demonstrate effect on arr02
            //arr01[0] = 16; 
            //Console.WriteLine(arr02[0]); // Output: 16

            //// Deep copy using Clone method
            //arr02 = (int[])arr01.Clone();

            //Array.Sort(arr02); // Sorting: arr02 = { 2, 3, 16 }

            //// Display elements of arr02 after deep copy
            //foreach (var item in arr02) 
            //{
            //    Console.Write(item + " "); // Output: 2 3 16
            //}

            ///* Question: What is the difference between Array.Clone() and Array.Copy()? 
            //   Answer:Array.Clone(): Creates a shallow copy of the array, copying the references, not the objects themselves.
            //   Array.Copy(): Copies elements from the source array to the destination array,
            //   requiring a pre-allocated destination array.
            //*/ 
            #endregion

            #region Problem 3
            //int[,] grades = new int[3, 3];

            //for (int student = 0; student < 3; student++)
            //{
            //    for (int subject = 0; subject < 3; subject++)
            //    {
            //        Console.Write($"Enter grade for Student {student + 1}, Subject {subject + 1}: ");
            //        grades[student, subject] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nGrades:");
            //for (int student = 0; student < 3; student++)
            //{
            //    Console.Write($"Student {student + 1}: ");
            //    for (int subject = 0; subject < 3; subject++)
            //    {
            //        Console.Write($"{grades[student, subject]} ");
            //    }
            //    Console.WriteLine();
            //}

            ///* Question: What is the difference between GetLength() and Length for multi dimensional arrays?
            //   Answer: GetLength(dimension) returns the number of elements in the specified dimension of the array, 
            //   while Length returns the total number of elements in all dimensions of the array.
            //*/ 
            #endregion

            #region Problem 4
            //    int[] array = { 5, 3, 8, 1, 2 };

            //    // Sort
            //    Array.Sort(array);
            //    Console.WriteLine("Sorted array:");
            //    PrintArray(array);

            //    // Reverse
            //    Array.Reverse(array);
            //    Console.WriteLine("Reversed array:");
            //    PrintArray(array);

            //    // IndexOf
            //    int index = Array.IndexOf(array, 8);
            //    Console.WriteLine("Index of 8: " + index);

            //    // Copy
            //    int[] copy = new int[array.Length];
            //    Array.Copy(array, copy, array.Length);
            //    Console.WriteLine("Copied array:");
            //    PrintArray(copy);

            //    // Clear
            //    Array.Clear(array, 0, array.Length);
            //    Console.WriteLine("Cleared array:");
            //    PrintArray(array);
            //}

            //static void PrintArray(int[] array)
            //{
            //    foreach (int item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();

            //    /* Question: What is the difference between Array.Copy() and Array.ConstrainedCopy()?
            //        Answer: Array.Copy() is more flexible and can copy elements between arrays of different types 
            //        and no runtime checks for type compatibility, while Array.ConstrainedCopy() Ensures that all elements 
            //        are safely copied, throwing exceptions for type mismatches.
            //    */ 
            #endregion

            #region Problem 5
            //int[] array = { 1, 2, 3, 4, 5 };

            //// For loop
            //Console.WriteLine("Using for loop:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();

            //// Foreach loop
            //Console.WriteLine("Using foreach loop:");
            //foreach (int num in array)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //// While loop in reverse order
            //Console.WriteLine("Using while loop in reverse order:");
            //int index = array.Length - 1;
            //while (index >= 0)
            //{
            //    Console.Write(array[index] + " ");
            //    index--;
            //}
            //Console.WriteLine();

            ///* Question: Why is foreach preferred for read-only operations on arrays?
            //   Answer: foreach is preferred for read-only operations because it simplifies
            //   the code and reduces the risk of modifying the array elements accidentally.
            //*/ 
            #endregion

            #region Problem 6
            //int num;
            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    string input = Console.ReadLine();

            //    if (int.TryParse(input, out num) && num > 0 && num % 2 != 0)
            //    {
            //        Console.WriteLine($"You entered a valid number: {num}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please try again.");
            //    }
            //} 
            //while (true);

            ///* Question: Why is input validation important when working with user inputs?
            //   Answer: Input validation is important to ensure that the program behaves correctly and securely,
            //   preventing errors and potential security vulnerabilities.
            //*/ 
            #endregion

            #region Problem 7 
            //int[,] matrix = {
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //Console.WriteLine("Matrix elements:");
            //for (int i = 0; i < matrix.GetLength(0); i++) // Rows
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++) // Columns
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine(); // New row
            //}

            /*  Question: How can you format the output of a 2D array for better readability?
                Use Tabs (\t): Tabs create uniform spacing between columns.
                String Formatting: Use string formatting to ensure each element has the same width.
                New Lines: Add a new line (\n or Console.WriteLine()) after printing each row to separate rows clearly.
            */
            #endregion

            #region Problem 8
            //Console.Write("Enter a month number: ");
            //int month = int.Parse(Console.ReadLine());

            //// Using if-else
            //if (month == 1)  
            //    Console.WriteLine("January");
            //else if (month == 2) 
            //    Console.WriteLine("February");
            //else if (month == 3) 
            //    Console.WriteLine("March");
            //else if (month == 4)
            //    Console.WriteLine("April");
            //else if (month == 5)
            //    Console.WriteLine("May");
            //else if (month == 6)
            //    Console.WriteLine("June");
            //else if (month == 7)
            //    Console.WriteLine("July");
            //else if (month == 8)
            //    Console.WriteLine("August");
            //else if (month == 9)
            //    Console.WriteLine("September");
            //else if (month == 10)
            //    Console.WriteLine("October");
            //else if (month == 11)
            //    Console.WriteLine("November");
            //else if (month == 12) 
            //    Console.WriteLine("December");
            //else 
            //    Console.WriteLine("Invalid month number");

            //// Using switch
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("January"); 
            //        break;
            //    case 2: 
            //        Console.WriteLine("February"); 
            //        break;
            //    case 3: 
            //        Console.WriteLine("March"); 
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12: 
            //        Console.WriteLine("December"); 
            //        break;
            //    default: 
            //        Console.WriteLine("Invalid month number"); 
            //        break;
            //}
            ///* Question: When should you prefer a switch statement over if-else?
            //   Answer: Switch is preferred when you are checking a single variable against multiple specific values.
            //   and when the code becomes more readable than long chains of if-else.
            //*/
            #endregion

            #region Problem 9
            //int[] numbers = { 10, 50, 20, 40, 30 };

            //// Sort the array
            //Array.Sort(numbers);
            //Console.WriteLine("Sorted array:");
            //foreach (int num in numbers) 
            //    Console.Write(num + " ");

            //Console.WriteLine();

            //// Search for a specific value
            //int index = Array.IndexOf(numbers, 30);
            //Console.WriteLine("\nIndex of 30: ");
            //Console.WriteLine(index);

            //index = Array.LastIndexOf(numbers, 30);
            //Console.WriteLine("\nLast index of 30: ");
            //Console.WriteLine(index);

            ///* Question: What is the time complexity of Array.Sort()?
            //   Answer: The time complexity of Array.Sort() is O(n log n),
            //   where n is the number of elements in the array.
            //*/ 
            #endregion

            #region Problem 10
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //// Sum using for loop
            //int sum1 = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum1 += numbers[i];
            //}
            //Console.WriteLine($"Sum using for loop: {sum1}");

            //// Sum using foreach loop
            //int sum2 = 0;
            //foreach (int num in numbers)
            //{
            //    sum2 += num;
            //}
            //Console.WriteLine($"Sum using foreach loop: {sum2}");

            ///* Question: Which loop (for or foreach) is more efficient for calculating the sum of an array, and why?
            //   Answer: Both loops are generally similar in efficiency for calculating the sum of an array. However, 
            //   foreach is often preferred for readability and simplicity when you don't need to access the index of the elements.
            //   The performance difference is negligible for most practical purposes.
            //*/ 
            #endregion

        }
    }
}

