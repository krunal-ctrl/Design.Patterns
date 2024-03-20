namespace Decorator.Pattern.Condiments;

public class Mocha: CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        this.Beverage = beverage;
    }
    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
        return Beverage.Cost() + .20;
    }
}