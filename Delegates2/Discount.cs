using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{

    public class Discount
    {
        public delegate void DiscountNumber(decimal discount);
        public delegate decimal PriceTotal(List<ShoppingItems> shoppingItems);
        List<ShoppingItems> items = new List<ShoppingItems>(); 
        
        public void Test(decimal subtotal)
        {
            
            foreach (var item in items)
            {
                subtotal += item.Price;
            }
        }
    }
}
