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
        public void TopofStacks(int expected) //Find Top of the stack
        {           
            int actual = (int)stack.Peek();            
            
            Assert.AreEqual(expected, actual); //Assert
        }
    }
}
