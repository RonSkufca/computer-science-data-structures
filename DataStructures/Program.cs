// See https://aka.ms/new-console-template for more information
using DataStructures;

var fib = new Fibonacci();

while(!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
{
	var data = Console.ReadLine();
	Int32.TryParse(data, out int n);
	int fibResult = fib.SlowWay(n);
	Console.WriteLine($"Fibonacci Result {fibResult}");
}



//var myList = new LinkedList();
//myList.Insert("Ron");
//myList.Insert("Skufca");
//myList.Insert("Is");
//myList.Insert("the");
//myList.Insert("greatest");
//myList.Insert("mind");
//myList.Insert("in");
//myList.Insert("the");
//myList.Insert("universe");
//myList.Insert(".");

//myList.TryDelete("Ron");
//myList.PrintList();
//Console.WriteLine();

//myList.TryDelete("the");
//myList.PrintList();

//var nodeFound = myList.TryFind("in", out Node foundNode);
//var nodeValue = (foundNode.Value != null) ? foundNode.Value : "not found";
//Console.WriteLine($"Node found '{nodeFound}'. Contains value '{foundNode.Value}'");

//nodeFound = myList.TryFind("mark", out foundNode);
//nodeValue = (foundNode != null) ? foundNode.Value : "not found";
//Console.WriteLine($"Node found '{nodeFound}'. Contains value '{nodeValue}'");

//nodeFound = myList.TryFind("universe", out foundNode);
//nodeValue = (foundNode != null) ? foundNode.Value : "not found";
//Console.WriteLine($"Node found '{nodeFound}'. Contains value '{nodeValue}'");
