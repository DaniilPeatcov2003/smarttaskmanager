using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.State
{
    public interface ITaskState
    {
        void Handle(TaskItem task);
        string GetName();
    }
}
