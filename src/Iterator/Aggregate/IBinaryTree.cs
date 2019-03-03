using System.Net.Sockets;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
    public interface IBinaryTree
    {
        void Add(int value);

        IIterator CreateIterator();
    }
}