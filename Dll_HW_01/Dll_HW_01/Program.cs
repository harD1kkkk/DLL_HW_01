// See https://aka.ms/new-console-template for more information
namespace DLL_HW;
using DLL_Files;
class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("1 - Show Message");
            Console.WriteLine("2 - Leap Year");
            Console.WriteLine("3 - Math Operations");
            Console.WriteLine("4 - Number Operations");
            Console.WriteLine("5 - Exit");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Show_Some_Message.ShowMessage();
            }

            else if (choice == 2)
            {
                Console.Write("Enter the year: ");
                int year = int.Parse(Console.ReadLine());
                if (year < 0)
                {
                    Console.WriteLine("Incorrect year");
                }
                else
                {
                    bool isLeapYear = LeapYear.IsLeapYear(year);
                    if (isLeapYear)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }

            else if (choice == 3)
            {
                Console.WriteLine("Enter 3 numbers");
                Console.Write("Enter 1 number ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter 2 number ");
                int num2 = int.Parse(Console.ReadLine());

                Console.Write("Enter 3 number ");
                int num3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter operations");
                Console.WriteLine("1 - Max");
                Console.WriteLine("2 - Min");
                Console.WriteLine("3 - Sum");

                int operations = int.Parse(Console.ReadLine());

                if (operations == 1)
                {
                    int Max = MathOperations.Max(num1, num2, num3);
                    Console.WriteLine("Max: " + Max);
                }
                else if (operations == 2)
                {
                    int Min = MathOperations.Min(num1, num2, num3);
                    Console.WriteLine("Min: " + Min);
                }
                else if (operations == 3)
                {
                    int Sum = MathOperations.Sum(num1, num2, num3);
                    Console.WriteLine("Sum: " + Sum);
                }
                else
                {
                    Console.WriteLine("Error options");
                }
            }

            else if (choice == 4)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter operations");
                Console.WriteLine("1 - Factorial");
                Console.WriteLine("2 - Is Prime");
                Console.WriteLine("3 - Is Even");
                Console.WriteLine("4 - Is Odd");

                int operations = int.Parse(Console.ReadLine());

                if (operations == 1)
                {
                    int Factorial = NumberOperations.Factorial(num);
                    Console.WriteLine("Factorial: " + Factorial);
                }
                else if (operations == 2)
                {
                    bool isPrime = NumberOperations.IsPrime(num);
                    if (isPrime)
                    {
                        Console.WriteLine("Number is prime");
                    }
                    else
                    {
                        Console.WriteLine("Number isn't prime");
                    }
                }
                else if (operations == 3)
                {
                    bool isEven = NumberOperations.IsEven(num);
                    if (isEven)
                    {
                        Console.WriteLine("number is even");
                    }
                    else
                    {
                        Console.WriteLine("number isn't even");
                    }
                }
                else if (operations == 4)
                {
                    bool isOdd = NumberOperations.IsOdd(num);
                    if (isOdd)
                    {
                        Console.WriteLine("number is odd");
                    }
                    else
                    {
                        Console.WriteLine("number isn't odd");
                    }
                }
                else
                {
                    Console.WriteLine("Error options");
                }
            }
            else
            {
                Console.WriteLine("Error choice");
            }
        }
    }
}