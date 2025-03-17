using Questions._301To400._331To340;
using Tests.Models.TestData.Trees;

namespace Tests._301To400._331To340
{
    public class _337HouseRobberIIITest
    {
        public static TheoryData<TreeNodeInputIntOutput> TestData() => [
                new([3,2,3,null,3,null,1], 7),
                new([3,4,5,1,3,null,1], 9)
            ];

        [Theory]
        [MemberData(nameof(TestData))]
        public void Should_Run_With_Success(TreeNodeInputIntOutput data)
        {
            var result = _337HouseRobberIII.Rob(data.Root);

            Assert.Equal(data.Output, result);
        }
    }
}