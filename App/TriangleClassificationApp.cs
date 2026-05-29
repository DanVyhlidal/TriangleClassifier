using TriangleClassifier.App.Core.Models;
using TriangleClassifier.App.Features.Classification;
using TriangleClassifier.App.Features.Classification.Resolvers;
using TriangleClassifier.App.Features.InputSourcing;

namespace TriangleClassifier.App
{
    public class TriangleClassificationApp(IInputSource<Triangle> triangleInputSource)
    {
        private readonly IInputSource<Triangle> triangleInputSource = triangleInputSource;

        private TriangleClassificator? classificator;

        public void Prepare()
        {
            classificator = new TriangleClassificator(new ITriangleTypeResolver[]
            {
                new EquilateralTriangleTypeResolver(),
                new IsoscelesTriangleTypeResolver(),
                new ScaleneTriangleTypeResolver()
            });
        }
        
        public void Run()
        {
            try
            {
                DisplayTitle();
        
                Triangle retrievedTriangle = triangleInputSource.GetInput();
                TriangleType triangleType = classificator!.Classify(retrievedTriangle);
    
                Console.WriteLine($"Triangle with sides [{retrievedTriangle.Sides.A}, {retrievedTriangle.Sides.B}, {retrievedTriangle.Sides.C}] is classified as: [{triangleType}]");
            }
            catch(Exception e)
            {
                // Using e.Message as this get's rid of the stack trace,
                // otherwise if this wouldn't be made for a user, the whole e should be print out to a logger / console
                Console.WriteLine($"Unexpected error occured - {e.Message}");
            }
        }

        private void DisplayTitle()
        {
            Console.WriteLine("Welcome to the Triangle Creator");
            Console.WriteLine(new string('-', 31));
        }
    }
}