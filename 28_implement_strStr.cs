public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/implement-strstr/
    // Implement strStr().
    // Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    // Clarification:
    // What should we return when needle is an empty string? This is a great question to ask during an interview.
    // For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().
    public int StrStr(string p_haystack, string p_needle)
    {
        //validation
        if (p_haystack == null || p_needle == null)
        {
            return -1;
        }
        //if the parameters are blanks, we should return 0
        if (p_haystack.Equals(p_needle))
        {
            return 0;
        }

        //declaration
        //get the len of the needle
        int _needleLen = p_needle.Length;

        //logic
        //we want to have a windows that is length of needle, but there will
        //be edge cases for words with 1, needle lenth at the end of the string
        //because of this, we want to do a +1
        //ragnarok" and "k" will yield an error without the +1
        //because the counter can only go to 7 for the operation to be valid.
        for (int _i = 0; _i < p_haystack.Length - _needleLen + 1; _i++)
        {
            if (p_haystack.Substring(_i, _needleLen).Equals(p_needle))
            {
                return _i;
            }
        }
        return -1;
    }
}