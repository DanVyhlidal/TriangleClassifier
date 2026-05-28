using TriangleClassifier.App.Base;
using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.InputModes
{
    public class ConsoleArgumentInputMode : ITriangleInputMode
    {
        private readonly Result<Triangle> triangleResult;

        public ConsoleArgumentInputMode(SideLengths sideLengths)
        {
            triangleResult = Triangle.Create(sideLengths);
        }

        public Triangle GetTriangle()
        {
            if (triangleResult.HasError)
                throw new InvalidTriangleException($"Could not create a triangle due to: [{triangleResult.Error}]");
            
            var triangle = triangleResult.Value;
            
            return triangle;
        }
    }
}