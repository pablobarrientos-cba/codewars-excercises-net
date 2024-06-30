/*
Your task is to make a function that can take any non-negative integer as an argument 
and return it with its digits in descending order. 
Essentially, rearrange the digits to create the highest possible number.

Examples:
Input: 42145 Output: 54421

Input: 145263 Output: 654321

Input: 123456789 Output: 987654321
*/


public static partial class Solution
{
    public static int DoDescendingOrder(int number)
    {
        var myArray = number.ToString().ToCharArray();

        Array.Sort(myArray);
        Array.Reverse(myArray);
        
        var numString = new string(myArray);
        var result = Convert.ToInt32(numString);

        return result;
    }

    public static int DoDescendingOrderBest(int num)
    {
        return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
    }
}