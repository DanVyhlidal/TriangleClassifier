namespace TriangleClassifier.App.Core
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException()
            : base("Couldn't create a triangle based on the input sides.") { }

        public InvalidTriangleException(string message)
            : base(message) { }

        public InvalidTriangleException(string message, Exception inner)
            : base(message, inner) { }
    }
}