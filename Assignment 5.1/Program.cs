using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._1
{
    internal class Program
    {
        static void Introduction()
        {
            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Assignment 5.1");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Transition()
        {
            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();
        }

        static void Part(int i)
        {
            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n---------------PART {i}---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ClosingMessage()
        {
            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");
        }

        
        static void Main(string[] args)
        {

            #region Part1
            Introduction();
        StartPoint1:

            /*
            Mod 1 Basics
            Assignments:
            1. Given an integer x, return true if x is a palindrome, and false otherwise.
            Example 1:
            Input: x = 121
            Output: true
            Explanation: 121 reads as 121 from left to right and from right to left.

            Example 2:
            Input: x = -121
            Output: false
            Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
            */

            Console.WriteLine("\nI can check if a number is a palindrome.");
            Console.Write("Enter Number: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string palindrome = Console.ReadLine();

            if (PalindromeCheck(palindrome))
            {
                Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(PalindromeCheck(palindrome));
            }
            else
            {
                Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(PalindromeCheck(palindrome));
            }

            Console.ForegroundColor = ConsoleColor.White;

        TryAgain1:

            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint1;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain1;
            } 
            #endregion

            #region Part2
            Transition(); Part(2);
            StartPoint2:
            /*2. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            Test Data :
            Enter a number: 1234
            Expected Output :
            The sum of the digits of the number 1234 is : 10
            */
            Console.WriteLine("\nI can add the individual elements of the number.");
            Console.Write("Enter a number: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string num1 = Console.ReadLine();
            char[] array = num1.ToCharArray();

            int sum = 0;
            foreach (char c in array)
            {
                sum += int.Parse(c.ToString());
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nThe sum of the digits of the number {num1} is: {sum}\n");
            Console.ForegroundColor = ConsoleColor.White;

        TryAgain2:

            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint2;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain2;
            }
            #endregion

            #region Part3
            Transition(); Part(3); StartPoint3:

            /*3. Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
            Example 1:
            Input: nums = [1,2,3,1]
            Output: true
            Example 2:
            Input: nums = [1,2,3,4]
            Output: false
            Example 3:
            Input: nums = [1,1,1,3,3,4,3,2,4,2]
            Output: true
             */
            Console.WriteLine("\nI can tell you if there is a repeat number.");
            Console.Write("Enter an array of integers seperated by commas: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine();
            int[] ints = input.Split(',').Select(int.Parse).ToArray();

            if (repeatNumber(ints))
            {
                Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(repeatNumber(ints));
            }
            else 
            {
                Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(repeatNumber(ints));
            }

            Console.WriteLine(); Console.ForegroundColor = ConsoleColor.White;

        TryAgain3:

            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint3;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain3;
            } 
            #endregion

            ClosingMessage(); Console.ReadKey();
        }

        //Part 1
        static bool PalindromeCheck(string num)
        {
            char[] reversedArray = new char[num.Length];

            for(int i = 0; i < num.Length; i++)
            {
                reversedArray[i] = num[num.Length - i - 1];
            }

            string reversedNum = new string(reversedArray);

            if (num == reversedNum) {return true;}
            return false;
        }

        //Part 3
        static bool repeatNumber(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                for(int j = i+1; j < ints.Length; j++)
                {
                    if (ints[j] == ints[i]) { return true; }
                    
                }
            }
            return false;
        }


    }
}
