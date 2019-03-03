using System;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
    public class BinaryTree: IBinaryTree
    {
        private class TreeNode
        {
            public TreeNode(int value)
            {
                Value = value;
            }

            internal TreeNode LeftChild;
            internal TreeNode RightChild;
            internal int Value { get; }
        }

        private TreeNode RootNode;
        
        public void Add(int value)
        {
            this.AddToNode(ref this.RootNode, value);
        }

        public IIterator CreateIterator()
        {
            return new InOrderIterator(this);
        }

        private void AddToNode(ref TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
            }
            else
            {
                if (value == node.Value)
                {
                    return;
                }

                if (value < node.Value)
                {
                    this.AddToNode(ref node.LeftChild, value);
                }
                else
                {
                    this.AddToNode(ref node.RightChild, value);
                }
            }
        }
    }
}