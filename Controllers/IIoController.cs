using Dreamine.IO.Abstractions.Channels;
using Dreamine.IO.Abstractions.Enums;
using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Controllers;

/// <summary>
/// Defines a vendor-neutral industrial I/O controller.
/// </summary>
public interface IIoController : IAsyncDisposable
{
    /// <summary>
    /// Gets the current I/O connection state.
    /// </summary>
    IoConnectionState State { get; }

    /// <summary>
    /// Occurs when the I/O connection state changes.
    /// </summary>
    event EventHandler<IoConnectionState>? StateChanged;

    /// <summary>
    /// Gets the digital input channel.
    /// </summary>
    IDigitalInputChannel DigitalInputs { get; }

    /// <summary>
    /// Gets the digital output channel.
    /// </summary>
    IDigitalOutputChannel DigitalOutputs { get; }

    /// <summary>
    /// Gets the analog input channel.
    /// </summary>
    IAnalogInputChannel AnalogInputs { get; }

    /// <summary>
    /// Gets the analog output channel.
    /// </summary>
    IAnalogOutputChannel AnalogOutputs { get; }

    /// <summary>
    /// Connects to the I/O controller.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The I/O operation result.</returns>
    Task<IoResult> ConnectAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Disconnects from the I/O controller.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The I/O operation result.</returns>
    Task<IoResult> DisconnectAsync(CancellationToken cancellationToken = default);
}
