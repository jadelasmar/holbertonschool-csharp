using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {

        [Test]
		public void Main()
		{
			string s = "A man, a plan, a canal: Panama.";

			bool result = Str.IsPalindrome(s);

			Assert.AreEqual(true, result);
		}

        [Test]
		public void threeLetterPali()
		{
			string s = "aba";

			bool result = Str.IsPalindrome(s);

			Assert.AreEqual(true, result);
		}

		[Test]
		public void threeLetternotPali()
		{
			string s = "esve";

			bool result = Str.IsPalindrome(s);

			Assert.AreEqual(false, result);
		}
		[Test]
		public void Empty()
		{
			string s = "";

			bool result = Str.IsPalindrome(s);

			Assert.AreEqual(true, result);
		}
    }
}