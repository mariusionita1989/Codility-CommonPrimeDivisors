using Codility_CommonPrimeDivisors;

namespace Codility_CommonPrimeDivisorsTests
{
    public class SolutionTests
    {
        [Fact]
        public void Solution_ShouldReturnCorrectCount_WhenGivenExampleInput()
        {
            // Arrange
            Solution solution = new Solution();
            int[] A = { 15, 10, 3 };
            int[] B = { 75, 30, 5 };

            // Act
            int result = solution.solution(A, B);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Solution_ShouldReturnThree_WhenNoCommonPrimeDivisors()
        {
            // Arrange
            Solution solution = new Solution();
            int[] A = { 7, 11, 13 };
            int[] B = { 9, 15, 21 };

            // Act
            int result = solution.solution(A, B);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Solution_ShouldReturnCountEqualToArrayLength_WhenAllHaveNoCommonPrimeDivisors()
        {
            // Arrange
            Solution solution = new Solution();
            int[] A = { 7, 11, 13 };
            int[] B = { 8, 14, 22 };

            // Act
            int result = solution.solution(A, B);

            // Assert
            Assert.Equal(A.Length, result);
        }

        [Fact]
        public void Solution_ShouldReturnCountEqualToArrayLength_WhenAllHaveSamePrimeDivisors()
        {
            // Arrange
            Solution solution = new Solution();
            int[] A = { 3, 6, 9 };
            int[] B = { 15, 30, 45 };

            // Act
            int result = solution.solution(A, B);

            // Assert
            Assert.Equal(0, result);
        }
    }
}