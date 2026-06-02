namespace Dreamine.IO.Abstractions.Results;

/// <summary>
/// Represents the result of an industrial I/O operation.
/// </summary>
public class IoResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IoResult"/> class.
    /// </summary>
    /// <param name="isSuccess">Whether the operation succeeded.</param>
    /// <param name="errorCode">The optional device or adapter error code.</param>
    /// <param name="message">The optional result message.</param>
    protected IoResult(bool isSuccess, int? errorCode, string? message)
    {
        IsSuccess = isSuccess;
        ErrorCode = errorCode;
        Message = message;
    }

    /// <summary>
    /// Gets whether the operation succeeded.
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// Gets the optional device or adapter error code.
    /// </summary>
    public int? ErrorCode { get; }

    /// <summary>
    /// Gets the optional result message.
    /// </summary>
    public string? Message { get; }

    /// <summary>
    /// Creates a successful I/O result.
    /// </summary>
    /// <returns>A successful I/O result.</returns>
    public static IoResult Success()
    {
        return new IoResult(true, null, null);
    }

    /// <summary>
    /// Creates a failed I/O result.
    /// </summary>
    /// <param name="message">The failure message.</param>
    /// <param name="errorCode">The optional error code.</param>
    /// <returns>A failed I/O result.</returns>
    public static IoResult Failure(string message, int? errorCode = null)
    {
        return new IoResult(false, errorCode, message);
    }
}
