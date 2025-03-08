namespace Questions;

public static class _59SpiralMatrix
{
    public static int[][] GenerateMatrix(int n)
    {
        var matrix = new List<int[]>();
        for(var i = 0; i < n; i++)
        {
            matrix.Add(new int[n]);
        }

        int leftIndex = 0, rightIndex = n - 1;
        int topIndex = 0, bottomIndex = n - 1;
        int step = 1;
        var pow = Math.Pow(n, 2);

        while (step <= pow)
        {
            for (var i = leftIndex; i <= rightIndex; i++, step++)
                matrix[topIndex][i] = step;
            topIndex++;

            for (var i = topIndex; i <= bottomIndex; i++, step++)
                matrix[i][rightIndex] = step;
            rightIndex--;

            for (var i = rightIndex; i >= leftIndex; i--, step++)
                matrix[bottomIndex][i] = step;
            bottomIndex--;


            for (var i = bottomIndex; i >= topIndex; i--, step++)
                matrix[i][leftIndex] = step;
            leftIndex++;
        }

        return matrix.ToArray();
    }
}