
using Questions;

Console.WriteLine("Hello, World!");

var input = 3;

var result = _59SpiralMatrix.GenerateMatrix(input);
string stringResult = string.Join("\n", result
            .Select(row => "[" + string.Join(", ", row) + "]"));

Console.WriteLine($"Result: {stringResult}");
