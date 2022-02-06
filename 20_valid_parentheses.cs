public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/valid-parentheses/
    // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    // An input string is valid if:
    // 1.Open brackets must be closed by the same type of brackets.
    // 2.Open brackets must be closed in the correct order.
    public bool IsValid(string p_s)
    {
        //declaration
        //stacks are best for these kind of problems, be cause we just need to check for a pair,
        //if an invalid pair comes, it invalidates the whole stack.
        Stack<char> _openSymbols = new Stack<char>();

        foreach (char _symbol in p_s.ToCharArray())
        {
            //for every open symbol we encounter, we push to our stack
            if (_symbol == '(' || _symbol == '{' || _symbol == '[')
            {
                _openSymbols.Push(_symbol);
            }

            //for every closing symbol we encounter, we check the stack if it has a matching
            //open symbol, and we let it go.
            else if (_symbol == ')' && _openSymbols.Count != 0 && _openSymbols.Peek() == '(')
            {
                _openSymbols.Pop();
            }
            else if (_symbol == '}' && _openSymbols.Count != 0 && _openSymbols.Peek() == '{')
            {
                _openSymbols.Pop();
            }
            else if (_symbol == ']' && _openSymbols.Count != 0 && _openSymbols.Peek() == '[')
            {
                _openSymbols.Pop();
            }

            //if another symbold is detected, we return false, for an invalid parentheses
            else
            {
                return false;
            }
        }
        //if the stack is empty, we have a matching pair of parentheses. else, it's false.
        return _openSymbols.Count == 0;
    }
}