using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.Classification.Classifiers
{
    public class IsoscelesTriangleTypeResolver : ITriangleTypeResolver
    {
        public TriangleType Classification => TriangleType.Isosceles;

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
