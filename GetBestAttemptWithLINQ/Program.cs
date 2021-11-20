using BenchmarkDotNet.Running;

namespace GetBestAttemptWithLINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        var scorecard = new Scorecard();

        var summary = BenchmarkRunner.Run<Scorecard>();
    }
}