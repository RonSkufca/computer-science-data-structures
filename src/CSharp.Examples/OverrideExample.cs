namespace CSharp.Examples
{
	public sealed class OverrideDerived : OverrideBase
	{
		/// <summary>
		/// You are asserting that you are aware that the member
		/// that it modifies hides a member that is inherited from the base class.
		/// </summary>
		new public string Method2()
		{
			string result = "Derived - Method 2";
			Console.WriteLine(result);
			return result;
		}
	}

	public class OverrideBase
	{
		public string Method1()
		{
			string result = "Base - Method 1";
			Console.WriteLine(result);
			return result;
		}

		public string Method2()
		{
			string result = "Base - Method 2";
			Console.WriteLine(result);
			return result;
		}
	}
}
