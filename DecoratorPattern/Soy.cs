namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", Soy";

        public override double Cost()
        {
            return _beverage.Cost() + .15;
        }
    }
}
