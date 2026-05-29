namespace TriangleClassifier.App.Core
{
    public class Result<T>
        where T : notnull
    {
        public T Value {get; private set; }
        public string Error {get; private set; }
        public bool HasError => !String.IsNullOrEmpty(Error);

        public Result(T value)
        {
            Value = value;
            Error = String.Empty;
        }
        
        public Result(string error)
        {
            Value = default!;
            Error = error;
        }
    }
}