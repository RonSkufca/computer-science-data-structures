using System.Collections.ObjectModel;

namespace ShoppingCart
{
    public sealed class Checkout
    {
        private const int A = 50;
        private const int B = 30;
        private const int C = 20;

        private ICollection<Offer> _offers;

        public Checkout()
        {
            _offers = new Collection<Offer>()
            {
                new Offer('A', 3, 130)
            };
        }

        public int GetTotalPrice(ICollection<char> items)
        {
            if (!items.Any())
                return 0;

            var totalPrice = 0;

            if(EligibleForSpecialOffer(items))
                

            items.ToList().ForEach(item =>
            {
                switch (item)
                {
                    case 'A':
                        if (EligibleForSpecialOffer(items))
                        {
                            totalPrice += _offers.FirstOrDefault(offer => offer.Item == 'A').Price;
                        }
                        else
                        {
                            totalPrice += A;
                        }                            
                        break;
                    case 'B':
                        totalPrice += B;
                        break;
                    case 'C':
                        totalPrice += C;
                        break;
                    default:
                        totalPrice += 0;
                        break;

                }
            });

            return totalPrice;
        }

        private bool EligibleForSpecialOffer(ICollection<char> items)
        {
            if (!items.Any())
                return false;

            // TODO: Need to find 3 of the same items in the collection which match any item in the Offers collection
            var offersFound = items.Where(item => item.Equals('A'));

            if(offersFound.Count() == 3)
                return true;

            return false;
        }

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
}
