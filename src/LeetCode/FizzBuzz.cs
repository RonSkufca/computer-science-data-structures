namespace LeetCode
{
	internal class FizzBuzz
	{
		private const string Fizz = "Fizz";
		private const string Buzz = "Buzz";
		private const string Fizz_Buzz = "FizzBuzz";

		public IList<string> Calculate(int n)
		{
			List<string> list = new List<string>();

			for(int i = 1; i <= n; i++)
			{
				var divisibleBy3 = (i % 3 == 0);

				var divisibleBy5 = (i % 5 == 0);

				if(divisibleBy3 && divisibleBy5)
					list.Add(Fizz);

				else if(divisibleBy5)
					list.Add(Buzz);

				else if(divisibleBy3)
					list.Add(Fizz_Buzz);

				else
					list.Add(i.ToString());
			}

			return list;
		}
	}
}
