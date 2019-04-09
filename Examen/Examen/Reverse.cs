using System;

public class Reverse
{
    public static void ReverseSentence(string s) // Method that reverses a sentence.
    {
        string[] split = s.Split(' '); // First we split the sentence using Split, we give it the space to do the split and save the result in a new array.
        string revers = "";  // We declare another variable where the reversed sentence will be saved.
        for (int i = 1; i < split.Length+1; i++) // Loops through the lenght of the array.
        {
            revers = revers + split[split.Length-i] + " "; // On each loop, we concatenate to the variable each part of the sentence previously split.
        }
        Console.WriteLine("Original sentence: " + s); // Writes the original sentence.
        Console.WriteLine("Sentence backwards: "+revers); // Writes the sentence reversed.
        Console.ReadKey();
    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a sentence:"); // Message asking the user to input a sentence.
            string sentence = Console.ReadLine(); // Reads the sentence and saves it in a variable.
            ReverseSentence(sentence); // Calls the method ReverseSentence with the value given.
            Console.Clear();
        }

     }
}
