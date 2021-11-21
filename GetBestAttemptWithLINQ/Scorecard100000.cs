namespace GetBestAttemptWithLINQ;

public class Scorecard100000 : BaseScorecard
{
    public Scorecard100000()
    {
        Attempts = LoadAttempts("100000.json");
    }
}