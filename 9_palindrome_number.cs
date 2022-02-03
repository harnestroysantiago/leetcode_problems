public class Solution
{
    // more about the problem here
    // https://leetcode.com/problems/palindrome-number/
    // Given an integer x, return true if x is palindrome integer.
    // An integer is a palindrome when it reads the same backward as forward.
    // For example, 121 is a palindrome while 123 is not.
    public bool IsPalindrome(int x)
    {
        //validation
        if (x < 0)
        {
            return false;
        }

        //store the number in a variable
        int number = x;

        //this will store the reverse of the number
        int reverse = 0;
        while (number > 0)
        {
            // reverse * 10 -> gives us the correct base
            // number % 10 -> gives us the last digit
            reverse = (reverse * 10) + (number % 10);
            // number / 10 -> allows us to remove the last digit
            number = number / 10;
        }
        //we compare if x == to our reversed number
        return x == reverse;
    }
}