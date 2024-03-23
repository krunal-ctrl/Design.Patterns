namespace Decorator.Pattern;

public abstract class CondimentDecorator: Beverage
{
    protected Beverage Beverage = null!;

    public abstract override string Description { get; }
}