using Quiz;

Menu menu = new Menu();
menu.MainMenu();

Score score = new Score();

Console.WriteLine();
Question1 question1 = new Question1();
score.Question1 = question1.Question();

Console.WriteLine();
Question2 question2 = new Question2();
score.Question2 = question2.Question();

Console.WriteLine();
Question3 question3 = new Question3();
score.Question3 = question3.Question();

Console.WriteLine();
Question4 question4 = new Question4();
score.Question4 = question4.Question();

Console.WriteLine();
Question5 question5 = new Question5();
score.Question5 = question5.Question();

int earnedPoint = score.FinalScore();
int totalPoint = 5;
Console.WriteLine($"\nYour final score is: {earnedPoint}/{totalPoint}");