using System;

namespace State
{
    public class Order
    {
        public Order(OrderState state)
        {
            CurrentState = state;
        }

        public OrderState CurrentState { get; set; }
        public string Message { get; set; }

        public void ChangeState(OrderState state)
        {
            CurrentState.Change(this, state);           

            Console.WriteLine(
                "Current State: " + CurrentState.GetType().Name + 
                " , New state: " + state.GetType().Name + 
                " => Result:" + this.Message);
        }
    }
}
