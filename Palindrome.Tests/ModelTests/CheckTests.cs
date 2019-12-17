using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace Palindromes.Tests
{
    [TestClass]
    public class CheckTest
    {
        [TestMethod]
        public void IsPalindrome_CheckStringInputForPalindrome_False()
        {
            Check notPalindromeString = new Check();
            Assert.AreEqual(false, notPalindromeString.IsPalindrome("Hello World"));
        }

        [TestMethod]
        public void IsPalindrome_CheckNumInputForPalindrome_False()
        {
            Check notPalindromeNum = new Check();
            Assert.AreEqual(false, notPalindromeNum.IsPalindrome("1234"));
        }
        
        [TestMethod]
        public void IsPalindrome_ChecStringInputForPalindrome_True()
        {
            Check isPalindromeString = new Check();
            Assert.AreEqual(true, isPalindromeString.IsPalindrome("tacocat"));
        }

        [TestMethod]
        public void IsPalindrome_CheckNumInputForPalindrome_True()
        {
            Check isPalindromeNum = new Check();
            Assert.AreEqual(true, isPalindromeNum.IsPalindrome("1234321"));
        }

        [TestMethod]
        public void IsPalindrome_ChecksentenceForPalindrome_True()
        {
            Check isPalindromeSentence = new Check();
            Assert.AreEqual(true, isPalindromeSentence.IsPalindrome("sore was I ere I saw eros"));
        }
    }
}