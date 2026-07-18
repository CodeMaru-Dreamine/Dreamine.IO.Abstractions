using Dreamine.IO.Abstractions.Models;
using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Channels;

/// <summary>
/// \if KO
/// <para>공급자 독립적인 아날로그 입력 읽기 작업을 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines provider-neutral analog-input read operations.</para>
/// \endif
/// </summary>
public interface IAnalogInputChannel
{
    /// <summary>
    /// \if KO
    /// <para>단일 아날로그 입력 지점을 비동기적으로 읽습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously reads one analog-input point.</para>
    /// \endif
    /// </summary>
    /// <param name="point">
    /// \if KO
    /// <para>읽을 아날로그 입력 지점입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The analog-input point to read.</para>
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
    /// <para>측정값을 포함하는 I/O 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>An I/O result containing the measured value.</para>
    /// \endif
    /// </returns>
    Task<IoResult<double>> ReadAsync(AnalogIoPoint point, CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>여러 아날로그 입력 지점을 비동기적으로 읽습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously reads multiple analog-input points.</para>
    /// \endif
    /// </summary>
    /// <param name="points">
    /// \if KO
    /// <para>순서대로 읽을 지점 목록입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The ordered list of points to read.</para>
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
    /// <para>요청 순서의 측정값 배열을 포함하는 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A result containing measured values in request order.</para>
    /// \endif
    /// </returns>
    Task<IoResult<double[]>> ReadAsync(IReadOnlyList<AnalogIoPoint> points, CancellationToken cancellationToken = default);
}
