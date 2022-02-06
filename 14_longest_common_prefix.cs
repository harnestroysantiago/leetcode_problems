public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/longest-common-prefix/
    // Write a function to find the longest common prefix string amongst an array of strings.
    // If there is no common prefix, return an empty string "".
    public string LongestCommonPrefix(string[] p_strs)
    {
        //declaration
        StringBuilder _longestCommonPrefix = new StringBuilder();

        //validation
        if (p_strs.Length == 0)
        {
            return _longestCommonPrefix.ToString();
        }

        //find the shortest string in the array as int, 
        //{leet, leetcode, leet, leeds } for this array we should get '4'
        int _minLength = p_strs[0].Length;
        for (int _i = 1; _i < p_strs.Length; _i++)
        {
            _minLength = Math.Min(_minLength, p_strs[_i].Length);
        }

        //logic
        //looping through the with _minLength
        for (int _i = 0; _i < _minLength; _i++)
        {
            //get the firstString in our array
            string _firstString = p_strs[0];
            //get the char at the current element
            char _currentChar = _firstString[_i];
            //loop through each string in string array
            foreach (string _strs in p_strs)
            {
                //if the current char at string, breaks the patter, 
                if (_strs[_i] != _currentChar)
                {
                    //we return, because we no longer have a prefix,
                    return _longestCommonPrefix.ToString();
                }
            }
            //otherwise, lets append to our _longestCommonPrefix
            _longestCommonPrefix.Append(_currentChar);
        }
        //we return our prefix because our shortest array, is the prefix
        return _longestCommonPrefix.ToString();
    }
}