using Dreamine.IO.Abstractions.Models;

namespace Dreamine.IO.Abstractions.Tests;

public sealed class IoPointTests
{
    [Fact]
    public void DigitalPoint_UsesValueEquality()
    {
        var first = new IoPoint(1, 7, "Door sensor");
        var second = new IoPoint(1, 7, "Door sensor");

        Assert.Equal(second, first);
        Assert.Equal(1, first.Module);
        Assert.Equal(7, first.Channel);
        Assert.Equal("Door sensor", first.Name);
    }

    [Fact]
    public void AnalogPoint_PreservesEngineeringUnit()
    {
        var point = new AnalogIoPoint(3, 4, "Pressure", "bar");

        Assert.Equal(3, point.Module);
        Assert.Equal(4, point.Channel);
        Assert.Equal("Pressure", point.Name);
        Assert.Equal("bar", point.Unit);
    }
}
