using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M326_DecoratorPattern
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }

        public override double GetPrice()
        {
            return beverage.GetPrice() + 0.10;
        }
    }
}
