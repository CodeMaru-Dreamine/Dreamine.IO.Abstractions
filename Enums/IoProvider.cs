namespace Dreamine.IO.Abstractions.Enums;

/// <summary>
/// \if KO
/// <para>런타임 어셈블리를 참조하지 않고 지원되는 산업용 I/O 공급자 제품군을 식별합니다.</para>
/// \endif
/// \if EN
/// <para>Identifies a supported industrial I/O provider family without referencing its runtime assemblies.</para>
/// \endif
/// </summary>
public enum IoProvider
{
    /// <summary>
    /// \if KO
    /// <para>공급자 독립 또는 인메모리 I/O 구현입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A provider-neutral or in-memory I/O implementation.</para>
    /// \endif
    /// </summary>
    Generic = 0,

    /// <summary>
    /// \if KO
    /// <para>Ajinextek AXT 기반 I/O 구현입니다.</para>
    /// \endif
    /// \if EN
    /// <para>An Ajinextek AXT-based I/O implementation.</para>
    /// \endif
    /// </summary>
    Ajin = 1,

    /// <summary>
    /// \if KO
    /// <para>Comizoa 기반 I/O 구현입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A Comizoa-based I/O implementation.</para>
    /// \endif
    /// </summary>
    Comizoa = 2,

    /// <summary>
    /// \if KO
    /// <para>Fastech 기반 I/O 구현입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A Fastech-based I/O implementation.</para>
    /// \endif
    /// </summary>
    Fastech = 3,
}
