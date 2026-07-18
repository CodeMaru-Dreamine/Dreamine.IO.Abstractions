using Dreamine.IO.Abstractions.Channels;
using Dreamine.IO.Abstractions.Enums;
using Dreamine.IO.Abstractions.Results;

namespace Dreamine.IO.Abstractions.Controllers;

/// <summary>
/// \if KO
/// <para>연결 생명 주기와 디지털·아날로그 채널을 제공하는 공급자 독립 산업용 I/O 컨트롤러를 정의합니다.</para>
/// \endif
/// \if EN
/// <para>Defines a provider-neutral industrial I/O controller with connection lifecycle and digital and analog channels.</para>
/// \endif
/// </summary>
public interface IIoController : IAsyncDisposable
{
    /// <summary>
    /// \if KO
    /// <para>현재 I/O 연결 상태를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the current I/O connection state.</para>
    /// \endif
    /// </summary>
    IoConnectionState State { get; }

    /// <summary>
    /// \if KO
    /// <para>I/O 연결 상태가 변경되었을 때 발생합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Occurs when the I/O connection state changes.</para>
    /// \endif
    /// </summary>
    event EventHandler<IoConnectionState>? StateChanged;

    /// <summary>
    /// \if KO
    /// <para>디지털 입력 채널을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the digital-input channel.</para>
    /// \endif
    /// </summary>
    IDigitalInputChannel DigitalInputs { get; }

    /// <summary>
    /// \if KO
    /// <para>디지털 출력 채널을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the digital-output channel.</para>
    /// \endif
    /// </summary>
    IDigitalOutputChannel DigitalOutputs { get; }

    /// <summary>
    /// \if KO
    /// <para>아날로그 입력 채널을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the analog-input channel.</para>
    /// \endif
    /// </summary>
    IAnalogInputChannel AnalogInputs { get; }

    /// <summary>
    /// \if KO
    /// <para>아날로그 출력 채널을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the analog-output channel.</para>
    /// \endif
    /// </summary>
    IAnalogOutputChannel AnalogOutputs { get; }

    /// <summary>
    /// \if KO
    /// <para>I/O 컨트롤러에 비동기적으로 연결합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously connects to the I/O controller.</para>
    /// \endif
    /// </summary>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>연결 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to cancel connection.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>연결 작업 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The connection-operation result.</para>
    /// \endif
    /// </returns>
    Task<IoResult> ConnectAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// \if KO
    /// <para>I/O 컨트롤러 연결을 비동기적으로 해제합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Asynchronously disconnects from the I/O controller.</para>
    /// \endif
    /// </summary>
    /// <param name="cancellationToken">
    /// \if KO
    /// <para>연결 해제 취소 토큰입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A token used to cancel disconnection.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>연결 해제 작업 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The disconnection-operation result.</para>
    /// \endif
    /// </returns>
    Task<IoResult> DisconnectAsync(CancellationToken cancellationToken = default);
}
