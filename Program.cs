using TriangleClassifier.App;
using TriangleClassifier.App.InputModes;
using TriangleClassifier.App.Models;

ITriangleInputMode inputMode;

if (args.Length == 3)
{
    if (decimal.TryParse(args[0], out decimal a) &&
        decimal.TryParse(args[1], out decimal b) &&
        decimal.TryParse(args[2], out decimal c))
    {
        inputMode = new ConsoleArgumentInputMode(new SideLengths(a, b, c));
    }
    else
    {
        Console.WriteLine("Invalid input. Falling back to Interactive Input Mode");
        inputMode = new InteractiveInputMode();
    }
}
else
{
    if(args.Length != 0)
        Console.WriteLine("Invalid number of input arguments. Falling back to Interactive Input Mode");
    inputMode = new InteractiveInputMode();
}

var app = new TriangleClassificationApp(inputMode);
app.Prepare();
app.Run();

Console.WriteLine("Press enter to exit");
Console.ReadLine();