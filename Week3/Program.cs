using System;

namespace Week3
{
    public class Program
    {
        public static void Main()
        {
            Operators op = new Operators();

            
            Console.WriteLine("--- Running Task 1: Operators ---");
            op.Add(6, 2);
            op.Sub(6, 2);
            op.Multiply(6, 2);
            op.Divide(6, 2);
            op.OddEvenFinder(7);

          
            Console.WriteLine("\n--- Running Task 2: Null Operations ---");
            Task2_NullOperations.Run();

            
            Console.WriteLine("\n--- Running Task 3: Age Check ---");
            Task3_AgeCheck.Run();

            
            Console.WriteLine("\n--- Running Task 4: Day Switch ---");
            Task4_DaySwitch.Run();

            
            Console.WriteLine("\n--- Running Task 5: Loops ---");
            Task5_Loops.Run();

            
            Console.WriteLine("\n--- Running Task 6: Try-Catch-Finally ---");
            Task6_TryCatchFinally.Run();
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
                Console.WriteLine("Child");
            else if (age < 20)
                Console.WriteLine("Teenager");
            else if (age < 60)
                Console.WriteLine("Adult");
            else
                Console.WriteLine("Senior Citizen");
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
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 3: Console.WriteLine("Tuesday"); break;
                case 4: Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Thursday"); break;
                case 6: Console.WriteLine("Friday"); break;
                case 7: Console.WriteLine("Saturday"); break;
                default: Console.WriteLine("Invalid Number! Enter between 1–7."); break;
            }
        }
    }

    internal class Task5_Loops
    {
        public static void Run()
        {
            
            Console.Write("\nEnter a number (N): ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine($"Sum from 1 to {n} is: {sum}");

           
            Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");
            int num = 1;
            while (num <= 20)
            {
                if (num % 4 == 0)
                {
                    num++;
                    continue;
                }

                if (num == 15)
                    break;

                Console.Write(num + " ");
                num++;
            }

           
            Console.WriteLine("\n\nSum of array elements using foreach:");
            int[] arr = { 2, 4, 6, 8, 10 };
            int total = 0;

            foreach (int val in arr)
                total += val;

            Console.WriteLine("Sum of array = " + total);
        }
    }

    
    internal class Task6_TryCatchFinally
    {
        public static void Run()
        {
            try
            {
                Console.Write("\nEnter a number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
            finally
            {
                Console.WriteLine("Program Executed (finally block).");
            }

            try
            {
                Console.Write("\nEnter a password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                    throw new Exception("Password must be at least 6 characters.");

                Console.WriteLine("Password satisfied the requirement.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
