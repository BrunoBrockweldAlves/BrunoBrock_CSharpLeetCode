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
                var pivotA = matrix[j + diagonalFactor][maxIndex - diagonalFactor];
                var pivotB = matrix[maxIndex - diagonalFactor][maxIndex - j - diagonalFactor];
                var pivotC = matrix[maxIndex - j - diagonalFactor][0 + diagonalFactor];
                var pivotD = matrix[0 + diagonalFactor][j + diagonalFactor];

                matrix[j + diagonalFactor][maxIndex - diagonalFactor] = pivotD;
                matrix[maxIndex - diagonalFactor][maxIndex - j - diagonalFactor] = pivotA;
                matrix[maxIndex - j - diagonalFactor][0 + diagonalFactor] = pivotB;
                matrix[0 + diagonalFactor][j + diagonalFactor] = pivotC;
            }
            steps -= 2;
        }

        matrix.ConsoleLog();
        return matrix;
    }
}
