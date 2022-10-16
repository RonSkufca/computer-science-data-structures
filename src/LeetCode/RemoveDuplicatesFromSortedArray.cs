using System.Text;

namespace LeetCode.RemoveDuplicatesFromSortedArray
{
	internal class Runner
	{
		public void Run()
		{
			var removeDuplicates = new RemoveDuplicatesFromSortedArray();

			int[] nums = { 0,0, 1, 1, 1, 2, 2, 3, 3, 4 };
			//removeDuplicates.RemoveDuplicates1(nums);
			//int arrayWithDuplicatesRemoved = removeDuplicates.RemoveDuplicates(nums);
			//PrintResult(arrayWithDuplicatesRemoved);			
		}

		private void PrintResult(int[] nums)
		{
			var builder = new StringBuilder();
			nums.ToList().ForEach(item => builder.Append($"{item}|"));
			Console.WriteLine(builder.ToString());
		}
	}	

	internal class RemoveDuplicatesFromSortedArray
	{
		public void RemoveDuplicates1(int[] nums)
		{
			int left = 1;
			for(int right = 1; right < nums.Length; right++)
			{
				if(nums[right] != nums[right - 1])
				{
					nums[left] = nums[right];
					left++;
				}
			}			
		}

		public int RemoveDuplicates(int[] nums)
		{
			// We are going to use the 2 pointer approach here
			int previous = 1;

			for(int index = 1; index < nums.Length; index++)
			{
				// Since the array is sorted we can 
				// check for duplicate right next to the current item
				if(nums[index] != nums[index - 1])
				{
					// we found a duplicate, swap the item with the last one
					nums[previous] = nums[index];

					previous++;
				}
			}
			return nums.Length;
		}
	}
}
