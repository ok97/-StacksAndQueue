using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueue
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
    class Stack
    {
        public Node top;
        public Stack() // Defining a node which is assigned null value in constructor it is like a head and used to point to first node.

        {
            this.top = null;
        }

        /* UC1:- Ability to create a Stack of 56->30->70.
                 - Use LinkedList to do the Stack Operations.
                 - Here push will internally call add method on LinkedList. 
                 - So 70 will be added first then 30 and then 56 to make 56 on top of the Stack.
        */


        public void Push(int data) //create method Push/Add element in stack 
        {
            Node node = new Node(data); // object of node is created and initialized with data

            if (this.top == null) //top is nulll to print 
            {
                node.next = null; //empty                              
            }
            else
            {
                node.next = top;//changing the address in top to that of node, hence node will become new top
            }

            this.top = node;  //when new node, will point to top, it will be addressed to old value added, acting now as top
            Console.WriteLine($"Element Inserted In Stack:- {data}");

        }

        /* UC2:- Ability to peek and pop from the Stack till it is empty 56 ->30 ->70.
                 - Use LinkedList to do the Stack Operations
         */
        
        public void Peek()
        {
            if (this.top == null) //Check top element  is null to print 
            {
                Console.WriteLine("Stack is Empty"); // print 
                return;

            }
            Console.WriteLine($"{this.top.data } is a Top of the Stack "); //print top of stack
            
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Empty Stack"); //top is null print stack is empty
            }
            Console.WriteLine($"Removing the top {this.top.data } (LIFO) Element from the stack"); //print
           
            this.top =this.top.next;  //moving the pointer of top to next node
            Display(); //call Display method print stack element
        }

        public void isEmpty()
        {
            while (top != null)
            {
                Peek(); //call Peek Method
                Pop(); //call pop method 
            }
            Display();
        }

        public void Display() //create Display method print elements from the stack
        {
            Node temp = this.top;
            if (temp == null) //top is nulll to print 
            {
                Console.WriteLine("Stack is Empty"); //print 
                return;

            }
            while (temp != null) //while top is not null 
            {
                Console.WriteLine($"Stack Elements is:- { temp.data}");
                temp = temp.next;
            }
        }
    }
}

