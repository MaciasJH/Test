using System;

public class TextInput
{
    public string value; // Variable to save the value of the Input.
    public virtual void Add(char c) // Method called to add a character to the value, it uses Virtual to be able to override.
    {
        this.value = this.value + c; // Value gets a new char added.
    }

    public string GetValue() // Method that returns the value of the current instance of the class.
    {
        return (this.value);
    }
}

public class NumericInput : TextInput // Class that inherits from TextInput
{
    public override void Add(char c) // Method that overrides the one from the base class, uses override to do it.
    {
        if (Char.IsNumber(c) == true) // Checks if the character given is a numeric character.
        {
            this.value = this.value + c; // If true, value gets a new char added, else, it does nothing.
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
        Console.ReadKey();
    }
}