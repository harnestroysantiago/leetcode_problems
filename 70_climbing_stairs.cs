public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/climbing-stairs/
    // You are climbing a staircase. It takes n steps to reach the top.
    // Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
    // more info about the solution here
    // https://www.youtube.com/watch?v=_RrNV8oMMug
    public int ClimbStairs(int p_n)
    {
        //validations
        if (p_n == 0 || p_n == 1)
        {
            return 1;
        }

        //declarations
        int _pre = 1;
        int _curr = _pre;

        //logic
        for (int __i = 2; __i <= p_n; __i++)
        {
            int __tmp = _curr + _pre;
            _pre = _curr;
            _curr = __tmp;
        }

        //return
        return _curr;
    }
}