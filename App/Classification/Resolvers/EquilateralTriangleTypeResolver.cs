using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.Classification.Classifiers
{
    public class EquilateralTriangleTypeResolver : ITriangleTypeResolver
    {
        public TriangleType Type => TriangleType.Equilateral;

        public bool IsMatch(Triangle triangle)
        {
            if (triangle == null)
                return false;

            var sides = triangle.Sides;
            return sides.A == sides.B && sides.B == sides.C;
        }
    }
}
