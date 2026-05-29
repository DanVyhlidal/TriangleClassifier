using TriangleClassifier.App.Core;

namespace TriangleClassifier.App.Features.InputSourcing
{
    public interface IInputSource<T>
    {
        /// <exception cref="InvalidTriangleException">Thrown when a Triangle couldn't be created for any reason specified furthure in a message</exception>
        public T GetInput();
    }
}