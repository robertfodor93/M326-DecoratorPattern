using M326_DecoratorPattern;

Beverage beverage1 = new Espresso();

Beverage beverage2 = new Espresso();
beverage2 = new Milk(beverage2);
beverage2 = new Milk(beverage2);
beverage2 = new Chocolate(beverage2);


Console.WriteLine($"{beverage1.GetDescription()}: CHF {beverage1.GetPrice()}");
Console.WriteLine($"{beverage2.GetDescription()}: CHF {beverage2.GetPrice()}");
