namespace Questions;

public static class _59SpiralMatrix
{
    public static int[][] GenerateMatrix(int n)
    {
        var matrix = new int[n, n];

        int leftIndex = 0, rightIndex = n - 1;
        int topIndex = 0, bottomIndex = n - 1;
        int step = 1;
        var pow = Math.Pow(n, n);

        while (step <= pow)
        {
            for (var i = leftIndex; i <= rightIndex; i++, step++)
                matrix[topIndex, i] = step;
            topIndex++;

            for (var i = topIndex; i <= bottomIndex; i++, step++)
                matrix[i, rightIndex] = step;
            rightIndex--;

            for (var i = rightIndex; i >= leftIndex; i--, step++)
                matrix[bottomIndex, i] = step;
            bottomIndex--;


            for (var i = bottomIndex; i >= topIndex; i--, step++)
                matrix[i, leftIndex] = step;
            leftIndex++;
        }


        var result = TwoDimensionToJaggedArray(matrix);
        return result;

        int[][] TwoDimensionToJaggedArray(int[,] input)
        {
            int rows = input.GetLength(0);
            int cols = input.GetLength(1);
            int[][] jaggedArray = new int[rows][];

            // Copy values
            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new int[cols]; // Initialize row
                for (int j = 0; j < cols; j++)
                {
                    jaggedArray[i][j] = input[i, j];
                }
            }

            return jaggedArray;
        }
    }
}