using System;

namespace Week3
{
    public class Program
    {
        public static void Main()
        {
            Operators op = new Operators();

            op.Add(6, 2);
            op.Sub(6, 2);
            op.Multiply(6, 2);
            op.Divide(6, 2);
            op.OddEvenFinder(7);
            

            Console.WriteLine("\n--- Running Task2_NullOperations ---");
            Task2_NullOperations.Run();

            Console.WriteLine("\n--- Running Task3_AgeCheck ---");
            Task3_AgeCheck.Run();

            Console.WriteLine("\n--- Running Task4_DaySwitch ---");
            Task4_DaySwitch.Run();   
        }
    }

    public class Operators
    {
        public void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("The Sum is: " + sum);
        }

        public void Sub(int a, int b)
        {
            int diff = a - b;
            Console.WriteLine("The Difference is: " + diff);
        }

        public void Multiply(int a, int b)
        {
            int mul = a * b;
            Console.WriteLine("Multiplication of a and b: " + mul);
        }

        public void Divide(int a, int b)
        {
            if (b != 0)
            {
                int div = a / b;
                Console.WriteLine("Divide of a/b: " + div);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }

        public void OddEvenFinder(int a)
        {
            Console.WriteLine("The Number " + a + " is " + (a % 2 == 0 ? "Even" : "Odd"));
        }
    }

    internal class Task2_NullOperations
    {
        public static void Run()
        {
            string username = null;

            Console.WriteLine(username == null ? "Username is not available" : username);
            Console.WriteLine(username ?? "Username is not available (??)");

            username ??= "DefaultUser";
            Console.WriteLine("Updated Username: " + username);
        }
    }

    internal class Task3_AgeCheck
    {
        public static void Run()
        {
            Console.Write("\nEnter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age < 20)
            {
                Console.WriteLine("Teenager");
            }
            else if (age < 60)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Senior Citizen");
            }
        }
    }

    
    internal class Task4_DaySwitch
    {
        public static void Run()
        {
            Console.Write("\nEnter a number (1–7): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Number! Enter between 1–7.");
                    break;
            }
        }
    }
}
