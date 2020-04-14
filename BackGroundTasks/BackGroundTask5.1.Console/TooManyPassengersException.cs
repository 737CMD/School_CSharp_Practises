public class TooManyPassengersException : System.Exception
{
    public TooManyPassengersException() { }
    public TooManyPassengersException(string message) : base(message) { }
    public TooManyPassengersException(string message, System.Exception inner) : base(message, inner) { }
    protected TooManyPassengersException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}