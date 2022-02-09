public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/remove-element/
    // Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.
    // Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
    // Return k after placing the final result in the first k slots of nums.
    // Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
    public int RemoveElement(int[] p_nums, int p_val)
    {
        //validation
        if (p_nums.Length == 0)
        {
            return 0;
        }

        //declaration
        int _count = 0;

        //logic
        for (int _i = 0; _i < p_nums.Length; _i++)
        {
            //everytime we encounter the value, we skip, 
            //which makes the _count, lag behind
            //it then switch to the next valid index
            if (p_nums[_i] != p_val)
            {
                p_nums[_count] = p_nums[_i];

                //increase the count we return for every valid index
                _count++;
            }
        }
        return _count;
    }
}