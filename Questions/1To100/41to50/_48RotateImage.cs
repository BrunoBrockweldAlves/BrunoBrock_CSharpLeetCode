using Helpers.Matrix;

namespace Questions._1To100._41to50;

/// <summary>
/// You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
// You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.
// Example 1:
// Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
// Output: [[7,4,1],[8,5,2],[9,6,3]]
// Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
// Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
/// </summary>

public static class _48RotateImage
{
    public static int[][] Rotate(int[][] matrix)
    {
        var matrixLength = matrix.Length;
        var maxIndex = matrixLength - 1;
        var steps = maxIndex;

        for (var diagonalFactor = 0; diagonalFactor < (maxIndex / 2) + 1; diagonalFactor++)
        {
            for (int j = 0; j < steps; j++)
            {
                var firstPoint = new Coordinate(j + diagonalFactor, maxIndex - diagonalFactor);
                var seccondPoint = new Coordinate(maxIndex - diagonalFactor, maxIndex - j - diagonalFactor);
                var thirdPoint = new Coordinate(maxIndex - j - diagonalFactor, 0 + diagonalFactor);
                var fourthPoint = new Coordinate(0 + diagonalFactor, j + diagonalFactor);

                var pivotA = matrix[firstPoint.Y][firstPoint.X];
                var pivotB = matrix[seccondPoint.Y][seccondPoint.X];
                var pivotC = matrix[thirdPoint.Y][thirdPoint.X];
                var pivotD = matrix[fourthPoint.Y][fourthPoint.X];

                matrix[firstPoint.Y][firstPoint.X] = pivotD;
                matrix[seccondPoint.Y][seccondPoint.X] = pivotA;
                matrix[thirdPoint.Y][thirdPoint.X] = pivotB;
                matrix[fourthPoint.Y][fourthPoint.X] = pivotC;
            }
            steps -= 2;
        }

        matrix.ConsoleLog();
        return matrix;
    }
}

public class Coordinate
{
    public Coordinate(int y, int x)
    {
        Y = y;
        X = x;
    }

    public int X { get; set; }
    public int Y { get; set; }
}