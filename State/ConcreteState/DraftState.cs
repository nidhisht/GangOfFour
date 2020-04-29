namespace State
{
    public class DraftState : OrderState
    {
        public override void Change(Order order, OrderState state)
        {
            if(state.GetType().Equals(typeof(CompletedState)))
            {
                order.Message = "Failed. Cannot move directly to Completed state";                
            }
            else if (state.GetType().Equals(typeof(InProgressState)))
            {
                order.CurrentState = new InProgressState();
                order.Message = "State changed successfully";
            }
        }
    }
}
