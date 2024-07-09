/*
Write a function that takes an array of numbers and returns the sum of the numbers. 
The numbers can be negative or non-integer. 
If the array does not contain any numbers then you should return 0.
*/

using System.Linq;
public static partial class Kata
{
  public static double SumArray(double[] array)
  {
    return array.Sum();
  }
}