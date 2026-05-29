using TriangleClassifier.App.Base;
using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.Input
{
    public class ArgumentInputProvider : IInputProvider<Triangle>
    {
        private readonly Result<Triangle> triangleResult;

        public ArgumentInputProvider(string[] args)
        {
            triangleResult = ParseArgsToTriangle(args);
        }

        public Triangle GetInput()
        {
            if (triangleResult.HasError)
                throw new InvalidTriangleException($"Could not create a triangle due to: [{triangleResult.Error}]");
            
            var triangle = triangleResult.Value;
            
            return triangle;
        }
        
        private Result<Triangle> ParseArgsToTriangle(string[] args)
        {
            if(args.Length != 3)
                return new Result<Triangle>("Invalid input. Please provide 3 decimal numbers as input");

            if (decimal.TryParse(args[0], out decimal a) &&
                decimal.TryParse(args[1], out decimal b) &&
                decimal.TryParse(args[2], out decimal c))
            {
                return Triangle.Create(new SideLengths(a,b,c));
            }

            return new Result<Triangle>("Invalid input. Please provide 3 decimal numbers as input");
        }
    }
}