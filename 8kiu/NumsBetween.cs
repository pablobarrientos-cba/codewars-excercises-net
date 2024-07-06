/*
Complete the function that takes two integers (a, b, where a < b) 
and return an array of all integers between the input parameters, including them.

For example:

a = 1
b = 4
--> [1, 2, 3, 4]
*/

public static partial class Kata {
  public static int[] Between(int a, int b) 
  {
    var list = new List<int>();
    for (int i = a; i <= b; i++)
    {
        list.Add(i);
    }
    return list.ToArray();
  }
}