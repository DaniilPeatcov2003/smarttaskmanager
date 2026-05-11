using smarttaskmanager.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.Command
{
    public class ChangeStateCommand : ICommand
    {
        private TaskReceiver _receiver;
        private TaskItem _task;

        public ChangeStateCommand(TaskReceiver receiver, TaskItem task)
        {
            _receiver = receiver;
            _task = task;
        }

        public void Execute()
        {
            _receiver.ChangeState(_task);
        }

        public void Undo()
        {
            // можно не реализовывать или сделать позже через Memento
        }
    }
}
