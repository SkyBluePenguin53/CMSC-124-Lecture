using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp
{
    public class BinaryTree
    {
        BiNode root;
        int size = 0;

        public void InsertOnLast(int data)
        {
            BiNode newNode = new BiNode(data);
            if(size>0)
            {
                BiNode currentNode = root;
                while(true)
                {
                    if(currentNode.left!=null)
                    {
                        if(currentNode.right==null)
                        {
                            currentNode.right = newNode;
                            size++;
                            Console.WriteLine("A new node with value "+newNode.data+" has been added at the right.");
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    else
                    {
                        currentNode.left = newNode;
                        size++;
                        Console.WriteLine("A new node with value "+newNode.data+" has been added at the left.");
                        break;
                    }
                }
            }
            else
            {
                root = newNode;
                size++;
                Console.WriteLine("A new node with value "+newNode.data+" has been added at the root.");
            }
        }

        public void DeleteOnLast()
        {
            if(size>0)
            {
                BiNode oldNode = null;
                BiNode current = root;
                BiNode parent = root;
                while(true)
                {
                    if(current.right!=null)
                    {
                        parent = current;
                        current = current.right;
                    }
                    else if(current.left!=null)
                    {
                        parent = current;
                        current = current.left;
                    }
                    else
                    {
                        oldNode = current;
                        if(parent.right == current)
                        {
                            parent.right = null;
                            size--;
                            Console.WriteLine("The deleted node has value "+oldNode.data+" and is the right node of parent "+parent.data+".");
                        }
                        else
                        {
                            parent.left = null;
                            size--;
                            Console.WriteLine("The deleted node has value "+oldNode.data+" and is the left node of parent "+parent.data+".");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Empty binary tree. Insert one!");
            }
        }

        public void PrintPreOrder()
        {
            BiNode[] array = new BiNode[20];
            BiNode currentNode = root;
            int index = 1;
            array[index] = currentNode;

            while(true)
            {
                currentNode = array[index];
                if(currentNode.data!=null)
                {
                    Console.WriteLine(currentNode.data);
                }
                array[index] = null;
                index--;

                if(currentNode.right!=null)
                {
                    index++;
                    array[index] = currentNode.right;
                    
                }
                if(currentNode.left!=null)
                {
                    array[index] = currentNode.left;
                }
                if(index<0)
                {
                    break;
                }
            }
        }

    }

    class BiNode
    {
        public int data;
        public BiNode left;
        public BiNode right;
        public BiNode(int d)
        {
            data = d;
            left = null;
            right = null;
        }
    }
}