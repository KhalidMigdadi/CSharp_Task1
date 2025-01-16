using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
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


            Console.Write("First Name: ");
            string fName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lName = Console.ReadLine();

            Console.Write("Year Of Birthday: ");
            string BDay = Console.ReadLine();

            //Console.Write(fName + " " + lName + " " + BDay);

            Console.WriteLine(fName + " " + lName + " " + BDay);

            int[] theNumbers = new int[10];

                Console.WriteLine("ENter 10 Numbers : ");
                for (int i = 0; i < 10; i++)
                {
                    theNumbers[i] = Convert.ToInt32(Console.ReadLine());


                }

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(theNumbers[i] + " ");
                }



           



    }
    }
}
