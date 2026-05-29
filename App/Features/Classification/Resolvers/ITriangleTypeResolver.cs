using TriangleClassifier.App.Core.Models;

namespace TriangleClassifier.App.Features.Classification.Resolvers
{
    public interface ITriangleTypeResolver
    {
        TriangleType Type { get; }
        bool IsMatch(Triangle triangle);
    }
}
