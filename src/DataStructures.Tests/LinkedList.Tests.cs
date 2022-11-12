using DataStructures.LinkedList;

namespace DataStructures.Tests
{
	[TestClass]
	public class LinkedListTests
	{
		public LinkedListTests()
		{
		}

		[TestMethod]
		public void Get_Returns_List()
		{
			var linkedList = new CustomLinkedList();

			var node = linkedList.Get("ron");

			Assert.IsNull(node);
		}

		[TestMethod]
		public void Append_Node_At_End_Of_List()
		{
			var linkedList = new CustomLinkedList();

			linkedList.Append("ron");

			var foundNode = linkedList.Get("ron");

			Assert.IsNotNull(foundNode);
			Assert.AreEqual("ron", foundNode.Value);
			Assert.IsNull(foundNode.Next);
		}

		[TestMethod]
		public void Get_Item_From_Middle_Of_List()
		{
			var linkedList = new CustomLinkedList();

			linkedList.Append("ron");
			linkedList.Append("alan");
			linkedList.Append("skufca");

			var foundNode = linkedList.Get("alan");

			Assert.IsNotNull(foundNode);
			Assert.AreEqual("alan", foundNode.Value);
			Assert.IsNotNull(foundNode.Next);
		}

		[TestMethod]
		public void Delete_Item_From_FrontOf_List()
		{
			var linkedList = new CustomLinkedList();

			linkedList.Append("ron");
			linkedList.Append("alan");
			linkedList.Append("skufca");

			var foundNode = linkedList.Get("ron");

			linkedList.Delete(foundNode);

			var deletedNode = linkedList.Get("ron");

			Assert.IsNull(deletedNode);
		}

		[TestMethod]
		public void Delete_Item_From_Middle_Of_List()
		{
			var linkedList = new CustomLinkedList();

			linkedList.Append("ron");
			linkedList.Append("alan");
			linkedList.Append("skufca");

			var foundNode = linkedList.Get("alan");

			linkedList.Delete(foundNode);

			Assert.IsNotNull(foundNode);
			Assert.AreEqual("alan", foundNode.Value);
			Assert.IsNotNull(foundNode.Next);
		}
	}
}