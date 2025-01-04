namespace Quiz;
using System.Text;
public class Question3
{
    public int Question()
    {
        Console.WriteLine("Question 3");
        StringBuilder Question3 = new StringBuilder();
        Question3.AppendLine("How many people attend first Ahmadiyya Jalsa?");
        Question3.AppendLine("(a)108\n(b)118\n(c)101\n(d)100");
        Console.WriteLine(Question3);
        char userChoice = Convert.ToChar(Console.ReadLine()!);
        switch (char.ToLower(userChoice))
        {
            case 'a':
            case 'b':
            case 'c':
                AnswerColor.ColorWrongAnswer();
                Console.WriteLine("The correct answer is option d");
                return 0;
            case 'd':
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