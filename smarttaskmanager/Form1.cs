using smarttaskmanager.Command;
using smarttaskmanager.Observer;
using smarttaskmanager.State;
using smarttaskmanager.Strategy;
using System;
using System.Windows.Forms;

namespace smarttaskmanager
{
    public partial class Form1 : Form, IObserver
    {
        private TaskReceiver receiver = new TaskReceiver();
        private TaskInvoker invoker;


        public Form1()
        {
            InitializeComponent();

            receiver.Attach(this);

            invoker = new TaskInvoker(receiver); 

            UpdateUI();
        }

        public void UpdateUIObserver()
        {
            UpdateUI();
        }

        private ITaskStrategy GetStrategy()
        {
            switch (comboStrategy.SelectedItem?.ToString())
            {
                case "Base64":
                    return new Base64Strategy();

                case "Reverse":
                    return new ReverseStrategy();

                default:
                    return new NoStrategy();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                var strategy = GetStrategy();

                // применяем стратегию к тексту
                var processed = strategy.Process(txtTask.Text);

                // создаём объект задачи (State Context)
                var task = new TaskItem(processed);

                // передаём TaskItem в команду
                var cmd = new AddTaskCommand(receiver, task);
                invoker.ExecuteCommand(cmd);

                txtTask.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is TaskItem task)
            {
                var cmd = new RemoveTaskCommand(receiver, task);
                invoker.ExecuteCommand(cmd);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var cmd = new ClearTasksCommand(receiver);
            invoker.ExecuteCommand(cmd);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            invoker.Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            invoker.Redo();
        }

        private void btnNextState_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is TaskItem task)
            {
                var cmd = new ChangeStateCommand(receiver, task);
                invoker.ExecuteCommand(cmd);
            }
        }

        private void UpdateUI()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = receiver.Tasks;

            lblCount.Text = $"Задач: {receiver.Tasks.Count}";
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}
