using System.Runtime.CompilerServices;

namespace Codility_CommonPrimeDivisors
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 6000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A, int[] B)
        {
            int count = 0;
            int Z = A.Length;
            int Y = B.Length;

            if (Z >= RANGE_LOWEST_VALUE && Z <= RANGE_HIGHEST_VALUE &&
                Y >= RANGE_LOWEST_VALUE && Y <= RANGE_HIGHEST_VALUE)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    int gcd = GCD(A[i],B[i]);
                    if (gcd == 1)
                        count++;
                }
            }

            return count;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private int GCD(int a, int b)
        {
            if (b == 0)
                return a;

            return GCD(b, a % b);
        }
    }
}
