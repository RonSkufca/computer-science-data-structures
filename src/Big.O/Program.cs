// See https://aka.ms/new-console-template for more information
using algorithms;

var bigO = new BigO();
//bigO.SumArrayBruteForceWay();
Console.WriteLine();
//bigO.SumArrayUsingCarlGaussFormula();

int[] arrayWithDuplicates = new int[13] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10, 11, 12 };
int[] arrayWithoutDuplicates = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
bigO.ArrayDuplicateFinder(arrayWithDuplicates);
Console.WriteLine();
bigO.ArrayDuplicateFinder(arrayWithoutDuplicates);
