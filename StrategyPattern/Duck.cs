namespace StrategyPattern
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public Duck()
        {

        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            _flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            _quackBehavior = qb;
        }

        public static void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
