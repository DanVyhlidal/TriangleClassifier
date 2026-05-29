using TriangleClassifier.App.Core.Models;

namespace TriangleClassifier.App.Features.Classification.Resolvers
{
    public class ScaleneTriangleTypeResolver : ITriangleTypeResolver
    {
        public TriangleType Type => TriangleType.Scalene;

        public bool IsMatch(Triangle triangle)
        {
            if (triangle == null)
                return false;

            var sides = triangle.Sides;
            return sides.A != sides.B && sides.B != sides.C && sides.A != sides.C;
        }
    }
}
