
namespace LeetCode
{
    public class PeakElement
    {
        

        public int FindPeakElement(int[] nums)
        {
            int previousIndex = 0;
            int nextIndex = 0;
            int peakElement = 0;

            // for index [1]
            if (nums.Length == 1)
                return 0;

            // for index [1,2] & [2,1]
            if(nums.Length == 2)
            {
                if (nums[1] > nums[0])
                    return 1;
                else
                    return 0;
			}

            for (int i = 1; i < nums.Length; i++)
            {
                previousIndex = i - 1;

                if (nums[i] < nums.Length)
                    nextIndex = i + 1;

                if (nums[i] > nums[previousIndex] && nums[i] > nums[nextIndex])
                {
                    peakElement = i;
                    break;
                }
            }
            return peakElement;
        }

        public int FindPeakElement1(int [] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                    return i;
            }
            return nums.Length - 1;
        }
    }   
}
