using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestStacksAndQueue
{
    [TestClass]
    public class UnitTest1
    {
        Stack stack = new Stack(); //create object of Stack class

        [TestMethod]        
        public void PushStackElement()
        {            
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
        }

    }
}
