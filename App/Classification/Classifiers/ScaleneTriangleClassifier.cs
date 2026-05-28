using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.Classification.Classifiers
{
    public class ScaleneTriangleClassifier : ITriangleClassifier
    {
        public TriangleClassifications Classification => TriangleClassifications.Scalene;

        public bool IsMatch(Triangle triangle)
        {
            if (triangle == null)
                return false;

            var sides = triangle.Sides;
            return sides.A != sides.B && sides.B != sides.C && sides.A != sides.C;
        }
    }
}
