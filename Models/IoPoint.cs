namespace Dreamine.IO.Abstractions.Models;

/// <summary>
/// Represents a digital I/O point.
/// </summary>
/// <param name="Module">The module index.</param>
/// <param name="Channel">The channel index.</param>
/// <param name="Name">The optional logical point name.</param>
public readonly record struct IoPoint(int Module, int Channel, string? Name = null);
