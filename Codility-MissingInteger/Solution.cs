using System.Runtime.CompilerServices;

namespace Codility_MissingInteger
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                HashSet<int> set = new HashSet<int>();
                // Add all positive integers to a HashSet
                foreach (int num in A)
                {
                    if (num > 0)
                        set.Add(num);
                }

                // Find the smallest positive integer not in the HashSet
                int smallestPositive = 1;
                while (set.Contains(smallestPositive))
                    smallestPositive++;

                return smallestPositive;
            }

            return -1;
        }
    }
}
