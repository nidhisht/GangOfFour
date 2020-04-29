namespace State
{
    public class InProgressState : OrderState
    {
        public override void Change(Order order, OrderState state)
        {
            if (state.GetType().Equals(typeof(CompletedState)))
            {
                order.CurrentState = new CompletedState();
                order.Message = "State changed successfully";
                
            }
            else
            {
                order.Message = "Failed. Invalid state";
            }
        }
    }
}
