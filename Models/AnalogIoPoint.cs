namespace Dreamine.IO.Abstractions.Models;

/// <summary>
/// Represents an analog I/O point.
/// </summary>
/// <param name="Module">The module index.</param>
/// <param name="Channel">The channel index.</param>
/// <param name="Name">The optional logical point name.</param>
/// <param name="Unit">The optional engineering unit.</param>
public readonly record struct AnalogIoPoint(int Module, int Channel, string? Name = null, string? Unit = null);
