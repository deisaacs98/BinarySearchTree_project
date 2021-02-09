using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T:IComparable
    {
        public Node<T> rootNode;
        public void Add(Node<T> nodeToAdd)
        {
            if (rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            else
            {
                Node<T> focusNode = rootNode;
                while (true)
                {
                    
                    if(nodeToAdd.data.CompareTo(focusNode.data)<0)
                    {
                        if (focusNode.leftNode == null)
                        {
                            focusNode.leftNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.leftNode;
                        }
                    }
                    else
                    {
                        if (focusNode.rightNode == null)
                        {
                            focusNode.rightNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.rightNode;
                        }
                    }

                }

            }
        }

        public bool Search(Node<T> nodeToFind)
        {
            if (rootNode == null)
            {
                return false;
            }
            else
            {
                Node<T> focusNode=rootNode;
                
                while (true)
                {
                    if (nodeToFind.data.CompareTo(focusNode.data)==0)
                    {
                        return true;
                    }
                    else if (nodeToFind.data.CompareTo(focusNode.data)<0&&focusNode.leftNode!=null)
                    {
                        focusNode = focusNode.leftNode;
                    }
                    else if (nodeToFind.data.CompareTo(focusNode.data)>0 && focusNode.rightNode != null)
                    {
                        focusNode = focusNode.rightNode;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }
        public int CompareTo(T other)
        {
            return other.CompareTo(this);
        }

    }
}
