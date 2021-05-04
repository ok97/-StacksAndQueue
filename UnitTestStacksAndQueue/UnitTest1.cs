using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StacksAndQueue;
using System.Collections;

namespace UnitTestStacksAndQueue
{
    [TestClass]
    public class UnitTest1
    {
        Stack stack = new Stack(); //create object of Stack class
        /*UC1*/
        [TestMethod]
        
        public void PushStackElement()
        {            
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
        }

        /*UC2*/
        [TestMethod]
        [DataRow(56)]
        public void TopofStacks(int expected)
        {

            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            int actual = (int)stack.Peek();
            
            Assert.AreEqual(expected, actual); //Assert
        }



        [TestMethod]
        /*UC3 Queue*/
        public void TestingPeekinQueue()
        {
            
            Queue queue = new Queue(); //create object of Queue class
            queue.Enqueue(56); //add element in queue
            queue.Enqueue(30);
            queue.Enqueue(70);
           
            int actual =(int)queue.Peek();
            int expected = 56;
            
            Assert.AreEqual(expected, actual);
        }

    }
}
