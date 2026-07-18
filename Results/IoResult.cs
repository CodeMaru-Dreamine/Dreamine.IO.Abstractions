namespace Dreamine.IO.Abstractions.Results;

/// <summary>
/// \if KO
/// <para>성공 여부와 선택적 오류 정보를 포함하는 산업용 I/O 작업 결과를 나타냅니다.</para>
/// \endif
/// \if EN
/// <para>Represents an industrial I/O operation result containing success state and optional error information.</para>
/// \endif
/// </summary>
public class IoResult
{
    /// <summary>
    /// \if KO
    /// <para>성공 상태와 선택적 오류 정보로 새 결과를 초기화합니다.</para>
    /// \endif
    /// \if EN
    /// <para>Initializes a new result with success state and optional error information.</para>
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
    /// <param name="errorCode">
    /// \if KO
    /// <para>선택적 장치 또는 어댑터 오류 코드입니다.</para>
    /// \endif
    /// \if EN
    /// <para>The optional device or adapter error code.</para>
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
    protected IoResult(bool isSuccess, int? errorCode, string? message)
    {
        IsSuccess = isSuccess;
        ErrorCode = errorCode;
        Message = message;
    }

    /// <summary>
    /// \if KO
    /// <para>작업 성공 여부를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets whether the operation succeeded.</para>
    /// \endif
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// \if KO
    /// <para>선택적 장치 또는 어댑터 오류 코드를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the optional device or adapter error code.</para>
    /// \endif
    /// </summary>
    public int? ErrorCode { get; }

    /// <summary>
    /// \if KO
    /// <para>선택적 결과 메시지를 가져옵니다.</para>
    /// \endif
    /// \if EN
    /// <para>Gets the optional result message.</para>
    /// \endif
    /// </summary>
    public string? Message { get; }

    /// <summary>
    /// \if KO
    /// <para>값이 없는 성공 I/O 결과를 만듭니다.</para>
    /// \endif
    /// \if EN
    /// <para>Creates a successful I/O result without a value.</para>
    /// \endif
    /// </summary>
    /// <returns>
    /// \if KO
    /// <para>성공 I/O 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A successful I/O result.</para>
    /// \endif
    /// </returns>
    public static IoResult Success()
    {
        return new IoResult(true, null, null);
    }

    /// <summary>
    /// \if KO
    /// <para>메시지와 선택적 오류 코드를 포함하는 실패 I/O 결과를 만듭니다.</para>
    /// \endif
    /// \if EN
    /// <para>Creates a failed I/O result with a message and optional error code.</para>
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
    /// <para>실패 I/O 결과입니다.</para>
    /// \endif
    /// \if EN
    /// <para>A failed I/O result.</para>
    /// \endif
    /// </returns>
    public static IoResult Failure(string message, int? errorCode = null)
    {
        return new IoResult(false, errorCode, message);
    }
}
