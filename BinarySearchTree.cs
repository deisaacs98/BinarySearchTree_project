using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node rootNode;
        public void Add(Node nodeToAdd)
        {
            if (rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            else
            {
                Node focusNode = rootNode;
                while (true)
                {
                    
                    if(nodeToAdd.data<focusNode.data)
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

        public bool Search(Node nodeToFind)
        {
            if (rootNode == null)
            {
                return false;
            }
            else
            {
                Node focusNode=rootNode;

                while (true)
                {
                    if (nodeToFind.data == focusNode.data)
                    {
                        return true;
                    }
                    else if (nodeToFind.data < focusNode.data&&focusNode.leftNode!=null)
                    {
                        focusNode = focusNode.leftNode;
                    }
                    else if (nodeToFind.data > focusNode.data && focusNode.rightNode != null)
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

    }
}
