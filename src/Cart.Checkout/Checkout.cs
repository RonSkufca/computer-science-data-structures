using System.Collections.ObjectModel;

namespace ShoppingCart
{
    public sealed class Checkout
    {
        private const int A = 50;
        private const int B = 30;
        private const int C = 20;

        private ICollection<Offer> _specialOffers;

        public Checkout()
        {
            _specialOffers = new Collection<Offer>()
            {
                new Offer('A', 3, 130),
                new Offer('C', 2, 35)
            };
        }

        public int GetTotalPrice(ICollection<char> items)
        {
            if (!items.Any())
                return 0;

            var totalPrice = 0;

            items.ToList().ForEach(item =>
            {
                switch (item)
                {
                    case 'A':
                       totalPrice += A;
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

      
    }
}
