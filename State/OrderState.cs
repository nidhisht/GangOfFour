namespace State
{
    public abstract class OrderState
    {
        public abstract void Change(Order order, OrderState state);
    }
}
