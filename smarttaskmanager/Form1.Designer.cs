namespace smarttaskmanager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTask = new TextBox();
            comboStrategy = new ComboBox();
            listBox1 = new ListBox();
            lblCount = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            btnNextState = new Button();
            btnUndo = new Button();
            btnRedo = new Button();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(204, 18);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(176, 27);
            txtTask.TabIndex = 0;
            // 
            // comboStrategy
            // 
            comboStrategy.FormattingEnabled = true;
            comboStrategy.Items.AddRange(new object[] { "None", "Base64", "Reverse" });
            comboStrategy.Location = new Point(411, 18);
            comboStrategy.Name = "comboStrategy";
            comboStrategy.Size = new Size(176, 28);
            comboStrategy.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(204, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(496, 124);
            listBox1.TabIndex = 2;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(204, 338);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(50, 20);
            lblCount.TabIndex = 3;
            lblCount.Text = "label1";
            lblCount.Click += lblCount_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(606, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(204, 217);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(350, 217);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNextState
            // 
            btnNextState.Location = new Point(493, 217);
            btnNextState.Name = "btnNextState";
            btnNextState.Size = new Size(94, 29);
            btnNextState.TabIndex = 7;
            btnNextState.Text = "Next State";
            btnNextState.UseVisualStyleBackColor = true;
            btnNextState.Click += btnNextState_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(204, 278);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(94, 29);
            btnUndo.TabIndex = 8;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.Location = new Point(350, 278);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(94, 29);
            btnRedo.TabIndex = 9;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = true;
            btnRedo.Click += btnRedo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRedo);
            Controls.Add(btnUndo);
            Controls.Add(btnNextState);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lblCount);
            Controls.Add(listBox1);
            Controls.Add(comboStrategy);
            Controls.Add(txtTask);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private ComboBox comboStrategy;
        private ListBox listBox1;
        private Label lblCount;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnClear;
        private Button btnNextState;
        private Button btnUndo;
        private Button btnRedo;
    }
}
