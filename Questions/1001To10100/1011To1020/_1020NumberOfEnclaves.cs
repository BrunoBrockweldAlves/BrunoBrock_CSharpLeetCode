using System.ComponentModel;

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
    public static class _1020NumberOfEnclaves
    {
        public static int NumEnclaves(int[][] grid)
        {
            var visitedGrid = new bool[grid.Length][];
            for (var i = 0; i < grid.Length; i++)
            {
                visitedGrid[i] = new bool[grid[i].Length];
            }

            var notConnectedLands = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1 && !visitedGrid[i][j])
                    {
                        (var lands, var hasOffgridConnection) = FindWholeLand(grid, i, j, visitedGrid);
                        if(!hasOffgridConnection)
                            notConnectedLands += lands;
                    }
                }
            }
            return notConnectedLands;
        }

        private static (int, bool) FindWholeLand(int[][] grid, int i, int j, bool[][] visitedGrid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;

            if (i < 0 || i >= rows || j < 0 || j >= cols || grid[i][j] == 0 || visitedGrid[i][j])
            {
                return (0, false);
            }

            visitedGrid[i][j] = true;
            bool isBoundaryCell = i == 0 || i == rows - 1 || j == 0 || j == cols - 1;
            var lands = 1;
            var hasOffgridConnection = isBoundaryCell;

            var verticalMoves = new int[] { -1, 1, 0, 0 };
            var horizontalMoves = new int[] { 0, 0, -1, 1 };

            for (var move = 0; move < 4; move++)
            {
                var newRow = i + verticalMoves[move];
                var newCol = j + horizontalMoves[move];

                (var nestedLands, var nestedOffgridConnection) = FindWholeLand(grid, newRow, newCol, visitedGrid);
                lands += nestedLands;
                hasOffgridConnection |= nestedOffgridConnection;
            }

            return (lands, hasOffgridConnection);
        }
    }
}