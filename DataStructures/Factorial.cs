namespace DataStructures
{
	internal class Factorial
	{
		public int CalcFactorial(int n)
		{
			Console.WriteLine($"I am calculating factorial of {n}");

			if(n == 0)
				return 1;

			int factorial = n * CalcFactorial(n-1);

			Console.WriteLine($"Done calculating factorial {factorial}");

			return factorial;
		}
	}
}
