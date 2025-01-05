namespace Quiz;

public class Question3
{
    public int Question()
    {
        Console.WriteLine(Menu.Questions[3]);
        Console.WriteLine();
        
        char userChoice = Convert.ToChar(Console.ReadLine()!);

        if (char.ToLower(userChoice) == Menu.Answers[3]) 
        {
            AnswerColor.ColorRightAnswer();
            return 1;
        }
        else
        {
            AnswerColor.ColorWrongAnswer();
            Console.WriteLine($"The correct answer is option {Menu.Answers[3]}");
            return 0; // Wrong answer
        }
    }
}
