namespace Nimble
{
    partial class Task_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            task_LB = new ListBox();
            edittasks_Btn = new Button();
            addtask_Btn = new Button();
            task_Label = new Label();
            overviewtitle_Panel = new Panel();
            overviewtitle_Label = new Label();
            TaskID_Label = new Label();
            TD_Label = new Label();
            TaskDesc_RTB = new RichTextBox();
            DueDate_Label = new Label();
            StartDate_Label = new Label();
            TaskEstEffort_Label = new Label();
            overviewtitle_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // task_LB
            // 
            task_LB.BackColor = Color.FromArgb(254, 248, 235);
            task_LB.FormattingEnabled = true;
            task_LB.ItemHeight = 15;
            task_LB.Location = new Point(30, 105);
            task_LB.Name = "task_LB";
            task_LB.Size = new Size(120, 439);
            task_LB.TabIndex = 9;
            task_LB.Click += task_LB_Click;
            // 
            // edittasks_Btn
            // 
            edittasks_Btn.AutoSize = true;
            edittasks_Btn.BackColor = Color.FromArgb(21, 35, 57);
            edittasks_Btn.BackgroundImageLayout = ImageLayout.None;
            edittasks_Btn.FlatAppearance.BorderSize = 0;
            edittasks_Btn.FlatStyle = FlatStyle.Flat;
            edittasks_Btn.Font = new Font("Helvetica 2 BQ ", 9.749999F);
            edittasks_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            edittasks_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            edittasks_Btn.Location = new Point(208, 554);
            edittasks_Btn.Margin = new Padding(10, 50, 10, 10);
            edittasks_Btn.Name = "edittasks_Btn";
            edittasks_Btn.Size = new Size(146, 25);
            edittasks_Btn.TabIndex = 8;
            edittasks_Btn.Text = "Edit Task";
            edittasks_Btn.TextAlign = ContentAlignment.MiddleLeft;
            edittasks_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            edittasks_Btn.UseVisualStyleBackColor = false;
            edittasks_Btn.Click += edittasks_Btn_Click;
            // 
            // addtask_Btn
            // 
            addtask_Btn.AutoSize = true;
            addtask_Btn.BackColor = Color.FromArgb(21, 35, 57);
            addtask_Btn.BackgroundImageLayout = ImageLayout.None;
            addtask_Btn.FlatAppearance.BorderSize = 0;
            addtask_Btn.FlatStyle = FlatStyle.Flat;
            addtask_Btn.Font = new Font("Helvetica 2 BQ ", 9.749999F);
            addtask_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            addtask_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            addtask_Btn.Location = new Point(27, 554);
            addtask_Btn.Margin = new Padding(10, 50, 10, 10);
            addtask_Btn.Name = "addtask_Btn";
            addtask_Btn.Size = new Size(146, 25);
            addtask_Btn.TabIndex = 3;
            addtask_Btn.Text = "Add Task";
            addtask_Btn.TextAlign = ContentAlignment.MiddleLeft;
            addtask_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addtask_Btn.UseVisualStyleBackColor = false;
            addtask_Btn.Click += addtask_Btn_Click;
            // 
            // task_Label
            // 
            task_Label.AutoSize = true;
            task_Label.BackColor = Color.Transparent;
            task_Label.FlatStyle = FlatStyle.Flat;
            task_Label.Font = new Font("Helvetica 2 BQ ", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            task_Label.ForeColor = Color.FromArgb(253, 248, 225);
            task_Label.Location = new Point(27, 71);
            task_Label.Margin = new Padding(3);
            task_Label.Name = "task_Label";
            task_Label.Padding = new Padding(0, 0, 0, 5);
            task_Label.Size = new Size(51, 28);
            task_Label.TabIndex = 1;
            task_Label.Text = "Tasks";
            // 
            // overviewtitle_Panel
            // 
            overviewtitle_Panel.Controls.Add(overviewtitle_Label);
            overviewtitle_Panel.Dock = DockStyle.Top;
            overviewtitle_Panel.Location = new Point(0, 0);
            overviewtitle_Panel.Name = "overviewtitle_Panel";
            overviewtitle_Panel.Size = new Size(960, 42);
            overviewtitle_Panel.TabIndex = 3;
            // 
            // overviewtitle_Label
            // 
            overviewtitle_Label.AutoSize = true;
            overviewtitle_Label.BackColor = Color.Transparent;
            overviewtitle_Label.Dock = DockStyle.Left;
            overviewtitle_Label.FlatStyle = FlatStyle.Flat;
            overviewtitle_Label.Font = new Font("Helvetica 2 BQ ", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            overviewtitle_Label.ForeColor = Color.FromArgb(245, 215, 140);
            overviewtitle_Label.Location = new Point(0, 0);
            overviewtitle_Label.Name = "overviewtitle_Label";
            overviewtitle_Label.Padding = new Padding(20, 5, 0, 0);
            overviewtitle_Label.Size = new Size(95, 34);
            overviewtitle_Label.TabIndex = 0;
            overviewtitle_Label.Text = "TASKS";
            // 
            // TaskID_Label
            // 
            TaskID_Label.AutoSize = true;
            TaskID_Label.BackColor = Color.Transparent;
            TaskID_Label.FlatStyle = FlatStyle.Flat;
            TaskID_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskID_Label.ForeColor = Color.FromArgb(253, 248, 225);
            TaskID_Label.Location = new Point(208, 105);
            TaskID_Label.Margin = new Padding(3);
            TaskID_Label.Name = "TaskID_Label";
            TaskID_Label.Padding = new Padding(0, 0, 0, 5);
            TaskID_Label.Size = new Size(56, 21);
            TaskID_Label.TabIndex = 16;
            TaskID_Label.Text = "Task ID:";
            // 
            // TD_Label
            // 
            TD_Label.AutoSize = true;
            TD_Label.BackColor = Color.Transparent;
            TD_Label.FlatStyle = FlatStyle.Flat;
            TD_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TD_Label.ForeColor = Color.FromArgb(253, 248, 225);
            TD_Label.Location = new Point(208, 132);
            TD_Label.Margin = new Padding(3);
            TD_Label.Name = "TD_Label";
            TD_Label.Padding = new Padding(0, 0, 0, 5);
            TD_Label.Size = new Size(118, 21);
            TD_Label.TabIndex = 15;
            TD_Label.Text = "Task Description: ";
            // 
            // TaskDesc_RTB
            // 
            TaskDesc_RTB.BackColor = Color.FromArgb(254, 248, 235);
            TaskDesc_RTB.BorderStyle = BorderStyle.None;
            TaskDesc_RTB.Location = new Point(223, 159);
            TaskDesc_RTB.Name = "TaskDesc_RTB";
            TaskDesc_RTB.ReadOnly = true;
            TaskDesc_RTB.ScrollBars = RichTextBoxScrollBars.Vertical;
            TaskDesc_RTB.Size = new Size(664, 85);
            TaskDesc_RTB.TabIndex = 17;
            TaskDesc_RTB.Text = "";
            // 
            // DueDate_Label
            // 
            DueDate_Label.AutoSize = true;
            DueDate_Label.BackColor = Color.Transparent;
            DueDate_Label.FlatStyle = FlatStyle.Flat;
            DueDate_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DueDate_Label.ForeColor = Color.FromArgb(253, 248, 225);
            DueDate_Label.Location = new Point(208, 317);
            DueDate_Label.Margin = new Padding(3);
            DueDate_Label.Name = "DueDate_Label";
            DueDate_Label.Padding = new Padding(0, 0, 0, 5);
            DueDate_Label.Size = new Size(73, 21);
            DueDate_Label.TabIndex = 20;
            DueDate_Label.Text = "Due Date: ";
            // 
            // StartDate_Label
            // 
            StartDate_Label.AutoSize = true;
            StartDate_Label.BackColor = Color.Transparent;
            StartDate_Label.FlatStyle = FlatStyle.Flat;
            StartDate_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartDate_Label.ForeColor = Color.FromArgb(253, 248, 225);
            StartDate_Label.Location = new Point(208, 290);
            StartDate_Label.Margin = new Padding(3);
            StartDate_Label.Name = "StartDate_Label";
            StartDate_Label.Padding = new Padding(0, 0, 0, 5);
            StartDate_Label.Size = new Size(78, 21);
            StartDate_Label.TabIndex = 19;
            StartDate_Label.Text = "Start Date: ";
            // 
            // TaskEstEffort_Label
            // 
            TaskEstEffort_Label.AutoSize = true;
            TaskEstEffort_Label.BackColor = Color.Transparent;
            TaskEstEffort_Label.FlatStyle = FlatStyle.Flat;
            TaskEstEffort_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskEstEffort_Label.ForeColor = Color.FromArgb(253, 248, 225);
            TaskEstEffort_Label.Location = new Point(208, 263);
            TaskEstEffort_Label.Margin = new Padding(3);
            TaskEstEffort_Label.Name = "TaskEstEffort_Label";
            TaskEstEffort_Label.Padding = new Padding(0, 0, 0, 5);
            TaskEstEffort_Label.Size = new Size(146, 21);
            TaskEstEffort_Label.TabIndex = 18;
            TaskEstEffort_Label.Text = "Task Estimated Effort: ";
            // 
            // Task_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 90, 130);
            Controls.Add(DueDate_Label);
            Controls.Add(StartDate_Label);
            Controls.Add(TaskEstEffort_Label);
            Controls.Add(TaskDesc_RTB);
            Controls.Add(TaskID_Label);
            Controls.Add(TD_Label);
            Controls.Add(task_LB);
            Controls.Add(edittasks_Btn);
            Controls.Add(overviewtitle_Panel);
            Controls.Add(addtask_Btn);
            Controls.Add(task_Label);
            Name = "Task_UC";
            Size = new Size(960, 615);
            overviewtitle_Panel.ResumeLayout(false);
            overviewtitle_Panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button edittasks_Btn;
        private Button addtask_Btn;
        private Label task_Label;
        private Panel overviewtitle_Panel;
        private Label overviewtitle_Label;
        private ListBox task_LB;
        private Label TaskID_Label;
        private Label TD_Label;
        private RichTextBox TaskDesc_RTB;
        private Label DueDate_Label;
        private Label StartDate_Label;
        private Label TaskEstEffort_Label;
    }
}
