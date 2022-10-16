// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;
using LeetCode;

ICollection<int[]> testCases = new Collection<int[]>();

testCases.Add(new int[] { 1 });
testCases.Add(new int[] { 2, 1 });
testCases.Add(new int[] { 1, 2 });
testCases.Add(new int[] { 1, 2, 3, 1 });
testCases.Add(new int[] { 1, 2, 1, 3, 5, 6, 4 });
testCases.Add(new int[] { 3, 2, 1 });
testCases.Add(new int[] { 3, 1, 2 });



var peakElementFinder = new PeakElement();

foreach(int[] testCase in testCases)
{
	testCase.ToList().ForEach(item => Console.Write($"{item}, "));

	int indexOfPeakNumber = peakElementFinder.FindPeakElement1(testCase);
	Console.WriteLine($"PeakNumber Index '{indexOfPeakNumber}'");
}
