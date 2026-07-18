namespace Dreamine.IO.Abstractions.Results;

/// <summary>
/// \if KO
/// <para>형식화된 값을 포함하는 산업용 I/O 작업 결과를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents an industrial I/O operation result containing a typed value.</para>
/// \endif
/// </summary>
/// <typeparam name="T">
/// \if KO
/// <para>결과 값 형식입니다.</para>
/// \endif
/// \if EN
/// <para>The result value type.</para>
/// \endif
/// </typeparam>
public sealed class IoResult<T> : IoResult
{
    /// <summary>
    /// \if KO
    /// <para>성공 상태, 값 및 선택적 오류 정보로 새 형식화된 결과를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a typed result with success state, value, and optional error information.</para>
    /// \endif
    /// </summary>
    /// <param name="isSuccess">
    /// \if KO
    /// <para>작업 성공 여부입니다.</para>
    /// \endif
    /// \if EN
    /// <para>Whether the operation succeeded.</para>
    /// \endif
    /// </param>
    /// <param name="value">
    /// \if KO
    /// <para>선택적 결과 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The optional result value.</para>
    /// \endif
    /// </param>
    /// <param name="errorCode">
    /// \if KO
    /// <para>선택적 오류 코드입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The optional error code.</para>
    /// \endif
    /// </param>
    /// <param name="message">
    /// \if KO
    /// <para>선택적 결과 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The optional result message.</para>
    /// \endif
    /// </param>
    private IoResult(bool isSuccess, T? value, int? errorCode, string? message)
        : base(isSuccess, errorCode, message)
    {
        Value = value;
    }

    /// <summary>
    /// \if KO
    /// <para>결과 값을 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the result value.</para>
    /// \endif
    /// </summary>
    public T? Value { get; }

    /// <summary>
    /// \if KO
    /// <para>지정한 값을 포함하는 성공 I/O 결과를 만듭니다.</para>
    /// \endif
    /// \if EN
    /// <para>Creates a successful I/O result containing the specified value.</para>
    /// \endif
    /// </summary>
    /// <param name="value">
    /// \if KO
    /// <para>결과 값입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The result value.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>값을 포함하는 성공 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A successful result containing the value.</para>
    /// \endif
    /// </returns>
    public static IoResult<T> Success(T value)
    {
        return new IoResult<T>(true, value, null, null);
    }

    /// <summary>
    /// \if KO
    /// <para>값 없이 메시지와 선택적 오류 코드를 포함하는 실패 결과를 만듭니다.</para>
    /// \endif
    /// \if EN
    /// <para>Creates a failed result without a value and with a message and optional error code.</para>
    /// \endif
    /// </summary>
    /// <param name="message">
    /// \if KO
    /// <para>실패 메시지입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The failure message.</para>
    /// \endif
    /// </param>
    /// <param name="errorCode">
    /// \if KO
    /// <para>선택적 오류 코드입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The optional error code.</para>
    /// \endif
    /// </param>
    /// <returns>
    /// \if KO
    /// <para>형식화된 실패 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A typed failed result.</para>
    /// \endif
    /// </returns>
    public new static IoResult<T> Failure(string message, int? errorCode = null)
    {
        return new IoResult<T>(false, default, errorCode, message);
    }
}
