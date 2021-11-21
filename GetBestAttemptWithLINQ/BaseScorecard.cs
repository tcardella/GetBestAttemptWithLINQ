using System.Text.Json;
using BenchmarkDotNet.Attributes;

namespace GetBestAttemptWithLINQ;

public abstract class BaseScorecard
{
    public IEnumerable<Attempt> Attempts { get; set; }

    [Benchmark]
    public Attempt? AggregateMethod()
    {
        return Attempts.Where(a => a.AttemptEvent == 1).Aggregate((x, y) => x.Weight > y.Weight ? x : y);
    }

    [Benchmark]
    public Attempt? MaxByMethod()
    {
        return Attempts.Where(a => a.AttemptEvent == 1).MaxBy(a => a.Weight);
    }

    protected IEnumerable<Attempt> LoadAttempts(string filename)
    {
        var filePath = $"{Environment.CurrentDirectory}\\Data\\{filename}";

        using var openStream = File.OpenRead(filePath);
        var attempts = JsonSerializer.Deserialize<IEnumerable<Attempt>>(openStream);
        openStream.Close();

        return attempts;
    }
}