namespace GetBestAttemptWithLINQ;

public class Scorecard1000000 : BaseScorecard
{
    public Scorecard1000000()
    {
        Attempts = LoadAttempts("1000000.json");
    }
}