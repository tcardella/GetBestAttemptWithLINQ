namespace GetBestAttemptWithLINQ;

public class Scorecard10000 : BaseScorecard
{
    public Scorecard10000()
    {
        Attempts = LoadAttempts("10000.json");
    }
}