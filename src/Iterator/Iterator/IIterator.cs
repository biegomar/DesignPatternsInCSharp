using Iterator.Aggregate;

namespace Iterator.Iterator
{
    /// <summary>
    /// 
    /// </summary>
    public interface IIterator
    {
        /// <summary>
        /// 
        /// </summary>
        IBinaryTree First();
        IBinaryTree Next();
        bool IsDone();
        IBinaryTree CurrentItem();
    }
}