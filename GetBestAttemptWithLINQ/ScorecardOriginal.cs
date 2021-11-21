namespace GetBestAttemptWithLINQ;

public class ScorecardOriginal : BaseScorecard
{
    public ScorecardOriginal()
    {
        Attempts = new List<Attempt>
        {
            new(1, 300),
            new(1, 320),
            new(1, 365),
            new(2, 200),
            new(2, 225),
            new(2, 230),
            new(4, 322.5m),
            new(4, 350),
            new(4, 375)
        };
    }
}