using System.Runtime.Serialization;
using Exception = System.Exception;

namespace Application;

/// <summary>
/// The ToolBoxException class
/// </summary>
[Serializable]
public class ToolBoxException : Exception
{
    /// <inheritdoc />
    public ToolBoxException()
    {
    }

    /// <inheritdoc />
    public ToolBoxException(string message) : base(message)
    {
    }

    /// <inheritdoc />
    public ToolBoxException(string message, Exception innerException) : base(message, innerException)
    {
    }

    /// <inheritdoc />
    protected ToolBoxException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}

