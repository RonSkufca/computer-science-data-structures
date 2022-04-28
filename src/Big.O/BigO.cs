using System.Diagnostics;

namespace algorithms
{
	internal class BigO
	{
		public BigO()
		{

		}

		/// <summary>
		/// Sum array the brute force way. This is O(n) or linear
		/// </summary>
		public void SumArrayBruteForceWay()
		{
			long arraySize = 10;

			for(int i = 0; i < 8; i++)
			{
				Console.WriteLine("Running Order N");
				Console.WriteLine($"Array Size {arraySize}");
				long[] array = CreateArray(arraySize);

				Stopwatch stopWatch = new Stopwatch();
				stopWatch.Start();

				long sum = 0;

				for(long j = 0; j < array.Length; i++)
				{
					sum += j;
				}

				stopWatch.Stop();
				TimeSpan ts = stopWatch.Elapsed;
				Console.WriteLine($"Sum is {sum}");
				Console.WriteLine("Elapsed Time is hhmmss: {0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);				
				arraySize = arraySize * 10;
			}			
		}

		/// <summary>
		/// Sum integers using Carl Gauss formula https://nrich.maths.org/2478
		/// This is a NON loop solution so we are now at O(1) or constant time
		/// Much better way
		/// </summary>
		public void SumArrayUsingCarlGaussFormula()
		{
			Console.WriteLine("Running Order N With Gauss Math");
			long arraySize = 10;
			
			for(int i = 0; i < 8; i++)
			{
				Console.WriteLine($"Array Size {arraySize}");
				long[] array = CreateArray(arraySize);

				long lastItemInArray = array[array.Length - 1];

				long sum = lastItemInArray * (lastItemInArray + 1)/2;			

				Stopwatch stopWatch = new Stopwatch();
				stopWatch.Start();

				stopWatch.Stop();
				TimeSpan ts = stopWatch.Elapsed;
				Console.WriteLine($"Sum is {sum}");
				Console.WriteLine("Elapsed Time is hhmmss: {0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

				arraySize = arraySize * 10;
			}
		}

		private long[] CreateArray(long arraySize)
		{
			long[] numbers = new long[arraySize];

			for(long i = 0; i < arraySize; i++)
			{
				numbers[i] = i;
			}

			return numbers;
		}		
	}
}
