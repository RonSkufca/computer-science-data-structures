// See https://aka.ms/new-console-template for more information

using DataStructures;
using DataStructures.BinarySearchTree;

var questionTree = new Questions();
questionTree.Insert("During the last three years have you lived outside of Oregon for 60 or more consecutive days?", QuestionResponse.NoResponseNecessary);
questionTree.Insert("Please list the last three locations. Please include the city, state, and residence dates for all locations.", QuestionResponse.YES);
questionTree.Insert("Most recent city", QuestionResponse.NoResponseNecessary);


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
