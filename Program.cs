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
            BinarySearchTree<string> tree = new BinarySearchTree<string>();

            tree.Add(new Node<string>("Parrot"));
            tree.Add(new Node<string>("Dog"));
            tree.Add(new Node<string>("Cat"));
            tree.Add(new Node<string>("Fish"));
            tree.Add(new Node<string>("Turtle"));
            tree.Add(new Node<string>("Hedgehog"));
            tree.Add(new Node<string>("Hamster"));
            Node<string> node1 = new Node<string>("Hamster");
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
