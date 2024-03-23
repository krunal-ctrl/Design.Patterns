namespace Decorator.Pattern.Condiments
{
    public class Soy(Beverage beverage) : CondimentDecorator
    {
        private readonly Beverage _beverage = beverage;

        public override double Cost()
        {
            return .15 + _beverage.Cost();
        }

        public override string Description => _beverage.Description + ", Soy";
    }
}
