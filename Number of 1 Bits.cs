// 191. Number of 1 Bits
// Easy
// 5.9K
// 1.2K
// Companies
// Write a function that takes the binary representation of an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).

// Note:

// Note that in some languages, such as Java, there is no unsigned integer type. In this case, the input will be given as a signed integer type. It should not affect your implementation, as the integer's internal binary representation is the same, whether it is signed or unsigned.
// In Java, the compiler represents the signed integers using 2's complement notation. Therefore, in Example 3, the input represents the signed integer. -3.


namespace LeetCodeProblems;
public partial class LCProblems
{
    public int HammingWeight(uint n)
    {
        uint res = 0;
        while (n > 0)
        {
            res += n & 1;
            n = n >> 1;
        }
        return (int)res;
    }

}