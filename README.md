# Triangle Classifier

A C# console application that classifies triangles based on the lengths of their three sides. It determines whether a triangle is Equilateral, Isosceles, or Scalene.

## How to Run

There are two ways to run the application:

### 1. Command Line Arguments Mode
You can pass the three side lengths directly as arguments when starting the application. 

```bash
dotnet run -- <a> <b> <c>
```

**Example:**
```bash
dotnet run -- 5 5 8
```

#### Error Handling
If you attempt to run the application with command line arguments but provide invalid inputs (non-numeric values or the wrong number of arguments), the application will exit with an error message.

### 2. Interactive Mode (No Arguments)
Run the application without any arguments to start interactive mode. The application will prompt you to enter the lengths of the three sides one by one.

```bash
dotnet run
```
