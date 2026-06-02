namespace Dreamine.IO.Abstractions.Enums;

/// <summary>
/// Represents the current industrial I/O connection state.
/// </summary>
public enum IoConnectionState
{
    /// <summary>
    /// The controller is disconnected.
    /// </summary>
    Disconnected = 0,

    /// <summary>
    /// The controller is connecting.
    /// </summary>
    Connecting = 1,

    /// <summary>
    /// The controller is connected.
    /// </summary>
    Connected = 2,

    /// <summary>
    /// The controller is disconnecting.
    /// </summary>
    Disconnecting = 3,

    /// <summary>
    /// The controller is in a faulted state.
    /// </summary>
    Faulted = 4,
}
