using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.Classification.Classifiers
{
    public interface ITriangleTypeResolver
    {
        TriangleType Type { get; }
        bool IsMatch(Triangle triangle);
    }
}
