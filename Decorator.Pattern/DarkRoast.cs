namespace Decorator.Pattern;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast";
    }
    public override double Cost()
    {
        return 1.2;
    }
}