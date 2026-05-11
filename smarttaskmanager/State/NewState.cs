using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.State
{
    public class NewState : ITaskState
    {
        public void Handle(TaskItem task)
        {
            task.SetState(new InProgressState());
        }

        public string GetName() => "New";
    }
}
