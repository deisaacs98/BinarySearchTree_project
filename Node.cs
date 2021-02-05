using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T>
    {
        public T data;
        public Node<T> leftNode;
        public Node<T> rightNode;

        public Node(T data)
        {
            this.data = data;
        }

    }
}
