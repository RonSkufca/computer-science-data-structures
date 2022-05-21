namespace DataStructures.BinarySearchTree
{
	public class Node
	{
		public string Question { get; set; }

		/// <summary>
		/// Left side is defined as a yes
		/// </summary>
		public Node Yes { get; set; } = null;

		/// <summary>
		/// Right side is defined as a no
		/// </summary>
		public Node No { get; set; } = null;

		public Node(string question)
		{
			Question = question;
		}
	}

	public class Questions
	{
		private Node _root { get; set; } = null;

		public Questions()
		{

		}

		public void Insert(string question, QuestionResponse questionResponse)
		{
			Node currentNode = _root;

			Node newNode = new Node(question);

			// we are inserting the root or first node
			if(currentNode == null)
			{
				_root = newNode;
				return;
			}

			if(newNode.Question == currentNode.Question)
				return;

			// Yes responses will go on the left side of the node
			if(questionResponse == QuestionResponse.YES)
			{
				if(currentNode.Yes == null)
				{
					currentNode.Yes = newNode;
				}
				else
				{
					currentNode = currentNode.Yes;
					Insert(newNode.Question, questionResponse);
				}
			}
			else if(questionResponse == QuestionResponse.NO)
			{
				if(currentNode.No == null)
				{
					currentNode.No = newNode;
				}
				else
				{
					currentNode = currentNode.No;
					Insert(newNode.Question, questionResponse);
				}
			}			
		}		
	}

	public enum QuestionResponse
	{
		// Response was yes
		YES,
		// Response was no
		NO,
		// No response necessary
		NoResponseNecessary
	}
}
