using Dreamine.IO.Abstractions.Enums;

namespace Dreamine.IO.Abstractions.Options;

/// <summary>
/// \if KO
/// <para>공급자 독립적인 산업용 I/O 연결 옵션을 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents provider-neutral industrial I/O connection options.</para>
/// \endif
/// </summary>
public sealed class IoConnectionOptions
{
    /// <summary>
    /// \if KO
    /// <para>I/O 공급자 제품군을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the I/O provider family.</para>
    /// \endif
    /// </summary>
    public IoProvider Provider { get; set; } = IoProvider.Generic;

    /// <summary>
    /// \if KO
    /// <para>보드, 장치 또는 컨트롤러 인덱스를 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the board, device, or controller index.</para>
    /// \endif
    /// </summary>
    public int DeviceIndex { get; set; }

    /// <summary>
    /// \if KO
    /// <para>선택적 논리 연결 이름을 가져오거나 설정합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets or sets the optional logical connection name.</para>
    /// \endif
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// \if KO
    /// <para>구체 어댑터만 해석해야 하는 공급자별 옵션 사전을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets provider-specific options interpreted only by the concrete adapter.</para>
    /// \endif
    /// </summary>
    public IDictionary<string, string> Properties { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
}
