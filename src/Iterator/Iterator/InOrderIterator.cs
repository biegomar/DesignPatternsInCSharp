using System;
using Iterator.Aggregate;

namespace Iterator.Iterator
{
    public class InOrderIterator: IIterator
    {
        private IBinaryTree BinaryTree { get; }

        public InOrderIterator(IBinaryTree binaryTree)
        {
            if (binaryTree == null)
            {
                throw new ArgumentNullException(nameof(binaryTree));
            }
            
            this.BinaryTree = binaryTree;
        }

        public IBinaryTree First()
        {
            throw new System.NotImplementedException();
        }

        public IBinaryTree Next()
        {
            throw new System.NotImplementedException();
        }

        public bool IsDone()
        {
            throw new System.NotImplementedException();
        }

        public IBinaryTree CurrentItem()
        {
            throw new System.NotImplementedException();
        }
    }
}