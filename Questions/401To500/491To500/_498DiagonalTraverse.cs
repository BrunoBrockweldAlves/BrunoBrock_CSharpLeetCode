namespace Questions._401To500._491To500;

/// <summary>
/// Given an m x n matrix mat, return an array of all the elements of the array in a diagonal order.
// Example 1:
// Input: mat = [[1,2,3],[4,5,6],[7,8,9]]
// Output: [1,2,4,7,5,3,6,8,9]
// Example 2:
// Input: mat = [[1,2],[3,4]]
// Output: [1,2,3,4]
// Constraints:
// m == mat.length
// n == mat[i].length
// 1 <= m, n <= 104
// 1 <= m * n <= 104
// -105 <= mat[i][j] <= 105
/// </summary>
/// 
public static class _498DiagonalTraverse
{
    public static int[] FindDiagonalOrder(int[][] mat)
    {
        var result = new List<int>();
        var cycles = mat.Length * 2 - 1;
        var down = false;
        var maxIndex = mat.Length - 1;
        var minIndex = -maxIndex;
        var minLoop = 0;
        var xAxis = 0;
        var yAxis = 0;

        for (int i = 0; i < cycles; i++)
        {
            if (down)
            {
                yAxis = minIndex > 0? minIndex : 0;
                xAxis = xAxis > maxIndex? maxIndex : xAxis;
                for (; xAxis >= minLoop && xAxis >= minIndex; yAxis++, xAxis--)
                {
                    result.Add(mat[yAxis][xAxis]);
                }
            }
            else
            {
                xAxis = minIndex > 0? minIndex : 0;
                yAxis = yAxis > maxIndex ? maxIndex : yAxis;

                for (; yAxis >= minLoop && yAxis >= minIndex; yAxis--, xAxis++)
                {
                    result.Add(mat[yAxis][xAxis]);
                }

            }
            down = !down;
            minIndex++;
            minLoop = minIndex > 0? minIndex : 0;
        }

        return [.. result];
    }
}