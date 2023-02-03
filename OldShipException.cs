public class OldShipException : Exception
{
    public OldShipException()
    {
    }

    public OldShipException(string message)
        : base(message)
    {
    }

    public OldShipException(string message, Exception inner)
        : base(message, inner)
    {
    }
}