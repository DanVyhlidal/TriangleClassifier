using TriangleClassifier.App.Core.Models;

namespace TriangleClassifier.App.Features.Classification.Resolvers
{
    public class IsoscelesTriangleTypeResolver : ITriangleTypeResolver
    {
        public TriangleType Type => TriangleType.Isosceles;

        public bool IsMatch(Triangle triangle)
        {
            if (triangle == null)
                return false;

            var sides = triangle.Sides;
            return (sides.A == sides.B || sides.B == sides.C || sides.A == sides.C) && 
                   !(sides.A == sides.B && sides.B == sides.C);
        }
    }
}
