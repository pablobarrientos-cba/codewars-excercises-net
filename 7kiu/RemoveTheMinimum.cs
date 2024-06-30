/*
You are going to be given a word. 
Your job is to return the middle character of the word. 
If the word's length is odd, return the middle character. 
If the word's length is even, return the middle 2 characters.

Examples
Kata.getMiddle("test") should return "es"

Kata.getMiddle("testing") should return "t"

Kata.getMiddle("middle") should return "dd"

Kata.getMiddle("A") should return "A"
*/

public static class Kata
{
  public static string GetMiddle(string s)
  {
    var charArray = new char[2];
    var division = s.Length / 2;
    var midIndex = s.Length %2 == 0 ? division - 1 : division;
    
    charArray[0] = s.ElementAt(midIndex);    

    if (s.Length % 2 == 0)
    {
      // add the second char
      charArray[1] = s.ElementAt(midIndex + 1);
      return $"{charArray[0].ToString()}{charArray[1].ToString()}";
    } 

    return charArray[0].ToString();
  }

   public static string GetMiddleBest(string s) //Best in CodeWars solutions, less readable though
    {
        return string.IsNullOrEmpty(s)
            ? s
            : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
    }
}