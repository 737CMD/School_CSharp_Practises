class PacmanEaten : System.Exception{
    public PacmanEaten() { }
    public PacmanEaten(string message) : base(message) { }
    public PacmanEaten(string message, System.Exception inner) : base(message, inner) { }
    protected PacmanEaten(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}