namespace Dreamine.IO.Abstractions.Results;

/// <summary>
/// Represents the result of an industrial I/O operation with a value.
/// </summary>
/// <typeparam name="T">The result value type.</typeparam>
public sealed class IoResult<T> : IoResult
{
    private IoResult(bool isSuccess, T? value, int? errorCode, string? message)
        : base(isSuccess, errorCode, message)
    {
        Value = value;
    }

    /// <summary>
    /// Gets the result value.
    /// </summary>
    public T? Value { get; }

    /// <summary>
    /// Creates a successful I/O result with a value.
    /// </summary>
    /// <param name="value">The result value.</param>
    /// <returns>A successful I/O result.</returns>
    public static IoResult<T> Success(T value)
    {
        return new IoResult<T>(true, value, null, null);
    }

    /// <summary>
    /// Creates a failed I/O result.
    /// </summary>
    /// <param name="message">The failure message.</param>
    /// <param name="errorCode">The optional error code.</param>
    /// <returns>A failed I/O result.</returns>
    public new static IoResult<T> Failure(string message, int? errorCode = null)
    {
        return new IoResult<T>(false, default, errorCode, message);
    }
}
