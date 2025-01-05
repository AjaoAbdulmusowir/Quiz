public class Score
{
    public int Question1 { get; set; }
    public int Question2 { get; set; }
    public int Question3 { get; set; }
    public int Question4 { get; set; }
    public int Question5 { get; set; }

    public int FinalScore()
    {
        return Question1 + Question2 + Question3 + Question4 + Question5;
    }
}
