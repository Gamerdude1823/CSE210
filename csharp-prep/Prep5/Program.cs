using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptName();
        int userNum = PromptNum();

        int squaredNum = SquareNum(userNum);

        DisplayResult(userName, squaredNum);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptNum()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());

        return num;
    }

    static int SquareNum(int num)
    {
        int square = num * num;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}