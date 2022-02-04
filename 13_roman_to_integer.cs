public class Solution
{
    // more about the problem here
    // https://leetcode.com/problems/roman-to-integer/
    // Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    // ------------------
    // Symbol       Value
    // I             1
    // V             5
    // X             10
    // L             50
    // C             100
    // D             500
    // M             1000
    // For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
    // ------------------
    // Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
    // ------------------
    // I can be placed before V (5) and X (10) to make 4 and 9. 
    // X can be placed before L (50) and C (100) to make 40 and 90. 
    // C can be placed before D (500) and M (1000) to make 400 and 900.
    // Given a roman numeral, convert it to an integer.
    public int RomanToInt(string s)
    {
        //create a dictionary
        Dictionary<char, int> romanTable = new Dictionary<char, int>();

        romanTable.Add('I', 1);
        romanTable.Add('V', 5);
        romanTable.Add('X', 10);
        romanTable.Add('L', 50);
        romanTable.Add('C', 100);
        romanTable.Add('D', 500);
        romanTable.Add('M', 1000);

        //get the length of the string
        int n = s.Length;

        //get the first value
        int number = romanTable[s[n - 1]];

        //validation for one char only, return number right away. 
        //right to jail.. erm.. return.
        if (n == 1)
        {
            return number;
        }
        else
        {
            //logic
            for (int i = n - 2; i >= 0; i--)
            {
                //test if we want to add or subtract pairs combination
                if (romanTable[s[i]] >= romanTable[s[i + 1]])
                {
                    number += romanTable[s[i]];
                }
                else
                {
                    number -= romanTable[s[i]];
                }
            }
        }
        return number;
    }
}