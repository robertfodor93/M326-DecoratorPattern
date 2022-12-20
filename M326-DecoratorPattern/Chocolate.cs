using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M326_DecoratorPattern
{
    public class Chocolate : CondimentDecorator
    {
        public Chocolate(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Chocolate"; 
        }

        public override double GetPrice()
        {
            return beverage.GetPrice() + 0.40;
        }
    }
}
