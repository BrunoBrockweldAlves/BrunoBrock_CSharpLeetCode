using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

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
        var xAxis = 0;
        var yAxis = 0;
        var up = true;

        for (var i = 0; i < mat.Length; i++)
        {
            if (up)
            {
                for (; xAxis <= i; xAxis++, yAxis++)
                {
                    result.Add(mat[yAxis][yAxis]);
                }
                for (; yAxis > i; yAxis++, xAxis++, yAxis--)
                {
                    result.Add(mat[yAxis - 1][xAxis]);
                }
            }
            else
            {
                for (; xAxis > 0; xAxis--, yAxis++)
                {
                    result.Add(mat[yAxis][yAxis]);
                }
            }
            up = !up;
        }

        return result.ToArray();
    }
}
    [TestClass]
    public class Test
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
            new int[][] { [1,2,3], [4,5,6], [7,8,9] },
            new int[] {1,2,4,7,5,3,6,8,9}
            };
            yield return new object[]
            {
            new int[][] { [1,2], [3,4] },
            new int[] {1,2,3,4}
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public static void ExpectSuccess(int[][] input, int[] output)
        {
            var result = _498DiagonalTraverse.FindDiagonalOrder(input);
            Xunit.Assert.Equal(output, result);
        }
    }
