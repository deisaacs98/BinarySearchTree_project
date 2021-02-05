using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Add(new Node<int>( 100));
            tree.Add(new Node<int>(82));
            tree.Add(new Node<int>(116));
            tree.Add(new Node<int>(78));
            tree.Add(new Node<int>(93));
            tree.Add(new Node<int>(105));
            tree.Add(new Node<int>(123));
            Node<int> node1 = new Node<int>(105);
            if(tree.Search(node1))
            {
                Console.WriteLine("Search successful");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Search unsuccessful");
                Console.ReadLine();
            }

        }
    }
}
