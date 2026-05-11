using smarttaskmanager.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.Memento
{
    public class TaskMemento
    {
        public List<TaskItem> State { get; }

        public TaskMemento(List<TaskItem> tasks)
        {
            // глубокая копия списка
            State = tasks.Select(t => Clone(t)).ToList();
        }

        private TaskItem Clone(TaskItem task)
        {
            var copy = new TaskItem(task.Title);

            // восстанавливаем состояние
            switch (task.GetStateName())
            {
                case "In Progress":
                    copy.SetState(new InProgressState());
                    break;
                case "Done":
                    copy.SetState(new DoneState());
                    break;
            }

            return copy;
        }
    }
}
