namespace Quiz;

public class Question5
{
    public int Question()
    {
        Console.WriteLine(Menu.Questions[5]); 
        Console.WriteLine();
        
        char userChoice = Convert.ToChar(Console.ReadLine()!);

        if (char.ToLower(userChoice) == Menu.Answers[5]) 
        {
            AnswerColor.ColorRightAnswer();
            return 1; 
        }
        else
        {
            AnswerColor.ColorWrongAnswer();
            Console.WriteLine($"The correct answer is option {Menu.Answers[5]}");
            return 0; 
        }
    }
}
