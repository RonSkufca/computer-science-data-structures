namespace ShoppingCart
{
	public sealed class Offer
	{
		private char _item;
		private int _quantity;
		private int _price;

		public char Item => _item;

		public int Quantity => _quantity;

		public int Price => _price;

		public Offer(char item, int quantity, int offerPrice)
		{
			_item = item;
			_quantity = quantity;
			_price = offerPrice;
		}
	}
}
