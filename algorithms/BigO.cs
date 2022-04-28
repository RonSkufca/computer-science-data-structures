using System.Diagnostics;

namespace algorithms
{
	internal class BigO
	{
		public BigO()
		{

		}
		public void Order1()
		{
			long arraySize = 10;

			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine($"Array Size {arraySize}");
				long[] array = CreateArray(arraySize);

				Stopwatch stopWatch = new Stopwatch();
				stopWatch.Start();

				RunLoop(array);

				stopWatch.Stop();
				TimeSpan ts = stopWatch.Elapsed;
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

		private void RunLoop(long[] array)
		{
			long sum = 0;

			for(long i = 0; i < array.Length; i++)
			{
				sum += i;				
			}
		}
	}
}
