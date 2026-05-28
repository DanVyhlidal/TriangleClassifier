using TriangleClassifier.App.Models;
using TriangleClassifier.App.Base;

namespace TriangleClassifier.App.InputModes
{
    public interface ITriangleInputMode
    {
        /// <exception cref="InvalidTriangleException">Thrown when a Triangle couldn't be created for any reason specified furthure in a message</exception>
        public Triangle GetTriangle();
    }
}