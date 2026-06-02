using Dreamine.IO.Abstractions.Models;
using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Channels;

/// <summary>
/// Defines vendor-neutral digital input operations.
/// </summary>
public interface IDigitalInputChannel
{
    /// <summary>
    /// Reads a single digital input point.
    /// </summary>
    /// <param name="point">The digital input point.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The digital input value.</returns>
    Task<IoResult<bool>> ReadAsync(IoPoint point, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reads multiple digital input points.
    /// </summary>
    /// <param name="points">The digital input points.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The digital input values.</returns>
    Task<IoResult<bool[]>> ReadAsync(IReadOnlyList<IoPoint> points, CancellationToken cancellationToken = default);
}
