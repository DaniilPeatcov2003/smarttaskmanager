using smarttaskmanager.State;
using smarttaskmanager.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.Command
{
    public class AddTaskCommand : ICommand
    {
        private TaskReceiver _receiver;
        private TaskItem _task;

        public AddTaskCommand(TaskReceiver receiver, TaskItem task)
        {
            _receiver = receiver;
            _task = task;
        }

        public void Execute()
        {
            _receiver.Add(_task);
        }

        public void Undo()
        {
            _receiver.Remove(_task);
        }
    }
}
