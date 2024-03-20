namespace Decorator.Pattern;

public abstract class Beverage
{
    protected string Description = "Unknown Beverage";

    public string GetDescription()
    {
        return Description;
    }

    public abstract double Cost();
}