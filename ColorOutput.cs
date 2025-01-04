namespace Quiz;
public class AnswerColor
{
    public static void ColorWrongAnswer()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Incorrect!");
        Console.ResetColor();
    }
    public static void ColorRightAnswer()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct!");
        Console.ResetColor();
    }
}
