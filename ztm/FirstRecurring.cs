/*
Google question
Return the first recurring item in an array of integers
[2,5,3,2,5,6,7,8] should return 2
[2,1,1,2,3,4,3] should return 1
[1,2,3,4] should return -1
*/
public static partial class Kata 
{
    public static int GetFirstRecurring(int [] intArray)
    {
        Dictionary<int, bool> dict = [];

        foreach (int num in intArray) 
        {
            if (dict.ContainsKey(num))  
                {
                    return num;
                }   
            else
                {
                    dict[num] = true;
                }            
        }

        return -1;
    }
}