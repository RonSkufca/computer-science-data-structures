namespace LeetCode
{
	internal class RemoveDuplicatesFromSortedArray
	{
		public int RemoveDuplicates(int[] nums)
		{
			// We are going to use the 2 pointer approach here
			int endIndex = nums.Length - 1;

			for(int startIndex = 0; startIndex < nums.Length - 1; startIndex++)
			{
				// Since the array is sorted we can 
				// check for duplicate right next to the current item
				if(nums[startIndex] == nums[startIndex + 1])
				{
					// we found a duplicate, swap the item with the last one
					nums[startIndex + 1] = nums[endIndex];

					// replace the item at the end with garbage indicator
					nums[endIndex] = -1;

					// move the end pointer to the left
					endIndex--;
				}
			}

			return 0;
		}
	}
}
