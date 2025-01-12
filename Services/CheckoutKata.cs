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
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Scan(string item)
        {
            throw new System.NotImplementedException();
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
