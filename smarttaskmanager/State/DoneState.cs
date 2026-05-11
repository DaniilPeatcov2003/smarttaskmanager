using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.State
{
    public class DoneState : ITaskState
    {
        public void Handle(TaskItem task)
        {

        }

        public string GetName() => "Done";
    }
}
