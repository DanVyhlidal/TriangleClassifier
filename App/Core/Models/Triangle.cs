using TriangleClassifier.App.Core.Models.Extensions;

namespace TriangleClassifier.App.Core.Models
{
    public class Triangle
    {
        private readonly SideLengths sides;
        
        public SideLengths Sides => sides;

        private Triangle(SideLengths sides)
        {
            this.sides = sides;
        }

        public static Result<Triangle> Create(SideLengths sides)
        {
            if(!sides.AreAllSidesPositiveNumbers())
                return new Result<Triangle>("All sides need to be positive numbers");

            if (!sides.DoesTriangleInequalityHold())
                return new Result<Triangle>("Triangle inequality does not hold");

            return new Result<Triangle>(new Triangle(sides));
        }
    } 
}