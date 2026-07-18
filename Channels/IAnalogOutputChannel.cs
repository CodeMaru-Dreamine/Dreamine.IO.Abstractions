using Dreamine.IO.Abstractions.Models;
using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Channels;

/// <summary>
/// \if KO
/// <para>공급자 독립적인 아날로그 출력 읽기 및 쓰기 작업을 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines provider-neutral analog-output read and write operations.</para>
/// \endif
/// </summary>
public interface IAnalogOutputChannel
{
    /// <summary>
    /// \if KO
    /// <para>단일 아날로그 출력 지점의 현재 값을 읽습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Reads the current value of one analog-output point.</para>
    /// \endif
    /// </summary>
    /// <param name="point">
    /// \if KO
    /// <para>읽을 출력 지점입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The output point to read.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>읽기 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to cancel the read.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>현재 출력 값을 포함하는 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A result containing the current output value.</para>
    /// \endif
    /// </returns>
    Task<IoResult<double>> ReadAsync(AnalogIoPoint point, CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>단일 아날로그 출력 지점에 값을 씁니다.</para>
    /// \endif
    /// \if EN
    /// <para>Writes a value to one analog-output point.</para>
    /// \endif
    /// </summary>
    /// <param name="point">
    /// \if KO
    /// <para>쓸 출력 지점입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The output point to write.</para>
    /// \endif
    /// </param>
    /// <param name="value">
    /// \if KO
    /// <para>출력할 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The value to output.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>쓰기 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to cancel the write.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>쓰기 작업 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The write-operation result.</para>
    /// \endif
    /// </returns>
    Task<IoResult> WriteAsync(AnalogIoPoint point, double value, CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>여러 아날로그 출력 지점에 값을 씁니다.</para>
    /// \endif
    /// \if EN
    /// <para>Writes values to multiple analog-output points.</para>
    /// \endif
    /// </summary>
    /// <param name="values">
    /// \if KO
    /// <para>지점별 출력 값 사전입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The output values keyed by point.</para>
    /// \endif
    /// </param>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>쓰기 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to cancel the write.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>일괄 쓰기 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The batch-write result.</para>
    /// \endif
    /// </returns>
    Task<IoResult> WriteAsync(IReadOnlyDictionary<AnalogIoPoint, double> values, CancellationToken cancellationToken = default);
}
