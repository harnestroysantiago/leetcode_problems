public class Solution
{
    // more about the problem here
    // https://leetcode.com/problems/palindrome-number/
    // Given an integer x, return true if x is palindrome integer.
    // An integer is a palindrome when it reads the same backward as forward.
    // For example, 121 is a palindrome while 123 is not.
    public bool IsPalindrome(int p_input)
    {
        //validation
        if (p_input < 0)
        {
            return false;
        }

        //store the number in a variable
        int _number = p_input;

        //this will store the reverse of the number
        int _reverse = 0;
        while (_number > 0)
        {
            // reverse * 10 -> gives us the correct base
            // number % 10 -> gives us the last digit
            _reverse = (_reverse * 10) + (_number % 10);
            // number / 10 -> allows us to remove the last digit
            _number = _number / 10;
        }
        //we compare if x == to our reversed number
        return p_input == _reverse;
    }
}