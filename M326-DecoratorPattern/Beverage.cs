using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M326_DecoratorPattern
{
    public abstract class Beverage
    {
        public string Description { get; set; } = "Unknown Beverage";
        virtual public string GetDescription()
        {
            return Description;
        }
        public abstract double GetPrice();
    }
}
