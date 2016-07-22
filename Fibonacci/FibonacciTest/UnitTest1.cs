using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci;

namespace FibonacciTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Fibonacci.Form1 f = new Fibonacci.Form1();
            int sonuc = f.fibonacciHesapla(30);
            Assert.AreEqual(1346269, sonuc);
        }
    }
}
