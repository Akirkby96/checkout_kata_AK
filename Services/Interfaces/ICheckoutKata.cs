using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Kata.Services.Interfaces
{
    public interface ICheckoutKata
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Scan(string item);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetTotalPrice();
    }
}
