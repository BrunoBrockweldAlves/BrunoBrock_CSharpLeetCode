using Questions._501To600._541To550;

namespace Tests._501To600._541To550
{
    public class _547NumberOfProvincesTest
    {

        //public static IEnumerable<object[]> TestData()
        //{
        //    return new List<object[]>
        //    {
        //        // Test Case 1: Two clusters (2 provinces)
        //        new object[]
        //        {
        //            new int[][]
        //            {
        //                new int[] {1, 1, 0},
        //                new int[] {1, 1, 0},
        //                new int[] {0, 0, 1}
        //            },
        //            2 // Expected output: 2 provinces
        //        },

        //        // Test Case 2: Each city is isolated (3 provinces)
        //        new object[]
        //        {
        //            new int[][]
        //            {
        //                new int[] {1, 0, 0},
        //                new int[] {0, 1, 0},
        //                new int[] {0, 0, 1}
        //            },
        //            3 // Expected output: 3 provinces
        //        },

        //        // Test Case 3: Fully connected cities (1 province)
        //        new object[]
        //        {
        //            new int[][]
        //            {
        //                new int[] {1, 1, 1},
        //                new int[] {1, 1, 1},
        //                new int[] {1, 1, 1}
        //            },
        //            1 // Expected output: 1 province
        //        },

        //        // Test Case 4: Larger cluster with a single isolated city (2 provinces)
        //        new object[]
        //        {
        //            new int[][]
        //            {
        //                new int[] {1, 1, 0, 0},
        //                new int[] {1, 1, 0, 0},
        //                new int[] {0, 0, 1, 1},
        //                new int[] {0, 0, 1, 1}
        //            },
        //            2 // Expected output: 2 provinces
        //        },

        //        // Test Case 5: Cities connected in a linear chain (1 province)
        //        new object[]
        //        {
        //            new int[][]
        //            {
        //                new int[] {1, 1, 0, 0, 0},
        //                new int[] {1, 1, 1, 0, 0},
        //                new int[] {0, 1, 1, 1, 0},
        //                new int[] {0, 0, 1, 1, 1},
        //                new int[] {0, 0, 0, 1, 1}
        //            },
        //            1 // Expected output: 1 province
        //        },

        //        // Test Case 6: Single city (1 province)
        //        new object[]
        //        {
        //            new int[][]
        //            {
        //                new int[] {1}
        //            },
        //            1 // Expected output: 1 province
        //        },

        //        // Test Case 7: Disconnected pairs (3 provinces)
        //        new object[]
        //        {
        //            new int[][]
        //            {
        //                new int[] {1, 1, 0, 0, 0, 0},
        //                new int[] {1, 1, 0, 0, 0, 0},
        //                new int[] {0, 0, 1, 1, 0, 0},
        //                new int[] {0, 0, 1, 1, 0, 0},
        //                new int[] {0, 0, 0, 0, 1, 1},
        //                new int[] {0, 0, 0, 0, 1, 1}
        //            },
        //            3 // Expected output: 3 provinces
        //        },

        //        // Test Case 8: A fully connected 4-city cluster with one isolated city (2 provinces)
        //        new object[]
        //        {
        //            new int[][]
        //            {
        //                new int[] {1, 1, 1, 1, 0},
        //                new int[] {1, 1, 1, 1, 0},
        //                new int[] {1, 1, 1, 1, 0},
        //                new int[] {1, 1, 1, 1, 0},
        //                new int[] {0, 0, 0, 0, 1}
        //            },
        //            2 // Expected output: 2 provinces
        //        }
        //    };
        //}

        public static IEnumerable<object[]> TestData()
        {
            return new List<object[]>
            {
                // Test Case 1: Two clusters (2 provinces)
                new object[]
                {
                    new int[][]
                    {
                        new int[] {1,1,0,0,0,0,0,1,0,0,0,0,0,0,0},
                        new int[] {1,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        new int[] {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
                        new int[] {0,0,0,1,0,1,1,0,0,0,0,0,0,0,0},
                        new int[] {0,0,0,0,1,0,0,0,0,1,1,0,0,0,0},
                        new int[] {0,0,0,1,0,1,0,0,0,0,1,0,0,0,0},
                        new int[] {0,0,0,1,0,0,1,0,1,0,0,0,0,1,0},
                        new int[] {1,0,0,0,0,0,0,1,1,0,0,0,0,0,0},
                        new int[] {0,0,0,0,0,0,1,1,1,0,0,0,0,1,0},
                        new int[] {0,0,0,0,1,0,0,0,0,1,0,1,0,0,1},
                        new int[] {0,0,0,0,1,1,0,0,0,0,1,1,0,0,0},
                        new int[] {0,0,0,0,0,0,0,0,0,1,1,1,0,0,0},
                        new int[] {0,0,0,0,0,0,0,0,0,0,0,0,1,0,0},
                        new int[] {0,0,0,0,0,0,1,0,1,0,0,0,0,1,0},
                        new int[] {0,0,0,0,0,0,0,0,0,1,0,0,0,0,1}
                    },
                    3 // Expected output: 3 provinces
                }
            };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void Should_Return_Success(int[][] matrix, int expectedResult)
        {
            // Act
            var classResult = _547NumberOfProvinces.FindCircleNum(matrix);

            // Assert
            Assert.Equal(expectedResult, classResult);
        }
    }
}
