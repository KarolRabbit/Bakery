using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLogic
{
    public class Order
    {
        List<IProduct> orderList;

        public Order()
        {
            orderList = new List<IProduct>();
        }

        public void AddToOrder(IProduct product)
        {
            orderList.Add(product);
        }

        public void RemoveFromOrder(IProduct product)
        {
            orderList.Remove(product);
        }

        public decimal FinalizeOrder()
        {
            decimal price = 0;
            foreach (var product in orderList)
            {
                product.OrderProduct();
                price += product.ReadPrice();
            }
            return price;
        }
    }
}
