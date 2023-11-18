using ExcerciseAccountException.Entities;
using ExcerciseAccountException.Entities.Exception;
using System;
namespace ExerciseAccountException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("---Enter account data---");
                Console.Write("Number:");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder:");
                string holder = Console.ReadLine();
                Account account = new Account(holder);
                Console.Write("Initial balance:");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit:");
                double limit = double.Parse(Console.ReadLine());
                account = new Account(number, limit);
                account.Deposit(balance);

                Console.Write("\nEnter amount for withdraw:");
                double amout = double.Parse(Console.ReadLine());
                account.WithDraw(amout);
                Console.WriteLine(account);
            }
            catch (DomainException error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }
            catch (FormatException error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }
        }
    }
}