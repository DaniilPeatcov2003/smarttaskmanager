using smarttaskmanager.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smarttaskmanager.Command
{
    public class TaskInvoker
    {
        private Stack<TaskMemento> _undoStack = new Stack<TaskMemento>();
        private Stack<TaskMemento> _redoStack = new Stack<TaskMemento>();

        private TaskReceiver _receiver;

        public TaskInvoker(TaskReceiver receiver)
        {
            _receiver = receiver;
        }

        public void ExecuteCommand(ICommand command)
        {
            _undoStack.Push(_receiver.CreateMemento());

            command.Execute();

            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                _redoStack.Push(_receiver.CreateMemento());

                var memento = _undoStack.Pop();
                _receiver.RestoreMemento(memento);
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                _undoStack.Push(_receiver.CreateMemento());

                var memento = _redoStack.Pop();
                _receiver.RestoreMemento(memento);
            }
        }
    }
}
