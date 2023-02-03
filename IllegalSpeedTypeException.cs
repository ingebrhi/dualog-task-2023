public class IllegalSpeedTypeException : Exception
{
    public IllegalSpeedTypeException()
    {
    }

    public IllegalSpeedTypeException(string message)
        : base(message)
    {
    }

    public IllegalSpeedTypeException(string message, Exception inner)
        : base(message, inner)
    {
    }
}