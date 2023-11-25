using Codility_MissingInteger;

namespace Codility_MissingIntegerTests
{
    public class SolutionTests
    {
        [Fact]
        public void Test_Solution_Example1()
        {
            Solution sol = new Solution();
            int[] arr = { 1, 3, 6, 4, 1, 2 };
            int expected = 5;
            int result = sol.solution(arr);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_Example2()
        {
            Solution sol = new Solution();
            int[] arr = { 1, 2, 3 };
            int expected = 4;
            int result = sol.solution(arr);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_Example3()
        {
            Solution sol = new Solution();
            int[] arr = { -1, -3 };
            int expected = 1;
            int result = sol.solution(arr);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_EmptyArray()
        {
            Solution sol = new Solution();
            int[] arr = { };
            int expected = -1;
            int result = sol.solution(arr);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_AllNegatives()
        {
            Solution sol = new Solution();
            int[] arr = { -5, -7, -2, -1 };
            int expected = 1;
            int result = sol.solution(arr);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_PositiveSequence()
        {
            Solution sol = new Solution();
            int[] arr = { 1, 2, 3, 4, 5 };
            int expected = 6;
            int result = sol.solution(arr);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_LargeInput()
        {
            Solution sol = new Solution();
            int[] arr = new int[100000];
            for (int i = 0; i < 99999; i++)
            {
                arr[i] = i + 1;
            }
            int expected = 100000;
            int result = sol.solution(arr);
            Assert.Equal(expected, result);
        }
    }
}