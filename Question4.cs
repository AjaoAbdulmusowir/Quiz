namespace Quiz;
using System.Text;
public class Question4
{
    public int Question()
    {
        Console.WriteLine("Question 4");
        StringBuilder Question4 = new StringBuilder();
        Question4.AppendLine("Who won the Ballon d'or in the year 2024?");
        Question4.AppendLine("(a)Vinicius Junior\n(b)Rodri\n(c)Ademola Lukmon\n(d)Jude Bellignham");
        Console.WriteLine(Question4);
        char userChoice = Convert.ToChar(Console.ReadLine()!);
        switch (char.ToLower(userChoice))
        {
            case 'a':
            case 'c':
            case 'd':
                AnswerColor.ColorWrongAnswer();
                Console.WriteLine("The correct answer is option b");
                return 0;
            case 'b':
                AnswerColor.ColorRightAnswer();
                return 1;
            default:
                // Check if the input is null, empty, or consists of only whitespace
                string userChoiceString = userChoice.ToString();
                string nullOrWhiteSpace = string.IsNullOrWhiteSpace(userChoiceString) ? "Wrong input \nRead the instruction" : userChoiceString;
                Console.WriteLine(nullOrWhiteSpace);
                return 0;
        }
    }
}
