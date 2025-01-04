namespace Quiz;
using System.Text;
public class Question5
{
    public int Question()
    {
        Console.WriteLine("Question 5");
        StringBuilder Question5 = new StringBuilder();
        Question5.AppendLine("Who won last year African Ballon d'or?");
        Question5.AppendLine("(a)Bukayo Saka\n(b)Victor Osihmen\n(c)Ademola Lukmon\n(d)Muhammed Salah");
        Console.WriteLine(Question5);
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