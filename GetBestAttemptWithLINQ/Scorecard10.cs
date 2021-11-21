namespace GetBestAttemptWithLINQ;

public class Scorecard10 : BaseScorecard
{
    public Scorecard10()
    {
        Attempts = LoadAttempts("10.json");
    }
}