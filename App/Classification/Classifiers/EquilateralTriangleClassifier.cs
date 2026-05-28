using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.Classification.Classifiers
{
    public class EquilateralTriangleClassifier : ITriangleClassifier
    {
        public TriangleClassifications Classification => TriangleClassifications.Equilateral;

        public bool IsMatch(Triangle triangle)
        {
            if (triangle == null)
                return false;

            var sides = triangle.Sides;
            return sides.A == sides.B && sides.B == sides.C;
        }
    }
}
