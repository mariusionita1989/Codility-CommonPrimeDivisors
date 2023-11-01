# Codility-CommonPrimeDivisors
A prime is a positive integer X that has exactly two distinct divisors: 1 and X.</br>
The first few prime integers are 2, 3, 5, 7, 11 and 13.</br>
A prime D is called a prime divisor of a positive integer P if there exists a positive integer K such that D * K = P.</br>
For example, 2 and 5 are prime divisors of 20.</br>
You are given two positive integers N and M.</br>
The goal is to check whether the sets of prime divisors of integers N and M are exactly the same.</br>

For example, given:</br>
N = 15 and M = 75, the prime divisors are the same: {3, 5};</br>
N = 10 and M = 30, the prime divisors aren't the same: {2, 5} is not equal to {2, 3, 5};</br>
N = 9 and M = 5, the prime divisors aren't the same: {3} is not equal to {5}.

Write a function:</br>
class Solution { public int solution(int[] A, int[] B); }</br>
that, given two non-empty arrays A and B of Z integers,</br> 
returns the number of positions K for which the prime divisors of A[K] and B[K] are exactly the same.

For example, given:</br>
A[0] = 15   B[0] = 75</br>
A[1] = 10   B[1] = 30</br>
A[2] = 3    B[2] = 5</br>
the function should return 1, because only one pair (15, 75) has the same set of prime divisors.

Write an efficient algorithm for the following assumptions:</br>
Z is an integer within the range [1..6,000];</br>
each element of arrays A and B is an integer within the range [1..2,147,483,647].
