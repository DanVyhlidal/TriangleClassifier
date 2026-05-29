using TriangleClassifier.App.Core.Models;
using TriangleClassifier.App.Features.Classification.Resolvers;

namespace TriangleClassifier.App.Features.Classification
{
    public class TriangleClassificator
    {
        private readonly List<ITriangleTypeResolver> resolvers = new();

        public TriangleClassificator() { } 

        public TriangleClassificator(IEnumerable<ITriangleTypeResolver> resolvers)
        {
            foreach (var resolver in resolvers)
            {
                Register(resolver);
            }
        }

        public void Register(ITriangleTypeResolver resolver)
        {
            resolvers.Add(resolver);
        }

        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public TriangleType Classify(Triangle triangle)
        {
            if (triangle == null)
                throw new ArgumentNullException(nameof(triangle));

            foreach (var resolver in resolvers)
            {
                if (resolver.IsMatch(triangle))
                    return resolver.Type;
            }

            throw new InvalidOperationException("The triangle could not be classified by any registered classifier.");
        }
    }
}
