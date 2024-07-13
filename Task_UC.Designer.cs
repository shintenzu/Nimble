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
            overviewbody_Panel = new Panel();
            task_Panel = new Panel();
            edittasks_Btn = new Button();
            task_DGV = new DataGridView();
            addtask_Btn = new Button();
            task_Label = new Label();
            overviewtitle_Panel = new Panel();
            overviewtitle_Label = new Label();
            overviewbody_Panel.SuspendLayout();
            task_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)task_DGV).BeginInit();
            overviewtitle_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // overviewbody_Panel
            // 
            overviewbody_Panel.Controls.Add(task_Panel);
            overviewbody_Panel.Dock = DockStyle.Fill;
            overviewbody_Panel.Location = new Point(0, 42);
            overviewbody_Panel.Name = "overviewbody_Panel";
            overviewbody_Panel.Size = new Size(960, 573);
            overviewbody_Panel.TabIndex = 4;
            // 
            // task_Panel
            // 
            task_Panel.Controls.Add(edittasks_Btn);
            task_Panel.Controls.Add(task_DGV);
            task_Panel.Controls.Add(addtask_Btn);
            task_Panel.Controls.Add(task_Label);
            task_Panel.Location = new Point(24, 17);
            task_Panel.Margin = new Padding(10);
            task_Panel.Name = "task_Panel";
            task_Panel.Padding = new Padding(5);
            task_Panel.Size = new Size(926, 528);
            task_Panel.TabIndex = 5;
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
            edittasks_Btn.Location = new Point(186, 488);
            edittasks_Btn.Margin = new Padding(10, 50, 10, 10);
            edittasks_Btn.Name = "edittasks_Btn";
            edittasks_Btn.Size = new Size(146, 25);
            edittasks_Btn.TabIndex = 8;
            edittasks_Btn.Text = "Edit Task";
            edittasks_Btn.TextAlign = ContentAlignment.MiddleLeft;
            edittasks_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            edittasks_Btn.UseVisualStyleBackColor = false;
            // 
            // task_DGV
            // 
            task_DGV.BackgroundColor = Color.FromArgb(254, 248, 235);
            task_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            task_DGV.Location = new Point(5, 33);
            task_DGV.Name = "task_DGV";
            task_DGV.Size = new Size(896, 443);
            task_DGV.TabIndex = 7;
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
            addtask_Btn.Location = new Point(5, 488);
            addtask_Btn.Margin = new Padding(10, 50, 10, 10);
            addtask_Btn.Name = "addtask_Btn";
            addtask_Btn.Size = new Size(146, 25);
            addtask_Btn.TabIndex = 3;
            addtask_Btn.Text = "Add Task";
            addtask_Btn.TextAlign = ContentAlignment.MiddleLeft;
            addtask_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addtask_Btn.UseVisualStyleBackColor = false;
            // 
            // task_Label
            // 
            task_Label.AutoSize = true;
            task_Label.BackColor = Color.Transparent;
            task_Label.Dock = DockStyle.Top;
            task_Label.FlatStyle = FlatStyle.Flat;
            task_Label.Font = new Font("Helvetica 2 BQ ", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            task_Label.ForeColor = Color.FromArgb(253, 248, 225);
            task_Label.Location = new Point(5, 5);
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
            // Task_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 90, 130);
            Controls.Add(overviewbody_Panel);
            Controls.Add(overviewtitle_Panel);
            Name = "Task_UC";
            Size = new Size(960, 615);
            overviewbody_Panel.ResumeLayout(false);
            task_Panel.ResumeLayout(false);
            task_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)task_DGV).EndInit();
            overviewtitle_Panel.ResumeLayout(false);
            overviewtitle_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel overviewbody_Panel;
        private Panel task_Panel;
        private Button edittasks_Btn;
        private DataGridView task_DGV;
        private Button addtask_Btn;
        private Label task_Label;
        private Panel overviewtitle_Panel;
        private Label overviewtitle_Label;
    }
}
