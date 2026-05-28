using TriangleClassifier.App.Classification.Classifiers;
using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.Classification
{
    public class TriangleClassificator
    {
        private readonly List<ITriangleTypeResolver> classifiers = new();

        public TriangleClassificator()
        {
        }

        public TriangleClassificator(IEnumerable<ITriangleTypeResolver> classifiers)
        {
            foreach (var classifier in classifiers)
            {
                Register(classifier);
            }
        }

        public void Register(ITriangleTypeResolver classifier)
        {
            classifiers.Add(classifier);
        }

        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public TriangleType Classify(Triangle triangle)
        {
            if (triangle == null)
                throw new ArgumentNullException(nameof(triangle));

            foreach (var classifier in classifiers)
            {
                if (classifier.IsMatch(triangle))
                {
                    return classifier.Classification;
                }
            }

            throw new InvalidOperationException("The triangle could not be classified by any registered classifier.");
        }
    }
}
