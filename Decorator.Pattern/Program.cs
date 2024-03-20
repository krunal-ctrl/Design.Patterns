﻿using Decorator.Pattern;
using Decorator.Pattern.Condiments;

Beverage beverage = new Espresso();
Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

Beverage beverage2 = new DarkRoast();
beverage2 = new Mocha(beverage2);
beverage2 = new Mocha(beverage2);
beverage2 = new Whip(beverage2);
Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");