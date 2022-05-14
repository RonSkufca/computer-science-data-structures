namespace DataStructures
{
	internal class Node
	{
		private string _myValue;
		private Node? _next;

		internal string Value
		{
			get { return _myValue; }
			set { _myValue = value; }
		}
		internal Node? Next 
		{
			get { return _next; }
			set { _next = value; }
		}

		/// <summary>
		/// Creates a new node and sets the value to what was passed in
		/// Sets the next to null
		/// </summary>
		public Node(string value)
		{
			_myValue = value;
			_next = null;
		}		
	}

	internal class LinkedList
	{
		private Node _head;
		
		internal Node Insert(string value)
		{
			// the list is empty we are inserting the first item
			// the head and tail both point to the same thing
			if(_head == null)
			{
				Console.WriteLine($"Creating first node with value {value}.");
				_head = new Node(value);				
			}
			else
			{
				Node tail = FindTail();
				tail.Next = new Node(value);
			}

			return _head;
		}

		public void PrintList()
		{
			int index = 0;
			Node current = _head;
			while(current.Next != null)
			{
				Console.WriteLine($"List node {index} contains {current.Value}");
				current = current.Next;
				index++;
			}

			Console.WriteLine($"List node {index} contains {current.Value}");
		}

		private Node FindTail()
		{
			Node current = _head;

			while(current.Next != null)
			{
				current = current.Next;
			}

			Console.WriteLine($"Node '{current.Value}' is the last item in the list.");
			return current;
		}

		
	}
}
