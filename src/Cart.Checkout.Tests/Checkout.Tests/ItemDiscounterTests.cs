using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Tests
{
	[TestClass]
	public sealed class ItemDiscounterTests
	{
		/// <summary>
		/// Scenario: Apply disounts to total
		///    Given: We have the following items 'a', 'b', 'a', 'c', 'a', 'a', 'c', 'd'
		///      And: Items a and c are eligible for discounts
		///      And: We call the item discounter to calculate the total discount
		///     Then: The total discount should be 165
		/// </summary>
		[TestMethod]
		public void Calculate_Discount_Returns_Total_Discount()
		{
			var specialOffers = new Collection<Offer>()
			{
				new Offer('A', 3, 130),
				new Offer('C', 2, 35)
			};

			char[] items = new char[] {'A', 'B', 'A', 'C', 'A', 'A', 'C', 'D'};

			var grouper = new ItemDiscounter(specialOffers);

			var priceWithDiscountsApplied = grouper.GetTotalDiscount(items);

			Assert.AreEqual(165, priceWithDiscountsApplied);
		}
	}
}
