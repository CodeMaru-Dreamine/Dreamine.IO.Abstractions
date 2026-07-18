namespace Dreamine.IO.Abstractions.Models;

/// <summary>
/// \if KO
/// <para>모듈 및 채널 주소와 선택적 공학 단위로 식별되는 아날로그 I/O 지점을 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents an analog I/O point identified by module and channel address with an optional engineering unit.</para>
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
/// <param name="Unit">
/// \if KO
/// <para>선택적 공학 단위입니다.</para>
/// \endif
/// \if EN
/// <para>The optional engineering unit.</para>
/// \endif
/// </param>
public readonly record struct AnalogIoPoint(int Module, int Channel, string? Name = null, string? Unit = null);
