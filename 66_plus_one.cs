public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/plus-one/
    // You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
    // Increment the large integer by one and return the resulting array of digits.


    public int[] PlusOne(int[] p_digits)
    {
        //get the digits len
        int _digitLen = p_digits.Length;

        //loop backwards, 
        for (int _i = _digitLen - 1; _i >= 0; _i--)
        {
            //if current element is < 9 +1 and return
            if (p_digits[_i] < 9)
            {
                p_digits[_i]++;
                return p_digits;
            }
            //if current element is 9, set to 0 and continue
            p_digits[_i] = 0;
        }

        //if the last number is was process, we create a new array
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays
        //create an array with lenth + 1, with 0 values,
        int[] _newNumber = new int[_digitLen + 1];

        //change first element to 1 and return.
        _newNumber[0] = 1;
        return _newNumber;
    }
}