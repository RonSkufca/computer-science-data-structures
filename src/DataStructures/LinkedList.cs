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

		internal bool TryFind(string value, out Node foundNode)
		{
			foundNode = Find(value);

			if(foundNode != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private Node Find(string value)
		{
			Node current = _head;

			while(current.Next != null)
			{
				if(current.Value == value)
				{
					return current;					
				}
				current = current.Next;
			}

			return null;
		}

		internal bool TryDelete(string value)
		{
			var node = Find(value);

			if(node == null)
			{
				return false;
			}
			else
			{
				Delete(node);
				return true;
			}
		}

		private void Delete(Node node)
		{
			Node current = _head;
			Node previous = _head;
			bool firstTime = true;

			while(current.Next != null)
			{
				// we found the node we wish to delete
				if(current.Value == node.Value)
				{
					// if we are deleting the head node we need to set the _head to current
					if(firstTime)
					{
						_head = current.Next;
						current = null;
						previous = null;
					}
					else
					{
						// set the previous node's next pointer to the current next
						// we need to link up previous to the current next to re-wire everything
						previous.Next = current.Next;
						current = null;
					}					
				}

				if(!firstTime)
				{
					previous = current;
					current = current.Next;
				}
				else
				{
					firstTime = false;
					current = current.Next;
				}
			}
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
			
			return current;
		}		
	}
}
