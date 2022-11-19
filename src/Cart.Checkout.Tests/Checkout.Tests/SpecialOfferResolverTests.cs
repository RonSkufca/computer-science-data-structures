using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Tests
{
	[TestClass]
	public sealed class SpecialOfferResolverTests
	{
		/// <summary>
		/// Scenario: Call item grouper to group all items in the cart
		///    Given: We have the following items 'a', 'b', 'a', 'c', 'a', 'a', 'c', 'd'
		///      And: We call the itemGrouper's group method
		///     Then: We should get back the following
		///           a | c
		///           
		/// </summary>
		[TestMethod]
		public void Group_Returns_Grouped_Items()
		{
			var specialOffers = new Collection<Offer>()
			{
				new Offer('A', 3, 130),
				new Offer('C', 2, 35)
			};

			char[] items = new char[] {'a', 'b', 'a', 'c', 'a', 'a', 'c', 'd'};

			var grouper = new SpecialOfferResolver(specialOffers);

			grouper.Resolve(items);

		}
	}
}
