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
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(new Node(100));
            tree.Add(new Node(82));
            tree.Add(new Node(116));
            tree.Add(new Node(78));
            tree.Add(new Node(93));
            tree.Add(new Node(105));
            tree.Add(new Node(123));
            Node node1 = new Node(92);
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
