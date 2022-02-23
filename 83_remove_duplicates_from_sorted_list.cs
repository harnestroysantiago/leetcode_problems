/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    // more info about the problem here
    // https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    // Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.
    // more info about the solution here.  https://www.youtube.com/watch?v=p10f-VpO4nE
    public ListNode DeleteDuplicates(ListNode p_head) {

        //declaration
        ListNode _temp = p_head;
        
        //logic
        //the way to remove a listNode is to skip the pointer, thus we use the line, _temp.next = _temp.next.next
        while(_temp != null){
            while(_temp.next != null && _temp.val == _temp.next.val){
                // ? skip the pointer
                _temp.next = _temp.next.next;
            }
            // ? replace the current node with the != next node.
            _temp = _temp.next;
        }
        //return the p_head
        return p_head;
    }
}