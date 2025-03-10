namespace Questions._401To500._491To500;

/// <summary>
/// Given an m x n matrix mat, return an array of all the elements of the array in a diagonal order.
// Constraints:
// m == mat.length
// n == mat[i].length
// 1 <= m, n <= 104
// 1 <= m * n <= 104
// -105 <= mat[i][j] <= 105
/// </summary>
public static class _498DiagonalTraverse
{
    public static int[] FindDiagonalOrder(int[][] mat)
    {
        if (mat is null || mat.Length == 0 || mat[0].Length == 0)
            return [];

        var maxRowIndex = mat.Length - 1;
        var maxColumnIndex = mat[0].Length - 1;
        var totalCycles = maxRowIndex + maxColumnIndex;
        var up = true;

        int[] result = new int[mat.Length * mat[0].Length];
        var index = 0;

        for (int cycle = 0; cycle <= totalCycles; cycle++)
        {
            if (up)
            {
                for (int row = Math.Min(cycle, maxRowIndex), col = cycle - row; row >= 0 && col <= maxColumnIndex; row--, col = cycle - row)
                {
                    result[index++] = mat[row][col];
                }
            }
            else
            {
                for (int col = Math.Min(cycle, maxColumnIndex), row = cycle - col; col >= 0 && row <= maxRowIndex; col--, row = cycle - col)
                {
                    result[index++] = mat[row][col];
                }
            }
            up = !up;
        }

        return [.. result];
    }
}