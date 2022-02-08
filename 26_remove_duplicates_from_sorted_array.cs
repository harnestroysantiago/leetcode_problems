public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    // Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.
    // Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
    // Return k after placing the final result in the first k slots of nums.
    // Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
    public int RemoveDuplicates(int[] p_nums)
    {
        //validation
        if (p_nums.Length == 0)
            return 0;

        //declaration
        //lets keep a counter for the index
        int _len = 1;

        //logic
        for (int _i = 1; _i < p_nums.Length; _i++)
        {
            //if current index is != to previous index,
            if (p_nums[_i] != p_nums[_i - 1])
            {
                //we put our new number into index _len
                p_nums[_len] = p_nums[_i];
                //we then increment _len
                _len += 1;
            }
        }
        //lets return our counter.
        return _len;
    }
}