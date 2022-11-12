using System.Collections.ObjectModel;

namespace DataStructures.LinkedList
{
	public class CustomLinkedList
	{
		private Node? _list;		

		public Node? List => _list;

		public CustomLinkedList() => _list = null;

		public void Append(string item)
		{
			Node? lastNode = GetLast();

			// list is empty
			if (lastNode == null)
				_list = new Node() { Value = item };
			else
				lastNode.Next = new Node() { Value = item };
		}

		public void Delete(Node node)
		{
			if (_list == null)
				return;

			Node? previous = null;
			Node? current = _list;
			Node? next = current.Next;

			// item is the first item, overrite it with next
			if (current.Value == node.Value)
			{
				_list = current.Next;
				return;
			}

			while (current.Next != null)
			{
				if(current.Value == node.Value)
				{
					
					previous.Next = next;
				}
				else
				{
					previous = current;
					current = current.Next;
					next = current.Next;
				}
			}
		}

		public Node? Get(string value)
		{
			if (_list == null)
				return null;

			Node? current = _list;

			while(current.Next != null)
			{
				if (current.Value == value)
					return current;
				else
					current = current.Next;
			}

			// we are at the last node. one final check
			if (current.Value == value)
				return current;

			// we did not find anything
			return null;
		}		

		private Node? GetLast()
		{
			if (_list == null)
				return null;

			Node current = _list;

			while(current.Next != null)
				current = current.Next;
			
			return current;
		}		
	}

	public class Node
	{
		public string? Value { get; set; }

		public Node? Next { get; set; }
	}
}
