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
    public ListNode DoubleIt(ListNode head) {
        // Convert linked list to string
        StringBuilder number = new StringBuilder();
        var currentNode = head;
        while (currentNode != null) {
            number.Append(currentNode.val);
            currentNode = currentNode.next;
        }

        // Double the number represented by the string
        StringBuilder doubledNum = new StringBuilder();
        int carry = 0;
        for (int i = number.Length - 1; i >= 0; i--) {
            int digit = (number[i] - '0') * 2 + carry;
            carry = digit / 10;
            digit %= 10;
            doubledNum.Insert(0, digit);
        }
        if (carry > 0) {
            doubledNum.Insert(0, carry);
        }

        // Update the linked list with the doubled number
        currentNode = head;
        for (int i = 0; i < doubledNum.Length && currentNode != null; i++) {
            currentNode.val = doubledNum[i] - '0';
            if (currentNode.next == null && i < doubledNum.Length - 1) {
                currentNode.next = new ListNode();
            }
            currentNode = currentNode.next;
        }

        return head;
    }
}
