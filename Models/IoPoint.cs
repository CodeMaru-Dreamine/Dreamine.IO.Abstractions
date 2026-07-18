namespace Dreamine.IO.Abstractions.Models;

/// <summary>
/// \if KO
/// <para>모듈 및 채널 주소로 식별되는 디지털 I/O 지점을 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents a digital I/O point identified by module and channel address.</para>
/// \endif
/// </summary>
/// <param name="Module">
/// \if KO
/// <para>모듈 인덱스입니다.</para>
/// \endif
/// \if EN
/// <para>The module index.</para>
/// \endif
/// </param>
/// <param name="Channel">
/// \if KO
/// <para>채널 인덱스입니다.</para>
/// \endif
/// \if EN
/// <para>The channel index.</para>
/// \endif
/// </param>
/// <param name="Name">
/// \if KO
/// <para>선택적 논리 지점 이름입니다.</para>
/// \endif
/// \if EN
/// <para>The optional logical point name.</para>
/// \endif
/// </param>
public readonly record struct IoPoint(int Module, int Channel, string? Name = null);
