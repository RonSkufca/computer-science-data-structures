namespace DataStructures.BinarySearchTree
{
	public class Node
	{
		public double QuestionNumber { get; set; }

		public string QuestionText { get; set; }

		/// <summary>
		/// Left side is defined as a yes
		/// </summary>
		public Node Yes { get; set; } = null;

		/// <summary>
		/// Right side is defined as a no
		/// </summary>
		public Node No { get; set; } = null;

		public Node(double questionNumber, string questionText)
		{
			QuestionNumber = questionNumber;
			QuestionText = questionText;
		}
	}

	public class Questions
	{
		private Node _root { get; set; } = null;

		public Questions()
		{

		}

		public void InsertQuestion(double questionNumber, string questionText)
		{
			Node currentNode = _root;

			Node newNode = new Node(questionNumber, questionText);

			// we are inserting the root or first node
			if(currentNode == null)
			{
				_root = newNode;
				return;
			}

			if(newNode.QuestionText == currentNode.QuestionText)
				return;

			// Yes responses will go on the left side of the node
			//if(questionResponse == QuestionResponse.YES)
			//{
			//	if(currentNode.Yes == null)
			//	{
			//		currentNode.Yes = newNode;
			//	}
			//	else
			//	{
			//		currentNode = currentNode.Yes;
			//		Insert(questionNumber, newNode.Question);
			//	}
			//}
			//else if(questionResponse == QuestionResponse.NO)
			//{
			//	if(currentNode.No == null)
			//	{
			//		currentNode.No = newNode;
			//	}
			//	else
			//	{
			//		currentNode = currentNode.No;
			//		Insert(newNode.Question);
			//	}
			//}			
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
