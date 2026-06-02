using Dreamine.IO.Abstractions.Models;
using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Channels;

/// <summary>
/// Defines vendor-neutral digital output operations.
/// </summary>
public interface IDigitalOutputChannel
{
    /// <summary>
    /// Reads a single digital output point.
    /// </summary>
    /// <param name="point">The digital output point.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The digital output value.</returns>
    Task<IoResult<bool>> ReadAsync(IoPoint point, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reads multiple digital output points.
    /// </summary>
    /// <param name="points">The digital output points.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The digital output values.</returns>
    Task<IoResult<bool[]>> ReadAsync(IReadOnlyList<IoPoint> points, CancellationToken cancellationToken = default);

    /// <summary>
    /// Writes a single digital output point.
    /// </summary>
    /// <param name="point">The digital output point.</param>
    /// <param name="value">The value to write.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The I/O operation result.</returns>
    Task<IoResult> WriteAsync(IoPoint point, bool value, CancellationToken cancellationToken = default);

    /// <summary>
    /// Writes multiple digital output points.
    /// </summary>
    /// <param name="values">The digital output values keyed by point.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The I/O operation result.</returns>
    Task<IoResult> WriteAsync(IReadOnlyDictionary<IoPoint, bool> values, CancellationToken cancellationToken = default);
}
