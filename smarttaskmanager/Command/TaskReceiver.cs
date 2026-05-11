using smarttaskmanager.Memento;
using smarttaskmanager.Observer;
using smarttaskmanager.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.Command
{
    public class TaskReceiver : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public List<TaskItem> Tasks { get; } = new List<TaskItem>();

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void Notify()
        {
            foreach (var o in _observers)
                o.UpdateUIObserver();
        }

        public void Add(TaskItem task)
        {
            Tasks.Add(task);
            Notify();
        }

        public void Remove(TaskItem task)
        {
            if (task.GetStateName() == "Done")
                return;

            Tasks.Remove(task);
            Notify();
        }

        public void Clear()
        {
            Tasks.Clear();
            Notify();
        }

        public void ChangeState(TaskItem task)
        {
            task.Request();
            Notify();
        }

        public TaskMemento CreateMemento()
        {
            return new TaskMemento(Tasks);
        }

        public void RestoreMemento(TaskMemento memento)
        {
            Tasks.Clear();
            Tasks.AddRange(memento.State);
            Notify();
        }
    }
}
