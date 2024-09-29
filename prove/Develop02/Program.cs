using System;

public class Journal
{
    static List<Entry> _entries = new List<Entry>();
    static void AddEntry(string newEntry)
    {

    }

    static void DisplayAll()
    {

    }

    static void SaveToFile()
    {

    }

    static void LoadFromFile()
    {

    }
}

public class Entry
{
    public static string _entryText;
    public static string _date;
    static string _promptText = JournalPrompts.GetRandomPrompt();

    public static void Display()
    {
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
        _date = DateTime.Now.ToString("MM/dd/yyyy");
    }
    

}

public class JournalPrompts
{
    static List<string> _prompts = new List<string>{"Did I learn anything new today?", 
                                                   "What was the hardest thing I did today?", 
                                                   "Did I do any acts of service today, and if so what was it?", 
                                                   "What's a goal I can make to be better tomorrow?", 
                                                   "What was different about today?"};
    public static string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 4);
        return _prompts[randomNumber];
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5.Quit\n");
        Console.Write("What would you like to do? ");
        int _userChoice = int.Parse(Console.ReadLine());

        if (_userChoice == 1)
        {
            Entry.Display();
        }

    }
}