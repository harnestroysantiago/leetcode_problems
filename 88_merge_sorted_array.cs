public class Solution {
    // more info about the problem here
    // https://leetcode.com/problems/merge-sorted-array/
    // You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
    // Merge nums1 and nums2 into a single array sorted in non-decreasing order.
    // The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
    // more info about the solutions here
    // https://www.youtube.com/watch?v=FhIhUy8bZww
    public void Merge(int[] p_nums1, int p_m, int[] p_nums2, int p_n) {
        //declaration
        p_m --;
        p_n --;
        int _index = p_nums1.Length -1;

        //logic
        //Fill nums1 starting from the last index until 0
        //Start from the last element of nums1 and last element of nums2. 
        //Compare and add element by element to end of nums1.
        while (_index >= 0)
        {
            if (p_m >= 0 && p_n >= 0 && p_nums1[p_m] >= p_nums2[p_n])
            {
                p_nums1[_index] = p_nums1[p_m];
                p_m--;
            }else if (p_n >=0)
            {
                p_nums1[_index] = p_nums2[p_n];
                p_n--;
            }
            _index--;
        }
    }
}