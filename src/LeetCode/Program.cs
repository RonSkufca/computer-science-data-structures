// See https://aka.ms/new-console-template for more information
using LeetCode;

int[] nums = { 1, 1, 2 };
int[] nums1 = {0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
var removeDuplicates = new RemoveDuplicatesFromSortedArray();
int duplicateRemoved = removeDuplicates.RemoveDuplicates(nums);
Console.WriteLine(duplicateRemoved);

duplicateRemoved = removeDuplicates.RemoveDuplicates(nums1);
Console.WriteLine(duplicateRemoved);
