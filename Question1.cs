namespace Quiz;

public class Question1
{
    public int Question()
    {
        Console.WriteLine("Question 1");
        Console.WriteLine("Where was the first Jalsa take place: \n(a)Rabwah\n(b)Pakistan\n(c)Qadian\n(d)Indian");
        Console.WriteLine();
        int score = 0;
        char userChoice = Convert.ToChar(Console.ReadLine()!);
        switch (char.ToLower(userChoice))
        {
            case 'a':
            case 'b':
            case 'd':
                AnswerColor.ColorWrongAnswer();
                Console.WriteLine("The correct answer is option c");
                return score--;
            case 'c':
                AnswerColor.ColorRightAnswer();
                return 1;
            default:
                // Check if the input is null, empty, or consists of only whitespace
                string userChoiceString = userChoice.ToString();
                string nullOrWhiteSpace = string.IsNullOrWhiteSpace(userChoiceString) ? "Wrong input \nRead the instruction" : "Wrong input \nRead the instruction";
                Console.WriteLine(nullOrWhiteSpace);
                return 0;
        }
    }
}