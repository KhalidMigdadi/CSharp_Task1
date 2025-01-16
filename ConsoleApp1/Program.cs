using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");  // Prompt user
        string name = Console.ReadLine();       // Read the input from the user
        Console.WriteLine("Hello, " + name);    // Display the input back to the user


        // declare variables 
        int num1 = 5;

        Console.WriteLine("Number 3: " + num1);


        float floatNumber = 4.66f;
        Console.WriteLine("Float Number: " + floatNumber);

        double doubleNumber = 3.14159265358979;
        Console.WriteLine("Double Number: " + doubleNumber);

        char myChar = 'C';
        Console.WriteLine("Character: " + myChar);

        string myName = "Khalid";
        Console.WriteLine("String: " + myName);


        const float PI = 3.14f;
        Console.WriteLine("Const: " + PI);


        string[] cars = { "BMW", "Volvo", "Golf" };

        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }
}