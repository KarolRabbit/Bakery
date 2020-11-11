using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLogic.drink
{
    enum CoffeSize { small, big }
    class Coffe : Drink
    {
        bool milk;
        CoffeSize coffeSize;
        private decimal milkPrice = 2;

        public Coffe()
        {
            this.milk = false;
            this.coffeSize = CoffeSize.small;
        }

        public Coffe(bool milk)
        {
            this.milk = milk;
            this.coffeSize = CoffeSize.small;
        }

        public Coffe(bool milk, CoffeSize coffeSize)
        {
            this.milk = milk;
            this.coffeSize = coffeSize;
        }

        public override void OrderProduct()
        {
            base.OrderProduct();
            Console.WriteLine("{0,-45}{1,-40}", $"Kawa{((milk == true) ? " z mlekiem: " : ": ")}{(coffeSize == CoffeSize.small ? "mała" : "duża")}", $"{ReadPrice()}zł");
        }

        public override decimal ReadPrice()
        {
            decimal price = (coffeSize == CoffeSize.big) ? 2 : 0;
            price += ((milk == true) ? (this.price + milkPrice) : this.price);
            return price;
        }
    }
}
