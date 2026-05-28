using TriangleClassifier.App.Base;

namespace TriangleClassifier.App.InputModes
{
    public interface IInputProvider<T>
    {
        /// <exception cref="InvalidTriangleException">Thrown when a Triangle couldn't be created for any reason specified furthure in a message</exception>
        public T GetInput();
    }
}