namespace DataStructures
{
	internal class Fibonacci
	{
		private long counter = 1;

		public void Run()
		{
			while(!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
			{
				var data = Console.ReadLine();

				Int32.TryParse(data, out int n);

				int Fn = IterativeWay(n);
				Console.WriteLine($"Fibonacci Result {Fn}");

				for(int i = 0; i < n; i++)
				{
					Console.WriteLine($"Fn at position {i} is {RecursiveWay(i)}. It tool {counter} calls to get there.");
				}				
			}
		}

		public int IterativeWay(int n)
		{
			// Base or termination condition. used to prevent infinite loop
			if(n <= 1)
				return n;

			int Fn = 0;
			int Fminus1 = 0;
			int Fminus2 = 1;			

			// Fn = Fn-1 + Fn-2
			for(int i = 0; i < n; i++)
			{
				if(i < 2)
					Fn = i;
				else
				{
					Fn = Fminus1 + Fminus2;
					Fminus1 = Fminus2;
					Fminus2 = Fn;
				}
				
				Console.WriteLine($"Fn: {Fn}");
			}

			return Fn;
		}

		public int RecursiveWay(int n)
		{
			counter++;

			// Base or termination condition. used to prevent infinite loop
			if(n == 0)
				return 0; //To return the first Fibonacci number
						  
			if(n == 1)
				return 1; //To return the second Fibonacci number   

			return RecursiveWay(n - 1) + RecursiveWay(n - 2);			
		}
	}
}
