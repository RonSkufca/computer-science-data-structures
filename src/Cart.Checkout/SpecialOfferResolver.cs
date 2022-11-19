namespace ShoppingCart
{
	public sealed class SpecialOfferResolver
	{
		private ICollection<Offer> _specialOffers;

		public SpecialOfferResolver(ICollection<Offer> specialOffers)
		{
			_specialOffers = specialOffers;
		}

		public void Resolve(char[] items)
		{
			var groups = from item in items
						 group item by item into g
						 select g;

			
		}
	}
}
