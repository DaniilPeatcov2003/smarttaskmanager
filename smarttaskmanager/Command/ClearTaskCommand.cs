using smarttaskmanager.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.Command
{
    public class ClearTasksCommand : ICommand
    {
        private TaskReceiver _receiver;

        // теперь храним TaskItem
        private List<TaskItem> _backup;

        public ClearTasksCommand(TaskReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            // копируем список задач
            _backup = new List<TaskItem>(_receiver.Tasks);

            _receiver.Clear();
        }

        public void Undo()
        {
            foreach (var task in _backup)
            {
                _receiver.Add(task);
            }
        }
    }
}
