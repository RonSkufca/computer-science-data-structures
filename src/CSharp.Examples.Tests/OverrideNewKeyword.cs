namespace CSharp.Examples.Tests
{
	[TestClass]
	public class OverrideNewKeyword
	{
		[TestMethod]
		public void Run_Example()
		{
			OverrideBase overrideBase = new OverrideBase();
			OverrideDerived overrideDerived = new OverrideDerived();
			OverrideBase both = new OverrideDerived();

			var result = overrideBase.Method1();
			Assert.AreEqual("Base - Method 1", result);

			var result1 = overrideDerived.Method1();
			Assert.AreEqual("Base - Method 1", result1);

			var result2 = overrideDerived.Method2();
			Assert.AreEqual("Derived - Method 2", result2);

			var result3 = both.Method1();
			Assert.AreEqual("Base - Method 1", result3);

			var result4 = both.Method2();
			Assert.AreEqual("Base - Method 2", result4);
		}
	}
}