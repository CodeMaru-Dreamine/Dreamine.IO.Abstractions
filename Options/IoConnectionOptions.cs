using Dreamine.IO.Abstractions.Enums;

namespace Dreamine.IO.Abstractions.Options;

/// <summary>
/// Represents provider-neutral industrial I/O connection options.
/// </summary>
public sealed class IoConnectionOptions
{
    /// <summary>
    /// Gets or sets the I/O provider family.
    /// </summary>
    public IoProvider Provider { get; set; } = IoProvider.Generic;

    /// <summary>
    /// Gets or sets the board, device, or controller index.
    /// </summary>
    public int DeviceIndex { get; set; }

    /// <summary>
    /// Gets or sets the optional logical connection name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets provider-specific options that should be interpreted only by the concrete adapter.
    /// </summary>
    public IDictionary<string, string> Properties { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
}
