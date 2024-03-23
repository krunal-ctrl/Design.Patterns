namespace Decorator.Pattern.Condiments;

public class Whip(Beverage beverage) : CondimentDecorator
{
    private readonly Beverage _beverage = beverage;

    public override string Description => _beverage.Description + ", Whip";

    public override double Cost()
    {
        return _beverage.Cost() + .60;

    }
}