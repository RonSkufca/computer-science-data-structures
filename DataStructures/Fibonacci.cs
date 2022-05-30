namespace DataStructures
{
	internal class Fibonacci
	{
		public int IterativeWay(int n)
		{
			// Base or termination condition.
			// used to prevent infinite loop
			if(n <= 1)
				return n;

			int fibNumber = 0;
			int f1, f2;
			f1 = 0;
			f2 = 1;

			for(int i = 2; i <= n; i++)
			{
				fibNumber = f1 + f2;
				f1 = f2;
				f2 = fibNumber;
			}

			return fibNumber;
		}

		public int SlowWay(int n)
		{
			//Console.WriteLine($"Inside SlowWay N: {n}");			

			// Base or termination condition.
			// used to prevent infinite loop
			if(n <= 1)
				return n;

			//Console.WriteLine($"n = {n}");

			return SlowWay(n - 1) + SlowWay(n - 2);
		}
	}
}
