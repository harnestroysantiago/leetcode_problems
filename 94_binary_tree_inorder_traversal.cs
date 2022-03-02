/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    //? more info about the problem here
    //? https://leetcode.com/problems/binary-tree-inorder-traversal/
    //? Given the root of a binary tree, return the inorder traversal of its nodes' values.
    //? more infor about the soliution here
    //? https://www.youtube.com/watch?v=o_T8MswDI_Y
    public IList<int> InorderTraversal(TreeNode p_root) 
    {   
        // declaration
        List<int> _list = new List<int>();

        // call the recursive function
        return BinaryTreeDetective(p_root, _list);
    }

    //? this helper functon, basically does the whole logic
    private List<int> BinaryTreeDetective(TreeNode p_root, List<int> p_list)
    {
        //? if the root is null, return the lists
        if(p_root == null){
            return p_list;
        }

        //? check the node in this order (left dig, root, right dig), left dig down, if can not go down becuase of an invalid null node, we execute the next code, to add the value of the root to the list.
        p_list = BinaryTreeDetective(p_root.left, p_list);

        //? add the value of the root, and then dig to the right side, of the tree
        p_list.Add(p_root.val);

        //? since this is the last step we can return whatever is returned on the right tree.
        return BinaryTreeDetective(p_root.right, p_list);
    }
}