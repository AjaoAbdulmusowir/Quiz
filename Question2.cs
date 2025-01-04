namespace Quiz;
using System.Text;
public class Question2
{
    public int Question()
    {
        Console.WriteLine("Question 2");
        StringBuilder Question2 = new StringBuilder();
        Question2.AppendLine("In what year was the first Jalsa Qadian held?");
        Question2.AppendLine("(a)1908\n(b)1918\n(c)1891\n(d)1835");
        Console.WriteLine(Question2);
        char userChoice = Convert.ToChar(Console.ReadLine()!);
        switch (char.ToLower(userChoice))
        {
            case 'a':
            case 'b':
            case 'd':
                AnswerColor.ColorWrongAnswer();
                Console.WriteLine("The correct answer is option c");
                return 0;
            case 'c':
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