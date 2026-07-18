using Dreamine.IO.Abstractions.Models;
using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Channels;

/// <summary>
/// \if KO
/// <para>공급자 독립적인 디지털 입력 읽기 작업을 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines provider-neutral digital-input read operations.</para>
/// \endif
/// </summary>
public interface IDigitalInputChannel
{
    /// <summary>
    /// \if KO
    /// <para>단일 디지털 입력 지점을 비동기적으로 읽습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously reads one digital-input point.</para>
    /// \endif
    /// </summary>
    /// <param name="point">
    /// \if KO
    /// <para>읽을 디지털 입력 지점입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The digital-input point to read.</para>
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
    /// <para>입력 상태를 포함하는 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A result containing the input state.</para>
    /// \endif
    /// </returns>
    Task<IoResult<bool>> ReadAsync(IoPoint point, CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>여러 디지털 입력 지점을 비동기적으로 읽습니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously reads multiple digital-input points.</para>
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
    /// <para>요청 순서의 입력 상태 배열을 포함하는 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A result containing input states in request order.</para>
    /// \endif
    /// </returns>
    Task<IoResult<bool[]>> ReadAsync(IReadOnlyList<IoPoint> points, CancellationToken cancellationToken = default);
}
