using Questions._401To500._491To500;

namespace Tests._401To500._491To500;

public class _498DiagonalTraverseTest
{
    public static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
           new int[][] { [2,5],[8,4],[0,-1] },
           new int[] {2,5,8,0,4,-1}
        };
        yield return new object[]
        {
           new int[][] { [3], [2] },
           new int[] {3,2}
        };
        yield return new object[]
        {
            new int[][] { [2,3] },
            new int[] {2,3}
        };
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
        Assert.Equal(output, result);
    }
}
