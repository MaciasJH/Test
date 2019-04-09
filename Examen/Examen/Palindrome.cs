using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        string pal = word.ToLower(); // First I convert the word into LowerCase and assign it to a new variable.
        string lap = ""; // I declare a second variable where I'm going to save the word backwards.

        // This loop is used to generate the word backwards, for as long as the original word is (in chars), it adds
        // a character to the variable, one by one it is generated.
        for (int i = 1; i < pal.Length+1; i++)
        {
            lap = lap + pal[pal.Length-i];
        }
        Console.WriteLine("Palabra original: " + pal + " Palabra volteada: " + lap);
        // If the original word is the same as the word backwards, then it returns true, as it is a Palindrome.
        if (pal == lap)
        {
            return (true);
        }
        return (false);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
        Console.ReadLine();
    }
}
