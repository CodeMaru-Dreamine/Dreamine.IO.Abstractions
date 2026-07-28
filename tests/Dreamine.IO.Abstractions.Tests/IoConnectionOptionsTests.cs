using Dreamine.IO.Abstractions.Enums;
using Dreamine.IO.Abstractions.Options;

namespace Dreamine.IO.Abstractions.Tests;

public sealed class IoConnectionOptionsTests
{
    [Fact]
    public void Defaults_AreProviderNeutral()
    {
        var options = new IoConnectionOptions();

        Assert.Equal(IoProvider.Generic, options.Provider);
        Assert.Equal(0, options.DeviceIndex);
        Assert.Null(options.Name);
        Assert.Empty(options.Properties);
    }

    [Fact]
    public void Properties_AreCaseInsensitive()
    {
        var options = new IoConnectionOptions();

        options.Properties["Address"] = "192.0.2.1";

        Assert.Equal("192.0.2.1", options.Properties["address"]);
        Assert.False(options.Properties.TryAdd("ADDRESS", "duplicate"));
    }

    [Fact]
    public void Values_CanDescribeAConcreteAdapter()
    {
        var options = new IoConnectionOptions
        {
            Provider = IoProvider.Fastech,
            DeviceIndex = 2,
            Name = "Assembly cell"
        };

        Assert.Equal(IoProvider.Fastech, options.Provider);
        Assert.Equal(2, options.DeviceIndex);
        Assert.Equal("Assembly cell", options.Name);
    }
}
