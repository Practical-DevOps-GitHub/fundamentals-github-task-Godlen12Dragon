using System;

public class Program
{
    public static void Main()
    {
        // calculator (first task)
        Console.Write("Enter the first number: ");
        string firtsUserResponse = Console.ReadLine();
        double a = Convert.ToDouble(firtsUserResponse);

        Console.Write("Enter the second number: ");
        string secondUserResponse = Console.ReadLine();
        double b = Convert.ToDouble(secondUserResponse);

        Console.WriteLine("And now the result");

        double addition = a + b;
        Console.WriteLine($"Addition: {Math.Round(addition, 2, MidpointRounding.ToEven)}");

        double subtraction = a - b;
        Console.WriteLine($"Subtraction: {Math.Round(subtraction, 2, MidpointRounding.ToEven)}");

        double multiplication = a * b;
        Console.WriteLine($"Multiplication: {Math.Round(multiplication, 2, MidpointRounding.ToEven)}");

        double division = a / b;
        Console.WriteLine($"Division: {Math.Round(division, 2, MidpointRounding.ToEven)}");

        // read value and output (second task)
        Console.WriteLine("");
        Console.WriteLine("How are you?");
        string thirdUserResponse = Console.ReadLine();
        Console.WriteLine("You are: " + thirdUserResponse);

        // read chars values and output (third task)
        Console.WriteLine("");
        Console.WriteLine("Enter something");

        Console.Write("First: ");
        string fourthUserResponse = Console.ReadLine();
        char one = fourthUserResponse.ToCharArray()[0];

        Console.Write("Second: ");
        string fifthUserResponse = Console.ReadLine();
        char two = fifthUserResponse.ToCharArray()[0];

        Console.Write("Thrid: ");
        string sixthUserResponse = Console.ReadLine();
        char three = sixthUserResponse.ToCharArray()[0];

        Console.WriteLine($"You enter {one}, {two}, {three}");

        // bool expression (fourth task)
        Console.WriteLine("");

        Console.Write("Enter 1 number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter 2 number: ");
        int num2 = int.Parse(Console.ReadLine());

        bool bothPositive1 = num1 > 0;
        bool bothPositive2 = num2 > 0;

        Console.WriteLine($"First number are positive: {bothPositive1}");
        Console.WriteLine($"Second number are positive: {bothPositive2}");

        Console.ReadKey();
    }
}
