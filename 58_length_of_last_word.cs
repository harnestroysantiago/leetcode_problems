public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/length-of-last-word/
    // Given a string s consisting of some words separated by some number of spaces, return the length of the last word in the string.
    // A word is a maximal substring consisting of non-space characters only.
    public int LengthOfLastWord(string p_s)
    {
        //declaration
        string[] m_strArray = p_s.Split(" ");

        int m_strArrLen = m_strArray.Length;

        string m_lastWord = m_strArray[m_strArrLen - 1];

        //logic loop through the word from the end,
        for (int _i = m_strArrLen - 1; _i >= 0; _i--)
        {
            if (m_strArray[_i].Length != 0)
            {
                m_lastWord = m_strArray[_i];
                return m_lastWord.Length;
            }
        }

        return m_lastWord.Length;
    }
}