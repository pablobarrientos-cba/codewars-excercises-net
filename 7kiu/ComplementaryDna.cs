/*
In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". 
Your function receives one side of the DNA (string, except for Haskell); 
you need to return the other complementary side. 
DNA strand is never empty or there is no DNA at all (again, except for Haskell).

More similar exercise are found here: http://rosalind.info/problems/list-view/ (source)

Example: (input --> output)

"ATTGC" --> "TAACG"
"GTAT" --> "CATA"
*/

public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            var charArray = dna.ToCharArray();

            for (int i=0; i<charArray.Length; i++)
            {
                switch (charArray[i])
                {
                    case 'A':
                        charArray[i] = 'T';
                        break;
                    case 'T':
                        charArray[i] = 'A';
                        break;
                    case 'C':
                        charArray[i] = 'G';
                        break;
                    case 'G':
                        charArray[i] = 'C';   
                        break;
                }
            }
            return new string(charArray);
        }
    }