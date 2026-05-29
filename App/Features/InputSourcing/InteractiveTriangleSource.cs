using TriangleClassifier.App.Core;
using TriangleClassifier.App.Core.Models;

namespace TriangleClassifier.App.Features.InputSourcing
{
    public class InteractiveTriangleSource : IInputSource<Triangle>
    {
        public Triangle GetInput()
        {
            SideLengths sides = GetAllTriangleSides();

            var triangleResult = Triangle.Create(sides);
            if (triangleResult.HasError)
                throw new InvalidTriangleException($"Could not create a triangle due to: [{triangleResult.Error}]");
            
            return triangleResult.Value;
        }

        private SideLengths GetAllTriangleSides()
         {
             decimal[] sides = new decimal[3];
             for(int i = 0; i < sides.Length; i++)
             {
                 char currentSideCharacter = (char)('a'+ i);
                 Console.WriteLine($"Please write a lenght of side {currentSideCharacter}");

                 var sideLenghtResult = GetTriangleSide();
                 if (sideLenghtResult.HasError)
                 {
                     i--;
                     Console.WriteLine(sideLenghtResult.Error);
                     continue;
                 }
                 sides[i] = sideLenghtResult.Value;
             }
             
             return new SideLengths(sides[0], sides[1], sides[2]);
         } 

         private Result<decimal> GetTriangleSide()
         {
             string? retrievedSideLength = Console.ReadLine();
             
             bool hasParsedSuccessfully = decimal.TryParse(retrievedSideLength, out decimal convertedSideLength);
             if(!hasParsedSuccessfully)
                 return new Result<decimal>("Invalid input. Please provide a decimal number only");
             
             if(convertedSideLength <= 0)
                 return new Result<decimal>("Invalid input. Please provided a positive decimal number only");
             
             return new Result<decimal>(convertedSideLength);
         }
    }
}