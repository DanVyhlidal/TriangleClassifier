using TriangleClassifier.App.Classification;
using TriangleClassifier.App.Classification.Classifiers;
using TriangleClassifier.App.InputModes;
using TriangleClassifier.App.Models;

namespace TriangleClassifier.App
{
    public class TriangleClassificationApp(ITriangleInputMode inputMode)
    {
        private readonly ITriangleInputMode inputMode = inputMode;
        private TriangleClassificator classificator;

        public void Prepare()
        {
            classificator = new TriangleClassificator(new ITriangleClassifier[]
            {
                new EquilateralTriangleClassifier(),
                new IsoscelesTriangleClassifier(),
                new ScaleneTriangleClassifier()
            });
        }
        
        public void Run()
        {
            try
            {
                DisplayTitle();
        
                Triangle retrievedTriangle = inputMode.GetTriangle();
                TriangleClassifications result = classificator.Classify(retrievedTriangle);
    
                Console.WriteLine($"Triangle with sides [{retrievedTriangle.Sides.A}, {retrievedTriangle.Sides.B}, {retrievedTriangle.Sides.C}] is classified as: [{result}]");
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