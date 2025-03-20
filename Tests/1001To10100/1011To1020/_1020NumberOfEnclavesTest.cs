
namespace Questions._1001To10100._1011To1020
{
    #region Description
    /// <summary>
    /// You are given an m x n binary matrix grid, where 0 represents a sea cell and 1 represents a land cell.
    //A move consists of walking from one land cell to another adjacent(4-directionally) land cell or walking off the boundary of the grid.
    //Return the number of land cells in grid for which we cannot walk off the boundary of the grid in any number of moves.
    //Constraints:
    //m == grid.length
    //n == grid[i].length
    //1 <= m, n <= 500
    //grid[i][j] is either 0 or 1.
    /// </summary>
    #endregion
    public class _1020NumberOfEnclavesTest
    {
        public static List<object[]> TestData()
        {
            return new() {
                new object[] {
                new int[][] { [0, 0, 0, 0], [1, 0, 1, 0], [0, 1, 1, 0], [0, 0, 0, 0] },
                3
                },
                new object[] {
                new int[][] { [0,1,1,0],[0,0,1,0],[0,0,1,0],[0,0,0,0] },
                0
                },
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Should_Run_With_Success(int[][] grid, int expectedResult)
        {
            var result = _1020NumberOfEnclaves.NumEnclaves(grid);

            Assert.Equal(expectedResult, result);
        }
    }
}