using System;

class Program
{

}
class Display
{
    public void DisplayOptions(Journal journalInput)
    {
        Console.WriteLine("Please slect one of the following:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        journalInput.Menu();
    }
}
class Prompts
{
     Random random = new Random();
    
    string[] journalPrompts = {
    "What was the best thing that happened to you today?",
    "What steps did you take today towards a goal you're working on?",
    "What are three things you're grateful for today?",
    "What country would you like to visit for the first time?",
    "What magic power would you like to have?",
    "What do you feel is your purpose in life, and has that answer changed in the last five years?",
    "What is your happy place? Describe it in detail",
    "Where do you see yourself in 10 years? 20?",
    "What negative emotions am I holding onto? How can I let them go?",
    "What goals have you lost sight of? Are you interested in picking them up again?",
    "What do you want to be remembered for?" };

    int mIndex = random.Next(journalPrompts.Length);
}

class Journal
{
    Console.WriteLine("What is the file name: ");
    string fileInput = Console.ReadLine();
    string fileName = fileInput;

}
