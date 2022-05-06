
using System.Text;

namespace LeetCode.TwoSumProblem
{
	internal class Runner
	{
		public void Run()
		{
			// Two sum problem we want to find the pair of elements that add up to 6
			// Quick glance we see
			// 2+4=6
			// 5+1=6
			// The brute force way would be to have 2 loops, but this is bad as it is O(n^2)
			int[] arr = { 1, 2, 3, 4, 5 };			

			new TwoSumProblem().CalculateTwoSum(arr, 6);
		}

		private void PrintResult(int[] nums)
		{
			var builder = new StringBuilder();
			nums.ToList().ForEach(item => builder.Append($"{item}|"));
			Console.WriteLine(builder.ToString());
		}
	}

	internal class TwoSumProblem
	{
		/// <summary>
		/// Figure out the pair of elementes where arr[p] + arr[q] add up to a certain number
		/// </summary>
		/// <param name="arr"></param>
		public void CalculateTwoSum(int[] arr, int targetValue)
		{
			// First index in the array
			int pointer_one = 0;

			// Last possible index in the array
			int pointer_two = arr.Length - 1; 

			// Assumptions
			// 1. The array is sorted
			// 2. Add the values of pointer_one and pointer_two
			while(pointer_one < pointer_two)
			{
				// Add the values of pointer_one and pointer_two
				int currentSum = arr[pointer_one] + arr[pointer_two];

				// If the sum matches our target value. YEA WE ARE DONE.
				if(currentSum == targetValue)
				{
					Console.WriteLine($"Element {arr[pointer_one]} + {arr[pointer_two]} does equal our target value of {targetValue}");
					pointer_one++;
					pointer_two--;
				}
				// If the sum is less than the target value
				// we increment pointer_one. Move your left pointer 1 place to the right
				else if(currentSum < targetValue)
				{
					pointer_one++;					
				}
				// If the sum is greater than the target value
				// we decrement pointer_two. Move your right pointer 1 place to the left
				else if(currentSum > targetValue)
				{
					pointer_two--;
				}				
			}
		}
	}
}
