using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Tests;

public sealed class IoResultTests
{
    [Fact]
    public void Success_HasNoFailureMetadata()
    {
        var result = IoResult.Success();

        Assert.True(result.IsSuccess);
        Assert.Null(result.ErrorCode);
        Assert.Null(result.Message);
    }

    [Fact]
    public void Failure_PreservesMessageAndErrorCode()
    {
        var result = IoResult.Failure("Device unavailable", 503);

        Assert.False(result.IsSuccess);
        Assert.Equal(503, result.ErrorCode);
        Assert.Equal("Device unavailable", result.Message);
    }

    [Fact]
    public void GenericSuccess_PreservesValue()
    {
        var result = IoResult<double>.Success(12.5);

        Assert.True(result.IsSuccess);
        Assert.Equal(12.5, result.Value);
        Assert.Null(result.ErrorCode);
        Assert.Null(result.Message);
    }

    [Fact]
    public void GenericFailure_HasDefaultValueAndFailureMetadata()
    {
        var result = IoResult<bool>.Failure("Read failed", 42);

        Assert.False(result.IsSuccess);
        Assert.False(result.Value);
        Assert.Equal(42, result.ErrorCode);
        Assert.Equal("Read failed", result.Message);
    }
}
