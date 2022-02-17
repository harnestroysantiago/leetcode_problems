public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/add-binary/
    // Given two binary strings a and b, return their sum as a binary string.
    public string AddBinary(string p_a, string p_b)
    {
        //declaration
        //stringbuilder class provides us with mutable strings
        //more info about string builder class and it's methods
        //https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-6.0
        StringBuilder _result = new StringBuilder();

        //helper variables
        int _i = p_a.Length - 1;
        int _j = p_b.Length - 1;

        int _carry = 0;

        //logic
        //more infor on how to conver binary to decimal
        //https://www.youtube.com/watch?v=VLflTjd3lWA
        while (_i >= 0 || _j >= 0)
        {
            int __sum = _carry;

            if (_i >= 0)
            {
                __sum += p_a[_i--] - '0';
            }
            if (_j >= 0)
            {
                __sum += p_b[_j--] - '0';
            }

            _result.Insert(0, __sum % 2);

            _carry = (__sum / 2);
        }

        if (_carry > 0)
        {
            _result.Insert(0, 1);
        }

        return _result.ToString();
    }
}