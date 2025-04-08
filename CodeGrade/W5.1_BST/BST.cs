
namespace Solution;

public class BST<T> : IBST<T> where T : IComparable<T>
{
    public TreeNode<T>? Root { get; set; }

    public void Insert(T value) => Insert(value, Root);
    public void InsertIterative(T value)
    {
        if (Root == null)
        {
            Root = new TreeNode<T>(value);
            return;
        }

        var current = Root;

        while (true)
        {
            int compare = value.CompareTo(current.Value);

            if (compare == 0)
            {
                return;
            }

            else if (compare < 0)
            {
                if (current.Left == null)
                {
                    current.Left = new TreeNode<T>(value, current);
                    return;
                }

                current = current.Left;
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = new TreeNode<T>(value, current);
                    return;
                }

                current = current.Right;
            }
        }
    }

    private void Insert(T value, TreeNode<T>? node)
    {
        if (Root == null)
        {
            Root = new TreeNode<T>(value);
            return;
        }

        int compare = value.CompareTo(node!.Value);

        if (compare == 0)
        {
            return;
        }
        else if (compare < 0)
        {
            if (node.Left == null)
            {
                node.Left = new TreeNode<T>(value, node);
            }
            else
            {
                Insert(value, node.Left);
            }
        }
        else
        {
            if (node.Right == null)
            {
                node.Right = new TreeNode<T>(value, node);
            }
            else
            {
                Insert(value, node.Right);
            }
        }
    }

    #region Traversal

    public string PreOrderTraversal() => PreOrderTraversal(Root);
    private string PreOrderTraversal(TreeNode<T>? currNode)
    {
        if (currNode == null)
        {
            return "";
        }

        var left = PreOrderTraversal(currNode.Left);
        var right = PreOrderTraversal(currNode.Right);

        return $"{currNode.Value} {(left + right).Trim()}".Trim();
    }

    public string InOrderTraversal() => InOrderTraversal(Root);
    private string InOrderTraversal(TreeNode<T>? currNode)
    {
        if (currNode == null)
        {
            return "";
        }

        var left = InOrderTraversal(currNode.Left);
        var right = InOrderTraversal(currNode.Right);

        return $"{(left + " " + currNode.Value + " " + right).Trim()}".Trim();
    }

    public string PostOrderTraversal() => PostOrderTraversal(Root);
    private string PostOrderTraversal(TreeNode<T>? currNode)
    {
        if (currNode == null)
        {
            return "";
        }

        var left = PostOrderTraversal(currNode.Left);
        var right = PostOrderTraversal(currNode.Right);

        return $"{(left + right + " " + currNode.Value).Trim()}".Trim();
    }
    #endregion

    public bool Contains(T value) => Search(Root, value) != null;

    private TreeNode<T> Search(TreeNode<T>? node, T value)
    {
        if (node == null)
        {
            return null;
        }

        int compare = value.CompareTo(node.Value);

        if (compare == 0)
        {
            return node;
        }

        if (compare < 0)
        {
            return Search(node.Left, value);
        }

        return Search(node.Right, value);
    }

    #region  Remove Delete

    public bool Remove(T value) => throw new NotImplementedException();

    private bool DeleteValue(BST<T>? tree, T value)
    {
        if (tree == null || tree.Root == null)
        {
            return false;
        }

        if (tree.Root.Value.CompareTo(value) == 0)
        {
            if (tree.Root.Left == null && tree.Root.Right == null)
            {
                tree.Root = null;

                return true;
            }
            else if (tree.Root.Left != null && tree.Root.Right == null)
            {
                tree.Root.Left.Parent = null;
                tree.Root = tree.Root.Left;

                return true;
            }
            else if (tree.Root.Right != null && tree.Root.Left == null)
            {
                tree.Root.Right.Parent = null;
                tree.Root = tree.Root.Right;

                return true;
            }
        }

        var node = Search(tree.Root, value);

        if (node == null)
        {
            return false;
        }

        return delete(node);
    }

    private bool delete(TreeNode<T> nodeToDelete)
    {
        if (nodeToDelete.Left == null && nodeToDelete.Right == null)
        {
            if (nodeToDelete.Parent == null)
            {
                Root = null;
            }
            else if (isLeft(nodeToDelete, nodeToDelete.Parent))
            {
                nodeToDelete.Parent.Left = null;
            }
            else
            {
                nodeToDelete.Parent.Right = null;
            }

            return true;
        }
        else if (nodeToDelete.Left == null || nodeToDelete.Right == null)
        {
            var child = nodeToDelete.Left ?? nodeToDelete.Right;

            if (nodeToDelete.Parent == null)
            {
                Root = child;
                child!.Parent = null;
            }
            else if (isLeft(nodeToDelete, nodeToDelete.Parent))
            {
                nodeToDelete.Parent.Left = child;
                child!.Parent = nodeToDelete.Parent;
            }
            else
            {
                nodeToDelete.Parent.Right = child;
                child!.Parent = nodeToDelete.Parent;
            }

            return true;
        }
        else
        {
            var successor = findInOrderSucc(nodeToDelete);

            if (successor == null)
            {
                return false;
            }
            nodeToDelete.Value = successor.Value;

            return delete(successor);
        }
    }

    // This methods finds the in order successor of the node given as parameter
    private TreeNode<T>? findInOrderSucc(TreeNode<T> node)
    {
        var currNode = node.Right;
        while (currNode != null && currNode.Left != null)
            currNode = currNode.Left;

        return currNode;
    }

    // This methods checks if the node given as first parameter is the left child of the node given as second parameter ("parent"). 
    // The comparison is based on the values of the nodes.
    private bool isLeft(TreeNode<T> node, TreeNode<T> parent)
    {
        return parent.Left != null && parent.Left.Value.CompareTo(node.Value) == 0;
    }

    public List<T> Traversal(TraversalOrder traversalOrder) //Optional
    {
        throw new NotImplementedException();
    }
    #endregion
}

