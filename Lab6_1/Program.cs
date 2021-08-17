using System;

namespace Lab6_1
{
    public class Program
    {
        public class PrimeNumbers
        {
            public static int GetPrime(int i)
            {
                int[] primeNum = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
                return primeNum[i - 1];
            }

            public static bool IsPrime(int x)
            {
                for (int i = 2; i < (x / 2); i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        static bool KeepGoing()
        {
            while (true)
            {
                Console.WriteLine("Do you want to find another prime number?? (y/n)");
                string response = Console.ReadLine().ToLower();
                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n.");
                }
            }
        }

        static void Main(string[] args)
        {
            do
            {
                Console.Write("What prime number are you looking for?: ");
                int numIndex = Int32.Parse(Console.ReadLine());
                int foundNum = PrimeNumbers.GetPrime(numIndex);
                Console.WriteLine($"The number {numIndex} prime is {foundNum}.");
            } while (KeepGoing());
        }
    }
}
