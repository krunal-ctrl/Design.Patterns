namespace Decorator.Pattern.Condiments;

public class Mocha(Beverage beverage) : CondimentDecorator
{
    private readonly Beverage _beverage = beverage;

    public override string Description => _beverage.Description + ", Mocha"; 

    public override double Cost()
    {
        return _beverage.Cost() + .20;
    }
}