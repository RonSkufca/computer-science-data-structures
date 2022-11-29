using System.Text;

namespace LeetCode
{
	/*
	  Given n>=0, create an array length n*n with the following pattern, 
	  shown here for n=3 : {0, 0, 1,    0, 2, 1,    3, 2, 1} (spaces added to show the 3 groups).

		squareUp(2) → [0, 1, 2, 1]
		squareUp(3) → [0, 0, 1, 0, 2, 1, 3, 2, 1]
		squareUp(4) → [0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1]
	*/
	public sealed class SumUp
	{

		public void Run()
		{
			var result = squareUp(2);

			StringBuilder builder = new StringBuilder();

			result.ToList().ForEach(item => builder.Append($"{item}"));

			Console.WriteLine(builder.ToString());
		}

		public static int[] squareUp(int n)
		{
			int[] arr = new int[n*n];

			if (n == 0)
				return arr;

			for (int i = n - 1; i < arr.Length; i += n)
			{
				for (int j = i; j >= i - i / n; j--)
					arr[j] = i - j + 1;
			}

			return arr;
		}
	}
}
