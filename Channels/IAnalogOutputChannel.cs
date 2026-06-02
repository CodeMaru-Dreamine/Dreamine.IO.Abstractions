using Dreamine.IO.Abstractions.Models;
using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Channels;

/// <summary>
/// Defines vendor-neutral analog output operations.
/// </summary>
public interface IAnalogOutputChannel
{
    /// <summary>
    /// Reads a single analog output point.
    /// </summary>
    /// <param name="point">The analog output point.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The analog output value.</returns>
    Task<IoResult<double>> ReadAsync(AnalogIoPoint point, CancellationToken cancellationToken = default);

    /// <summary>
    /// Writes a single analog output point.
    /// </summary>
    /// <param name="point">The analog output point.</param>
    /// <param name="value">The value to write.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The I/O operation result.</returns>
    Task<IoResult> WriteAsync(AnalogIoPoint point, double value, CancellationToken cancellationToken = default);

    /// <summary>
    /// Writes multiple analog output points.
    /// </summary>
    /// <param name="values">The analog output values keyed by point.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The I/O operation result.</returns>
    Task<IoResult> WriteAsync(IReadOnlyDictionary<AnalogIoPoint, double> values, CancellationToken cancellationToken = default);
}
