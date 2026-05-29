using TriangleClassifier.App;
using TriangleClassifier.App.Core.Models;
using TriangleClassifier.App.Features.InputSourcing;

{
    IInputSource<Triangle> triangleInputSource = args.Length > 0 
        ? new LaunchArgsTriangleSource(args)
        : new InteractiveTriangleSource();

    var app = new TriangleClassificationApp(triangleInputSource);
    app.Prepare();
    app.Run();
}

// Awaiting enter press to not close right away the console window if this program runs through .exe file
Console.WriteLine("Press enter to exit");
Console.ReadLine();