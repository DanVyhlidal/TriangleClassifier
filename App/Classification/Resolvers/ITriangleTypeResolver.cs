using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.Classification.Classifiers
{
    public interface ITriangleTypeResolver
    {
        TriangleType Classification { get; }
        bool IsMatch(Triangle triangle);
    }
}
