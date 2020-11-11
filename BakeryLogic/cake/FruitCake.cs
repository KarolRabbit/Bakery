using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLogic.cake
{
    public enum Fruit { malinowe, truskawkowe, jabłkowe, jagodowe }

    class FruitCake : Cake
    {
        Fruit fruit;

        public FruitCake() : base()
        {
            this.fruit = Fruit.jabłkowe;
        }

        public FruitCake(int weight) : base(weight)
        {
            this.fruit = Fruit.jabłkowe;
        }
        public FruitCake(int weight, Fruit fruit) : this(weight)
        {
            this.fruit = fruit;
        }

        public override void OrderProduct()
        {
            base.OrderProduct();
            Console.WriteLine("{0,-45}{1,-40}", $"Ciasto {fruit}: {Weight}g --> {Price}zł/{minWeight}g", $"{ReadPrice()}zł");
        }
    }
}
