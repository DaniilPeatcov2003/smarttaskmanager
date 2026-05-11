using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.State
{
    public class TaskItem
    {
        public string Title { get; set; }

        private ITaskState _state;

        public TaskItem(string title)
        {
            Title = title;
            _state = new NewState();
        }

        public void SetState(ITaskState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }

        public string GetStateName()
        {
            return _state.GetName();
        }

        public override string ToString()
        {
            return $"{Title} [{GetStateName()}]";
        }
    }
}
