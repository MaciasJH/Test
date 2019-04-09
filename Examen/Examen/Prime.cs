using System;

public class Prime
{
    public static bool IsPrime(int num) // Function IsPrime, given an integer, it checks whether or not that integer is a prime number
    {
        if (num > 1) // Researching, I found out that prime numbers are bigger than 1, so this is the first validation
        {
            // This loop is used to check every number lower than the given integer, if any division gives a residue then
            // the number given is not a Prime number, if it loops through every number until the given one without
            // finding a division with 0 as residue, then the integer is a Prime number
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return (false);
                }
            }
            return (true);            
        }
        else
        {
            return (false);
        }
    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a positive integer:"); // Message asking the user to input a positive integer.
            int number;
            try
            {
                number = Convert.ToInt32(Console.ReadLine()); // Reads the integer and saves it in a variable.
            }                        
            catch (Exception)
            {
                Console.WriteLine("Error, user did not type an integer");
                Console.ReadKey();
                return;
            }
            if (IsPrime(number) == true) // Calls the function IsPrime with the number given, if it returns true it prints "Prime"
            {
                Console.WriteLine("Prime");
            }
            else // If it returns false, it prints "Not Prime"
            {
                Console.WriteLine("Not Prime");
            }
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}