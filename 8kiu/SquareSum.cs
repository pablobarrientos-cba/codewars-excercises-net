/*
Complete the square sum function so that it squares each number passed into it 
and then sums the results together.

For example, for [1, 2, 2] it should return 9 because 
*/

using System.Linq;

public static partial class Kata
{
    public static int SquareSum(int[] numbers)
    {
        return numbers.Sum(x => x * x);
    }
}