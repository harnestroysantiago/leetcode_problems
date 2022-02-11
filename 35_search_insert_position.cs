public class Solution
{
    // more infor about the problem here
    // https://leetcode.com/problems/search-insert-position/
    // Given a sorted array of distinct integers and a target value, 
    // return the index if the target is found. If not, 
    // return the index where it would be if it were inserted in order.
    // You must write an algorithm with O(log n) runtime complexity.
    public int SearchInsert(int[] p_nums, int p_target)
    {
        //validation
        if (p_nums.Length == 0)
        {
            return 0;
        }

        //declaration
        int _numLen = p_nums.Length;

        //logic
        for (int _i = 0; _i < _numLen; _i++)
        {
            // return _i if we have a match or target is less than current value of _i
            if (p_target == p_nums[_i] || p_target < p_nums[_i])
            {
                return _i;
            }
        }

        return _numLen;
    }
}