namespace Quiz;

public class Question2
{
    public int Question()
    {
        Console.WriteLine(Menu.Questions[2]); 
        Console.WriteLine();
        
        char userChoice = Convert.ToChar(Console.ReadLine()!);

        if (char.ToLower(userChoice) == Menu.Answers[2]) 
        {
            AnswerColor.ColorRightAnswer();
            return 1; 
        }
        else
        {
            AnswerColor.ColorWrongAnswer();
            Console.WriteLine($"The correct answer is option {Menu.Answers[2]}");
            return 0; 
        }
    }
}
