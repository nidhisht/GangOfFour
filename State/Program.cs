using System;

namespace State
{
    class Program
    {
        /// <summary>
        /// State Transition flow:
        /// 
        /// Draft -> In progress -> Complete
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Order order = new Order(new DraftState());
            order.ChangeState(new CompletedState());    //fail
            order.ChangeState(new InProgressState());   //success
            order.ChangeState(new DraftState());        //fail
            order.ChangeState(new CompletedState());    //success
            order.ChangeState(new InProgressState());   //fail
            Console.Read();
        }
    }
}
