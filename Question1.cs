namespace Quiz;

public class Question1
{
    public int Question()
    {
        Console.WriteLine(Menu.Questions[1]); // Access Question 1
        Console.WriteLine();
        
        char userChoice = Convert.ToChar(Console.ReadLine()!);

        if (char.ToLower(userChoice) == Menu.Answers[1]) // Compare the answer
        {
            AnswerColor.ColorRightAnswer();
            return 1; // Correct answer
        }
        else
        {
            AnswerColor.ColorWrongAnswer();
            Console.WriteLine($"The correct answer is option {Menu.Answers[1]}");
            return 0; // Wrong answer
        }
    }
}
