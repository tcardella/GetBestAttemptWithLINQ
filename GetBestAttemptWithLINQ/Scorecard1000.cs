namespace GetBestAttemptWithLINQ;

public class Scorecard1000 : BaseScorecard
{
    public Scorecard1000()
    {
        Attempts = LoadAttempts("1000.json");
    }
}