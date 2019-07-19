using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program // bir nesnenin ya da bir durumun mevcut durumunu kontrol etmek için kullanılır.
    {
        static void Main(string[] args)
        {

        }
    }

    interface IState
    {
        void DoAction(Context context);
    }

    class ModifiedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Modified");
        }
    }

    class DeleteState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Deleted");
        }
    }

    class AddedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Added");
        }
    }

    class Context
    {
        private IState _state;

        public void SetState(IState state)
        {
            _state = state;                            // context'in statesini set etmiş oluyoruz.
        }

        public IState GetState()
        {
            return _state;
        }
    }
}
