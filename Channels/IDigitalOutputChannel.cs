using Dreamine.IO.Abstractions.Models;
using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Channels;

/// <summary>
/// \if KO
/// <para>공급자 독립적인 디지털 출력 읽기 및 쓰기 작업을 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines provider-neutral digital-output read and write operations.</para>
/// \endif
/// </summary>
public interface IDigitalOutputChannel
{
    /// <summary>
    /// \if KO
    /// <para>단일 디지털 출력 지점의 현재 상태를 읽습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Reads the current state of one digital-output point.</para>
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
    /// <para>현재 출력 상태를 포함하는 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A result containing the current output state.</para>
    /// \endif
    /// </returns>
    Task<IoResult<bool>> ReadAsync(IoPoint point, CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>여러 디지털 출력 지점의 현재 상태를 읽습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Reads the current states of multiple digital-output points.</para>
    /// \endif
    /// </summary>
    /// <param name="points">
    /// \if KO
    /// <para>순서대로 읽을 출력 지점 목록입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The ordered list of output points to read.</para>
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
    /// <para>요청 순서의 출력 상태 배열을 포함하는 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A result containing output states in request order.</para>
    /// \endif
    /// </returns>
    Task<IoResult<bool[]>> ReadAsync(IReadOnlyList<IoPoint> points, CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>단일 디지털 출력 지점에 상태를 씁니다.</para>
    /// \endif
    /// \if EN
    /// <para>Writes a state to one digital-output point.</para>
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
    /// <para>출력할 상태입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The state to output.</para>
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
    /// <para>쓰기 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The write result.</para>
    /// \endif
    /// </returns>
    Task<IoResult> WriteAsync(IoPoint point, bool value, CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>여러 디지털 출력 지점에 상태를 씁니다.</para>
    /// \endif
    /// \if EN
    /// <para>Writes states to multiple digital-output points.</para>
    /// \endif
    /// </summary>
    /// <param name="values">
    /// \if KO
    /// <para>지점별 출력 상태 사전입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The output states keyed by point.</para>
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
    Task<IoResult> WriteAsync(IReadOnlyDictionary<IoPoint, bool> values, CancellationToken cancellationToken = default);
}
