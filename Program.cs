using TriangleClassifier.App;
using TriangleClassifier.App.Input;
using TriangleClassifier.App.Models;

{
    IInputProvider<Triangle> triangleInputProvider = args.Length > 0 
        ? new ArgumentInputProvider(args)
        : new InteractiveInputProvider();

    var app = new TriangleClassificationApp(triangleInputProvider);
    app.Prepare();
    app.Run();
}

// Awaiting enter press to not close right away the console window if this program runs through .exe file
Console.WriteLine("Press enter to exit");
Console.ReadLine();