namespace Dreamine.IO.Abstractions.Enums;

/// <summary>
/// Identifies a supported industrial I/O provider family without referencing its runtime assemblies.
/// </summary>
public enum IoProvider
{
    /// <summary>
    /// A provider-neutral or in-memory I/O implementation.
    /// </summary>
    Generic = 0,

    /// <summary>
    /// Ajinextek AXT based I/O implementation.
    /// </summary>
    Ajin = 1,

    /// <summary>
    /// Comizoa based I/O implementation.
    /// </summary>
    Comizoa = 2,

    /// <summary>
    /// Fastech based I/O implementation.
    /// </summary>
    Fastech = 3,
}
