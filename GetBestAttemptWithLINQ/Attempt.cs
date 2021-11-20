public class Attempt
{
    public Attempt(int attemptEvent, decimal weight)
    {
        AttemptEvent = attemptEvent;
        Weight = weight;
    }

    public int AttemptEvent { get; set; }
    public decimal Weight { get; set; }
}