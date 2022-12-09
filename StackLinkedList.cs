using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*******************************************************************
                        EXPLORATION OF C#
                        
                Created by: Ron Gerlan F. Naragdao
                        December 9, 2022
*******************************************************************/


/*******************************************************************
When using Visual Code Studio, type dotnet run in console to run C#.
*******************************************************************/

namespace Csharp
{
    public class StackLinkedList
    {
        // head attribute of linked list
        Node head;
        // size attribute of linked list
        int size = 0;

        // "pushes" a data onto the stack
        public void Push(int newData)
        {
            // new node instance
            Node newNode = new Node(newData);
            // set next of new node as head node
            newNode.next = head;
            // set head node as new node
            head = newNode;
            // increment size
            size++;
            // print pushed data
            Console.WriteLine("The value of the pushed node is "+newNode.data+".");
        }

        public void Pop()
        {
            // if linked list is occupied
            if(size>0)
            {
                // new node instance as head node
                Node oldNode = head;
                // set current head node as the next of head node
                head = head.next;
                // next node of new node instance is set to null
                oldNode.next = null;
                // decrement size
                size--;
                // print popped data
                Console.WriteLine("The value of the popped node is "+oldNode.data+".");
            }
            // if linked list is unoccupied
            else
            {
                // print valid reason
                Console.WriteLine("The stack cannot be popped.");
            }
            
        }

        public void PrintSLL()
        {
            // if linked list is occupied
            if(size>0)
            {
                // new node instance as head node
                Node node = head;
                // print stacked linked list elements with graphical representation
                Console.WriteLine("Stacked Linked List contains the following:");
                Console.Write("[");
                // while linked list is still traversed
                while(true)
                {
                    // print node data
                    Console.Write(node.data+"->");
                    // if next of current node is not null
                    if(node.next!=null)
                    {
                        // set node as its next node
                        node = node.next;
                    }
                    // if next of current node is null
                    else
                    {
                        // print null
                        Console.Write("NULL]");
                        // exit loop
                        break;
                    }
                }
                // prints the arrow indicating the top of stack
                Console.WriteLine("\n ^");
                // prints the TOP keyword for the arrow
                Console.WriteLine("TOP");
            }
            // if linked list is unoccupied
            else
            {
                Console.WriteLine("Empty stack. Push one!");
            }
        }
    }

    // a class for Node for all Linked List available and in the future
    class Node
    {
        // data variable holds the data
        public int data;
        // next variable points to the next Node
        public Node next;
        // constructor
        public Node(int d)
        {
            // set data as input d
            data = d;
            // set next to null as default
            next = null;
        }
    }
}