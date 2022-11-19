using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System.Collections.ObjectModel;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CheckoutTests
    {
        /// <summary>
        /// Scenario: Checkout accepts n number of items
        ///    Given: 3 number of items scanned in
        ///      And: Clerk requests a price check
        ///     Then: We return the total of the 3 items which is 100
        /// </summary>
        [TestMethod]
        public void Checkout_Accepts_Items()
        {
            var checkout = new Checkout();

            var items = new Collection<char>() { 'A', 'B', 'C' };

            var totalPrice = checkout.GetTotalPrice(items);

            Assert.AreEqual(totalPrice, 100);
        }

        /// <summary>
        /// Scenario: Checkout accepts 0 items which then cost nothing
        ///    Given: 0 number of items scanned in
        ///      And: Clerk requests a price check
        ///     Then: We return 0 cost
        /// </summary>
        [TestMethod]
        public void Checkout_Rejects_No_Cost()
        {

            var checkout = new Checkout();

            var items = new Collection<char>() { };

            var totalPrice = checkout.GetTotalPrice(items);

            Assert.AreEqual(0, totalPrice);
        }

        [TestMethod]
        public void Checkout_Calculates_Special_Offer_Total()
        {
            var checkout = new Checkout();

            var items = new Collection<char>() { 'A', 'A', 'A' };

            var totalPrice = checkout.GetTotalPrice(items);

            Assert.AreEqual(130, totalPrice);
        }
    }
}