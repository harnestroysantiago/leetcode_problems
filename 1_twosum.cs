public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // more about the problem here
        // https://leetcode.com/problems/two-sum/
        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        // You can return the answer in any order.

        //declarations
        Dictionary<int, int> _tracker = new Dictionary<int, int>();
        int[] _solution = new int[2];
        int _arrayLength = nums.Length;

        //validations
        if (nums == null || _arrayLength < 2)
        {
            return _solution;
        }

        //logic
        for (int i = 0; i < _arrayLength; i++)
        {

            int _remainder = target - nums[i];

            if (_tracker.ContainsKey(_remainder))
            {

                int _trackerIndex;

                _tracker.TryGetValue(_remainder, out _trackerIndex);


                return _solution = new int[] { _trackerIndex, i };
            }

            _tracker[nums[i]] = i;
        }

        return _solution;
    }
}