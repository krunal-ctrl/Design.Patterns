namespace Decorator.Pattern.Condiments;

public class Whip: CondimentDecorator
{
    public Whip(Beverage beverage)
    {
        Beverage = beverage;
    }
    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
        return Beverage.Cost() + .60;

    }
}