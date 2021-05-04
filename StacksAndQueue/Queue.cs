using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueue
{
    class Queue
    {
        public Node head; //creating the node head
        /*UC3:- Ability to create a Queue of  56->30->70.
                - Use LinkedList to do the Queue Operations.
                - Here enqueue will internally call append method on LinkedList. 
                - So 56 will be added first then 30 and  then 70 to make 56 on top of the Stack.
        */
        public void Enqueue(int data)
        {

            Node node = new Node(data);  //creating object and initializing node with data
            Node temp = head;

            if (head == null) //if head is null queue is empty
            {
                head = node;
            }
            else
            {
                Node lastNode = GetLastNode(temp); //last element is taken out in queue and node address is passed in last node.
                lastNode.next = node;
            }
            Console.WriteLine($"Element Added in Queue:- {node.data}");
        }

        public Node GetLastNode(Node temp)
        {
            if (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public int Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            Console.WriteLine($"{head.data } is a Top of the Queue "); //print top of Queue

            return head.data;
        }
        /* UC4:- Ability to dequeue from the beginning.
                 - Use LinkedList to do the Queue Operations.
        */
        public void Dequeue() //create Dequeue method to delete element
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            Console.WriteLine($"Removing the beginning { this.head.data } Element from the Queue"); //print
            head = head.next; //passing the address of 2nd element to the head, hence head will directly point to 2nd element and 1st element delete
            Display(); //call Display method

        }
        public void IsEmpty() //create isEmpty method to delete all element from Queue
        {
            Node temp = head;
            while (temp != null)
            {
                Peek(); //call Peek method
                Dequeue(); //call Dequeue method
                temp = temp.next;
            }
            Display(); //call Display MEthod
        }
        public void Display()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                while (temp != null)  //loop is running, until the last element of queue becomes null
                {
                    Console.WriteLine($"Queue Element is:- {temp.data}"); //prints the queue Element
                    temp = temp.next;
                }
            }
        }
    }
}
