namespace State
{
    public class CompletedState : OrderState
    {
        public override void Change(Order order, OrderState state)
        {
            order.Message = "Failed. State is already completed";
         }
    }
}
