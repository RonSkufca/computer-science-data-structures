namespace ShoppingCart
{
	public sealed class ItemDiscounter
	{
		private ICollection<Offer> _specialOffers;

		public ItemDiscounter(ICollection<Offer> specialOffers)
		{
			_specialOffers = specialOffers;
		}

		public bool DiscountsExist(char[] items)
		{
			var itemGroup = from item in items
							group item by item into g
							select (item:g, qty:g.Count());

			var itemList = itemGroup.Select(item => item.item.Key);

			var itemsWithOffers = itemList.Intersect(_specialOffers.Select(item => item.Item));

			return itemsWithOffers.Any();
		}

		public int GetTotalDiscount(char[] items)
		{
			IEnumerable<char> itemsWithOffers = BuildListOfDiscountedItems(items);

			return CalculateDiscount(itemsWithOffers);
		}

		private int CalculateDiscount(IEnumerable<char> itemsWithOffers)
		{
			if (!itemsWithOffers.Any())
				return 0;

			int runningTotal = 0;

			itemsWithOffers.ToList().ForEach(item =>
			{
				runningTotal += _specialOffers.Where(offer => offer.Item == item).FirstOrDefault().Price;
			});

			return runningTotal;
		}

		private IEnumerable<char> BuildListOfDiscountedItems(char[] items)
		{
			var itemGroup = from item in items
							group item by item into g
							select (item:g, qty:g.Count());

			var itemList = itemGroup.Select(item => item.item.Key);

			return itemList.Intersect(_specialOffers.Select(item => item.Item));
		}
	}
}
