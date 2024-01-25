namespace Day02.Tests;
using Day02;
using FluentAssertions;
using Xunit;

public class DivisibleByTest
{
    [Fact]
    public void Return_True_For_3_As_Input_And_3_As_Divisor() 
        => 3.IsDivisibleBy(3).Should().Be(true);

    [Fact]
    public void Return_True_For_4_As_Input_And_3_As_Divisor() 
        => 3.IsDivisibleBy(4).Should().Be(false);

    [Fact]
    public void Return_True_For_0_As_Input_And_AnythingAs_Divisor() 
        => 0.IsDivisibleBy(int.MaxValue).Should().Be(true);
}
