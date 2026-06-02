using Dreamine.IO.Abstractions.Models;
using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Channels;

/// <summary>
/// Defines vendor-neutral analog input operations.
/// </summary>
public interface IAnalogInputChannel
{
    /// <summary>
    /// Reads a single analog input point.
    /// </summary>
    /// <param name="point">The analog input point.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The analog input value.</returns>
    Task<IoResult<double>> ReadAsync(AnalogIoPoint point, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reads multiple analog input points.
    /// </summary>
    /// <param name="points">The analog input points.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The analog input values.</returns>
    Task<IoResult<double[]>> ReadAsync(IReadOnlyList<AnalogIoPoint> points, CancellationToken cancellationToken = default);
}
