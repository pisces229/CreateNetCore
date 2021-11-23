using NUnit.Framework;
using System;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            Console.WriteLine("開始-----------------------------------Test1");
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            Console.WriteLine("開始-----------------------------------Test2");
            Assert.IsTrue(true);
        }
    }
}