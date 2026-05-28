using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.Classification.Classifiers
{
    public interface ITriangleClassifier
    {
        TriangleClassifications Classification { get; }
        bool IsMatch(Triangle triangle);
    }
}
