using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.State
{
    public class InProgressState : ITaskState
    {
        public void Handle(TaskItem task)
        {
            // переход в Done
            task.SetState(new DoneState());
        }

        public string GetName() => "In Progress";
    }
}
