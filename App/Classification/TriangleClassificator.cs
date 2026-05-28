using TriangleClassifier.App.Classification.Classifiers;
using TriangleClassifier.App.Models;

namespace TriangleClassifier.App.Classification
{
    public class TriangleClassificator
    {
        private readonly List<ITriangleClassifier> classifiers = new();

        public TriangleClassificator()
        {
        }

        public TriangleClassificator(IEnumerable<ITriangleClassifier> classifiers)
        {
            foreach (var classifier in classifiers)
            {
                Register(classifier);
            }
        }

        public void Register(ITriangleClassifier classifier)
        {
            classifiers.Add(classifier);
        }

        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public TriangleClassifications Classify(Triangle triangle)
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
