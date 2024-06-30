using codewars_excercises_net;

namespace codewars_excercises_net._7kiu
{
    public partial class Solution
    {
        /*
         Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.

        Examples
        "This is an example!" ==> "sihT si na !elpmaxe"
        "double  spaces"      ==> "elbuod  secaps"
         */

        public static void DoReverseSentence()
        {
            ConsoleHelper.WriteSeparator();
            Console.WriteLine("Reversing: This is an example!");
            Console.WriteLine(GetReversedSentence("This is an example!"));
        ;
        }

        private static string GetReversedSentence(string str)
        {
            var words = str.Split(' ');
            string[] reversedWords = new string[words.Length];
            var index = 0;

            foreach (var item in words)
            {
                char[] charArray = item.ToCharArray();
                Array.Reverse(charArray);
                reversedWords[index++] = new string(charArray);
            }
            return String.Join(" ", reversedWords);
        }
    }
}
