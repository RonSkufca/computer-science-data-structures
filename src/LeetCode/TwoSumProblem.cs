
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
			int[] arr = { 2, 7, 11, 15 };

			var twoSum = new TwoSumProblem();
			// output should be [0,1]
			//twoSum.CalculateTwoSum(arr, 9);

			int[] arr1 = {3, 2, 4};
			// output should be [1,2]
			twoSum.CalculateTwoSumForSortedArray(arr1, 6);
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
		/// THIS WILL ONLY WORK WHEN ARR IS SORTED IN ASCENDING ORDER
		/// </summary>
		/// <param name="arr"></param>
		public int[] CalculateTwoSumForSortedArray(int[] arr, int targetValue)
		{
			// First index in the array
			int pointer_start = 0;

			// Last possible index in the array
			int pointer_end = arr.Length - 1;

			// indexes for the 2 items which sum to the targetValue
			int[] targetIndexes = new int[2];

			// Assumptions
			// 1. The array is sorted
			// 2. Add the values of pointer_one and pointer_two
			while(pointer_start < pointer_end)
			{
				// Add the values of pointer_one and pointer_two
				int currentSum = arr[pointer_start] + arr[pointer_end];

				// If the sum matches our target value. YEA WE ARE DONE.
				if(currentSum == targetValue)
				{
					Console.WriteLine($"Element {arr[pointer_start]} + {arr[pointer_end]} does equal our target value of {targetValue}");
					targetIndexes[0] = pointer_start;
					targetIndexes[1] = pointer_end;
					pointer_start++;
					pointer_end--;
				}
				// If the sum is less than the target value
				// we increment pointer_one. Move your left pointer 1 place to the right
				else if(currentSum < targetValue)
				{
					pointer_start++;					
				}
				// If the sum is greater than the target value
				// we decrement pointer_two. Move your right pointer 1 place to the left
				else if(currentSum > targetValue)
				{
					pointer_end--;
				}			
			}
			return targetIndexes;
		}
	}
}
