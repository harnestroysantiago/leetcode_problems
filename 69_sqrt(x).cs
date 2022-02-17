public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/sqrtx/
    // Given a non-negative integer x, compute and return the square root of x.
    // Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.
    // Note: You are not allowed to use any built-in exponent function or operator, such as pow(x, 0.5) or x ** 0.5.
    public int MySqrt(int p_x)
    {
        //declaration
        long _start = 0;
        long _end = p_x;

        //edge case validation
        if (_end * _end == p_x)
        {
            return (int)_end;
        }

        //logic binary search method
        while (_start + 1 < _end)
        {
            long __mid = _start + (_end - _start) / 2;
            if (__mid * __mid == p_x)
            {
                return (int)__mid;
            }
            else if (__mid * __mid < p_x)
            {
                _start = __mid;
            }
            else
            {
                _end = __mid;
            }
        }

        return (int)_start;
    }
}