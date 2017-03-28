using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestContinuousIntegration
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			int rendu = 2;
			bool result = true;
			Assert.IsTrue(result);
			Assert.AreEqual(rendu, 2);
		}
	}
}