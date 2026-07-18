namespace Dreamine.IO.Abstractions.Enums;

/// <summary>
/// \if KO
/// <para>산업용 I/O 컨트롤러의 현재 연결 상태를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents the current industrial I/O controller connection state.</para>
/// \endif
/// </summary>
public enum IoConnectionState
{
    /// <summary>
    /// \if KO
    /// <para>컨트롤러 연결이 끊겨 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>The controller is disconnected.</para>
    /// \endif
    /// </summary>
    Disconnected = 0,

    /// <summary>
    /// \if KO
    /// <para>컨트롤러에 연결 중입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The controller is connecting.</para>
    /// \endif
    /// </summary>
    Connecting = 1,

    /// <summary>
    /// \if KO
    /// <para>컨트롤러가 연결되어 있습니다.</para>
    /// \endif
    /// \if EN
    /// <para>The controller is connected.</para>
    /// \endif
    /// </summary>
    Connected = 2,

    /// <summary>
    /// \if KO
    /// <para>컨트롤러 연결을 해제하는 중입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The controller is disconnecting.</para>
    /// \endif
    /// </summary>
    Disconnecting = 3,

    /// <summary>
    /// \if KO
    /// <para>컨트롤러 연결이 오류 상태입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The controller connection is faulted.</para>
    /// \endif
    /// </summary>
    Faulted = 4,
}
