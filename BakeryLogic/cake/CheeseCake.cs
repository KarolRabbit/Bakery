using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLogic.cake
{
    class CheeseCake : Cake
    {
        public CheeseCake() : base() { }
        public CheeseCake(int weight) : base(weight) { }

        public override void OrderProduct()
        {
            base.OrderProduct();
            Console.WriteLine("{0,-45}{1,-40}", $"Sernik: {Weight}g --> {Price}zł/{minWeight}g", $"{ReadPrice()}zł");
        }
    }
}
