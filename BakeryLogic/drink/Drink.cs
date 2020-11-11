using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLogic.drink
{
    abstract class Drink : IProduct
    {
        protected bool isOrdered = false;
        protected decimal price = 5;

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public virtual void OrderProduct()
        {
            isOrdered = true;
        }

        public abstract decimal ReadPrice();

    }
}
