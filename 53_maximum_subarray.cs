public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/maximum-subarray/
    // Given an integer array nums, find the contiguous subarray (containing at least one number) 
    // which has the largest sum and return its sum.
    // A subarray is a contiguous part of an array.
    public int MaxSubArray(int[] p_nums)
    {
        //validation
        if (p_nums.Length == 0)
        {
            return 0;
        }

        //declaration
        int _globalMaximum = p_nums[0];
        int _localMaximum = p_nums[0];

        //logic
        for (int _i = 1; _i < p_nums.Length; _i++)
        {
            _localMaximum = Math.Max(p_nums[_i], p_nums[_i] + _localMaximum);
            if (_globalMaximum < _localMaximum)
            {
                _globalMaximum = _localMaximum;
            }
        }
        return _globalMaximum;
    }
}