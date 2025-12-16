namespace DecoratorMethodClass
{
    public abstract class GreetingCard
    {
        public abstract string GetDescription();
        public abstract decimal GetCost();
    }

    public class SimpleGreetingCard : GreetingCard
    {
        public override string GetDescription() => "Звичайна вітальна листівка";

        public override decimal GetCost() => 10.00m;
    }

    public abstract class GreetingCardDecorator : GreetingCard
    {
        protected GreetingCard _card;

        protected GreetingCardDecorator(GreetingCard card)
        {
            _card = card;
        }

        public override string GetDescription() => _card.GetDescription();

        public override decimal GetCost() => _card.GetCost();
    }

    public class RibbonDecorator : GreetingCardDecorator
    {
        public RibbonDecorator(GreetingCard card) : base(card) { }

        public override string GetDescription() => base.GetDescription() + " + з атласною стрічкою";

        public override decimal GetCost() => base.GetCost() + 15.00m;
    }

    public class FlowersDecorator : GreetingCardDecorator
    {
        public FlowersDecorator(GreetingCard card) : base(card) { }

        public override string GetDescription() => base.GetDescription() + " + з живими квітами";

        public override decimal GetCost() => base.GetCost() + 30.00m;
    }

    public class FrameDecorator : GreetingCardDecorator
    {
        public FrameDecorator(GreetingCard card) : base(card) { }

        public override string GetDescription() => base.GetDescription() + " + з декоративною рамкою";

        public override decimal GetCost() => base.GetCost() + 20.00m;
    }
}