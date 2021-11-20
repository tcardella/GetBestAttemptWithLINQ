using BenchmarkDotNet.Attributes;

namespace GetBestAttemptWithLINQ;

public class Scorecard
{
    public Scorecard()
    {
        Attempts = new List<Attempt?>
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

    public IEnumerable<Attempt?> Attempts { get; set; }

    [Benchmark]
    public Attempt? AggregateMethod() => Attempts.Where(a => a.AttemptEvent == 1).Aggregate((x, y) => x.Weight > y.Weight ? x : y);

    [Benchmark]
    public Attempt? MaxByMethod() => Attempts.Where(a => a.AttemptEvent == 1).MaxBy(a => a.Weight);
}