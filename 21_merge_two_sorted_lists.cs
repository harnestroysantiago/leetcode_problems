
//   Definition for singly-linked list.
// public class ListNode
// {
//     public int val;
//     public ListNode next;
//     public ListNode(int val = 0, ListNode next = null)
//     {
//         this.val = val;
//         this.next = next;
//     }
// }

public class Solution
{
    // more info about the problem here
    // https://leetcode.com/problems/merge-two-sorted-lists/
    // You are given the heads of two sorted linked lists list1 and list2.
    // Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
    // Return the head of the merged linked list.
    public ListNode MergeTwoLists(ListNode p_list1, ListNode p_list2)
    {
        //validation
        if (p_list1 == null)
        {
            return p_list2;
        }
        if (p_list2 == null)
        {
            return p_list1;
        }

        //create dummy node with head
        ListNode _head;
        ListNode _temp;

        //choose the head of the list, the head is just the first element
        if (p_list1.val < p_list2.val)
        {
            _temp = _head = new ListNode(p_list1.val);
            p_list1 = p_list1.next;
        }
        else
        {
            _temp = _head = new ListNode(p_list2.val);
            p_list2 = p_list2.next;
        }

        //loop through our linked list, until one list runs out.
        while (p_list1 != null && p_list2 != null)
        {
            if (p_list1.val < p_list2.val)
            {
                _temp.next = new ListNode(p_list1.val);
                p_list1 = p_list1.next;
            }
            else
            {
                _temp.next = new ListNode(p_list2.val);
                p_list2 = p_list2.next;
            }
            _temp = _temp.next;
        }

        //add our remaining list nodes into temp, until both list are empty
        while (p_list1 != null)
        {
            _temp.next = new ListNode(p_list1.val);
            p_list1 = p_list1.next;
            _temp = _temp.next;
        }

        while (p_list2 != null)
        {
            _temp.next = new ListNode(p_list2.val);
            p_list2 = p_list2.next;
            _temp = _temp.next;
        }

        //return head, the head is the same linked list as temp,
        //remember linked list work on pointers to the next link node in line.
        return _head;
    }
}