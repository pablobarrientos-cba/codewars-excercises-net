/*
Task
Write a function that returns both the minimum and maximum number of the given list/array.
Examples (Input --> Output)
[1,2,3,4,5] --> [1,5]
[2334454,5] --> [5,2334454]
[1]         --> [1,1]
*/
public static partial class Kata 
{
    public static int[] MinMax(int[] lst) 
    {
        int[] result = new int[2];
        result[0] = lst.Min();
        result[1] = lst.Max();
        return result;
    }

    public static int[] MinMaxBetter(int[] lst) 
    {
        return [lst.Min(), lst.Max()];
    }
}