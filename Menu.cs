namespace Quiz;

public class Menu
{
    public static Dictionary<int, string> Questions = new Dictionary<int, string>()
    {
        { 1, "Where was the first Jalsa Ahmadiyya take place:\n(a)Rabwah\n(b)Pakistan\n(c)Qadian\n(d)Indian" },
        { 2, "In what year was the first Jalsa Qadian held?\n(a)1908\n(b)1918\n(c)1891\n(d)1835" },
        { 3, "How many people attended the first Ahmadiyya Jalsa?\n(a)108\n(b)118\n(c)101\n(d)100" },
        { 4, "Who won the Ballon d'Or in 2024?\n(a)Vinicius Junior\n(b)Rodri\n(c)Ademola Lukmon\n(d)Jude Bellingham" },
        { 5, "Who won last year's African Ballon d'Or?\n(a)Bukayo Saka\n(b)Victor Osimhen\n(c)Ademola Lukmon\n(d)Mohamed Salah" }
    };

    public static Dictionary<int, char> Answers = new Dictionary<int, char>()
    {
        { 1, 'c' },
        { 2, 'c' },
        { 3, 'c' },
        { 4, 'b' },
        { 5, 'c' }
    };

    public void MainMenu()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=== Welcome to my Mental Drill! ===");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("You are to choose between option a - d");
        Console.WriteLine();
    }
}
