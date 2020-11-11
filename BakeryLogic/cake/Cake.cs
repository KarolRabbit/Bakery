using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLogic.cake
{
    public abstract class Cake : IProduct
    {
        protected int weight;
        protected bool isOrdered;
        protected decimal price = 6;
        public const int minWeight = 100;

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
            }
        }

        protected int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if ((isOrdered != true) && (value >= minWeight)) weight = value;
            }
        }

        public Cake()
        {
            Weight = minWeight;

        }
        public Cake(int weight) : this()
        {
            Weight = weight;
        }

        public virtual void OrderProduct()
        {
            isOrdered = true;
        }

        public decimal ReadPrice()
        {
            return weight / minWeight * price;
        }
    }
}
