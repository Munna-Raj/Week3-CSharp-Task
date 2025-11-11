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
}
