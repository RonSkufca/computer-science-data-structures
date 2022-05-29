namespace DataStructures
{
	internal class Fibonacci
	{
		private int fibCounter = 1;

		public void Run()
		{
			int fibNumber = SlowWay(10);
		} 

		public int SlowWay(int n)
		{
			Console.WriteLine($"Inside SlowWay N: {n}");			

			if(n < 2)
				return n;
			else
				return SlowWay(n - 1) + SlowWay(n - 2);
		}
	}
}
