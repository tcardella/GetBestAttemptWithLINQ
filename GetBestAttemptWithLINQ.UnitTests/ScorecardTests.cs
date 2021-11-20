using Xunit;

namespace GetBestAttemptWithLINQ.UnitTests;

public class ScorecardTests
{
    public ScorecardTests()
    {
        _sut = new Scorecard();
    }

    private readonly Scorecard _sut;

    [Fact]
    public void AggregateMethodTest()
    {
        var output = _sut.AggregateMethod();

        Assert.Equal(1, output.AttemptEvent);
        Assert.Equal(365, output.Weight);
    }

    [Fact]
    public void MaxByMethodTest()
    {
        var output = _sut.MaxByMethod();

        Assert.Equal(1, output.AttemptEvent);
        Assert.Equal(365, output.Weight);
    }
}