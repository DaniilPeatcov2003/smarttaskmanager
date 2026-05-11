using smarttaskmanager.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.Command
{
    public class RemoveTaskCommand : ICommand
    {
        private TaskReceiver _receiver;
        private TaskItem _task;

        public RemoveTaskCommand(TaskReceiver receiver, TaskItem task)
        {
            _receiver = receiver;
            _task = task;
        }

        public void Execute()
        {
            _receiver.Remove(_task);
        }

        public void Undo()
        {
            _receiver.Add(_task);
        }
    }
}    
