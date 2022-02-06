public class Solution
{
    // more about the problem here
    // https://leetcode.com/problems/two-sum/
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    // You can return the answer in any order.
    public int[] TwoSum(int[] p_nums, int p_target)
    {
        //declarations
        Dictionary<int, int> _tracker = new Dictionary<int, int>();
        int[] _solution = new int[2];
        int _arrayLength = p_nums.Length;

        //validations
        if (p_nums == null || _arrayLength < 2)
        {
            return _solution;
        }

        //logic
        for (int i = 0; i < _arrayLength; i++)
        {
            //lets get the remainder
            int _remainder = p_target - p_nums[i];

            //check if remainder is in the tracker 
            if (_tracker.ContainsKey(_remainder))
            {
                int _trackerIndex;

                _tracker.TryGetValue(_remainder, out _trackerIndex);


                return _solution = new int[] { _trackerIndex, i };
            }

            //lets update our tracker we use values to replace, and not add, 
            //because an error will be thrown if the same key already exist
            _tracker[p_nums[i]] = i;
        }

        return _solution;
    }
}