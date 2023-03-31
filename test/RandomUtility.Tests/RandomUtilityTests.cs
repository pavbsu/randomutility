using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace RandomUtility.Tests;

public class RandomUtilityTests
{
    [Fact]
    public void GetInt_Called100Times_AllResultsAreDifferent()
    {
        var results = new List<int>();

        for (var _ = 0; _ < 100; _++)
        {
            results.Add(RandomUtility.GetInt());
        }


        results.Distinct().Should().HaveSameCount(results);
    }
}