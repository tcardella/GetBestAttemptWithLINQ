namespace GetBestAttemptWithLINQ;

public class Scorecard100 : BaseScorecard
{
    public Scorecard100()
    {
        Attempts = LoadAttempts("100.json");
    }
}