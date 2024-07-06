using System.Linq;
/*
In this kata you will create a function that takes a list of non-negative integers and strings 
and returns a new list with the strings filtered out.

Example
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
ListFilterer.GetIntegersFromList(new List<object>(){1, "a", "b", 0, 15}) => {1, 0, 15}
ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b", "aasf", "1", "123", 123}) => {1, 2, 123}
*/

public static partial class Kata
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
        return (from item in listOfItems
                where item is int
                select (int)item).ToList();
   }

   public static IEnumerable<int> GetIntegersFromListBetter(List<object> listOfItems)
   {
      return listOfItems.OfType<int>(); 
   }
}