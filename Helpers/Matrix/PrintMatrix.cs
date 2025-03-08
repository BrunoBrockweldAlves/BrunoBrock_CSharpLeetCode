namespace Helpers.Matrix;

public static class PrintMatrix
{
    public static void ConsoleLog(this int[][] array)
    {
        string stringResult = string.Join("\n", array
            .Select(row => "[" + string.Join(", ", row) + "]"));

        Console.WriteLine("Result:\r\n"
                        +$"{stringResult}");

    } 
}
