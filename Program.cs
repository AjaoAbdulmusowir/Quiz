using Quiz;

Menu menu = new Menu();
menu.MainMenu();

Count count = new Count();

Console.WriteLine();
Question1 question1 = new Question1();
count.Question1 = question1.Question();

Console.WriteLine();
Question2 question2 = new Question2();
count.Question2 = question2.Question();

Console.WriteLine();
Question3 question3 = new Question3();
count.Question3 = question3.Question();

Console.WriteLine();
Question4 question4 = new Question4();
count.Question4 = question4.Question();

Console.WriteLine();
Question5 question5 = new Question5();
count.Question5 = question5.Question();

int earnedPoint = count.FinalScore();
int totalPoint = 5;
Console.WriteLine($"\nYour final score is: {earnedPoint}/{totalPoint}");