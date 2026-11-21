
var root = new TreeNode<int>(22);
var child = new TreeNode<int>(22);
var s_child = new TreeNode<int>(22);

root.firstChild = child;
child.nextSibling = s_child;

class TreeNode<T>{
   public TreeNode(T element){
      _element =  element;
      firstChild = null;
      nextSibling = null;
   }
   
   public TreeNode firstChild;
   public TreeNode nextSibling;
   
   private T _element;
};

