using Checkout.Kata.Models;
using Checkout.Kata.Services.Interfaces;

namespace Checkout.Kata.Services
{
    public class CheckoutKata : ICheckoutKata
    {

        // Stores the pricing rules for each unique item
        private readonly Dictionary<string, PricingRule> _pricingRules;

        // Stores how many of each item has been scanned
        private readonly Dictionary<string, int> _scannedItems;

        /// <summary>
        /// Constructor for CheckoutKata
        /// </summary>
        /// <param name="pricingRules"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public CheckoutKata(Dictionary<string, PricingRule> pricingRules)
        {
            _pricingRules = pricingRules;
            _scannedItems = new Dictionary<string, int>();
        }


        /// <summary>
        /// Scans an item and increments the count of that item
        /// </summary>
        /// <param name="item"></param>
        public void Scan(string item)
        {
            // Check if item is null or empty
            if (string.IsNullOrEmpty(item))
                throw new ArgumentException("Item cannot be null or empty", nameof(item));

            // Check if we have pricing rules for this item
            if (!_pricingRules.ContainsKey(item))
                throw new ArgumentException($"No pricing rule found for item {item}", nameof(item));

            // Initialize counter for this item if it's the first time we're seeing it
            if (!_scannedItems.ContainsKey(item))
                _scannedItems[item] = 0;

            // Increment the count of this item
            _scannedItems[item]++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int GetTotalPrice()
        {
            throw new System.NotImplementedException();
        }


    }
}
