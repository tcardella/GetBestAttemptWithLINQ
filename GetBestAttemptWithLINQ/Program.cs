using BenchmarkDotNet.Running;

namespace GetBestAttemptWithLINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        var summaryOriginal = BenchmarkRunner.Run<ScorecardOriginal>();
        var summary10 = BenchmarkRunner.Run<Scorecard10>();
        var summary100 = BenchmarkRunner.Run<Scorecard100>();
        var summary1000 = BenchmarkRunner.Run<Scorecard1000>();
        var summary10000 = BenchmarkRunner.Run<Scorecard10000>();
        var summary100000 = BenchmarkRunner.Run<Scorecard100000>();
        var summary1000000 = BenchmarkRunner.Run<Scorecard1000000>();

    }
}