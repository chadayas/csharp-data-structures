
TreeNode<int> root = new TreeNode<int>(22);
TreeNode<int> child = new TreeNode<int>(22);
TreeNode<int> s_child = new TreeNode<int>(22);

root.firstChild = child;
child.nextSibling = s_child;

class TreeNode<T>{
   public TreeNode(T element){
      _element =  element;
      firstChild = null;
      nextSibling = null;
   }
   
   public TreeNode<T> firstChild;
   public TreeNode<T> nextSibling;
   
   private T _element;
};

