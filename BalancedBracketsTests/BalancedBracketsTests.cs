using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]][]["));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void test10()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }


    }
}