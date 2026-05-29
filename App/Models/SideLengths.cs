namespace TriangleClassifier.App.Models
{
    namespace Extensions
    {
        public static class SideLenghtsExtensions
        {
            public static bool DoesTriangleInequalityHold(this SideLengths sideLengths) => 
                sideLengths.A + sideLengths.B > sideLengths.C &&
                sideLengths.B + sideLengths.C > sideLengths.A &&
                sideLengths.A + sideLengths.C > sideLengths.B;
            
            public static bool AreAllSidesPositiveNumbers(this SideLengths sideLengths) =>
                sideLengths.A > 0 &&
                sideLengths.B > 0 &&
                sideLengths.C > 0;
        }
    }

    public readonly record struct SideLengths(decimal A, decimal B, decimal C);
}