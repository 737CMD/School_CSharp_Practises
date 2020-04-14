public class TooHeavyCargoException : System.Exception
{
    public TooHeavyCargoException() { }
    public TooHeavyCargoException(string message) : base(message) { }
    public TooHeavyCargoException(string message, System.Exception inner) : base(message, inner) { }
    protected TooHeavyCargoException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}