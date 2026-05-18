using System.Net;

class JournalEntry
{
    string _date;

    string _prompt;

    string _responce;

    string[] _prompts =
    {
        "How are you feeling today? ",
        "Who did you talk to today? "
    };
    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();
        Console.WriteLine(_prompts[0]);
        _responce = Console.ReadLine();
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_responce}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_responce}";
    }

}