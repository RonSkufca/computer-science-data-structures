using System.Diagnostics;

namespace algorithms
{
	internal class BigO
	{
		public BigO()
		{

		}
		public void OrderN()
		{
			long arraySize = 10;

			for(int i = 0; i < 8; i++)
			{
				Console.WriteLine("Running Order N");
				Console.WriteLine($"Array Size {arraySize}");
				long[] array = CreateArray(arraySize);

				Stopwatch stopWatch = new Stopwatch();
				stopWatch.Start();

				var sum = RunLoop(array);

				stopWatch.Stop();
				TimeSpan ts = stopWatch.Elapsed;
				Console.WriteLine($"Sum is {sum}");
				Console.WriteLine("Elapsed Time is hhmmss: {0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);				
				arraySize = arraySize * 10;
			}			
		}

		public void OrderNWithGauss()
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

		private long RunLoop(long[] array)
		{
			long sum = 0;

			for(long i = 0; i < array.Length; i++)
			{
				sum += i;				
			}

			return sum;
		}
	}
}
