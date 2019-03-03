using System;
using Iterator.Aggregate;
using Xunit;

namespace Iterator.Test
{
    public class BinaryTreeTest
    {
        [Fact]
        public void AddTest()
        {
            var sut = new BinaryTree(); 
            
            sut.Add(12);
            sut.Add(9);
            sut.Add((15));
            sut.Add(13);
        }
    }
}