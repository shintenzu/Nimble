namespace Nimble
{
    partial class AddTask
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddTask_Label = new Label();
            Main_Panel = new Panel();
            status_CB = new ComboBox();
            label6 = new Label();
            DueDate = new DateTimePicker();
            StartDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            taskID = new TextBox();
            label3 = new Label();
            ED_RTB = new RichTextBox();
            label2 = new Label();
            category_CB = new ComboBox();
            label1 = new Label();
            assign_CB = new ComboBox();
            Role_Label = new Label();
            Title_Panel = new Panel();
            SubmitButton_Panel = new Panel();
            Cancel_Btn = new Button();
            Submit_Btn = new Button();
            ATNav_Panel = new Panel();
            ATNavClose_Btn = new Button();
            Main_Panel.SuspendLayout();
            Title_Panel.SuspendLayout();
            SubmitButton_Panel.SuspendLayout();
            ATNav_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // AddTask_Label
            // 
            AddTask_Label.AutoSize = true;
            AddTask_Label.Font = new Font("Helvetica 2 BQ ", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTask_Label.ForeColor = Color.FromArgb(253, 248, 225);
            AddTask_Label.Location = new Point(17, 10);
            AddTask_Label.Name = "AddTask_Label";
            AddTask_Label.Size = new Size(63, 19);
            AddTask_Label.TabIndex = 0;
            AddTask_Label.Text = "Add Task";
            // 
            // Main_Panel
            // 
            Main_Panel.Controls.Add(status_CB);
            Main_Panel.Controls.Add(label6);
            Main_Panel.Controls.Add(DueDate);
            Main_Panel.Controls.Add(StartDate);
            Main_Panel.Controls.Add(label5);
            Main_Panel.Controls.Add(label4);
            Main_Panel.Controls.Add(taskID);
            Main_Panel.Controls.Add(label3);
            Main_Panel.Controls.Add(ED_RTB);
            Main_Panel.Controls.Add(label2);
            Main_Panel.Controls.Add(category_CB);
            Main_Panel.Controls.Add(label1);
            Main_Panel.Controls.Add(assign_CB);
            Main_Panel.Controls.Add(Role_Label);
            Main_Panel.Location = new Point(21, 91);
            Main_Panel.Name = "Main_Panel";
            Main_Panel.Size = new Size(433, 295);
            Main_Panel.TabIndex = 12;
            // 
            // status_CB
            // 
            status_CB.FormattingEnabled = true;
            status_CB.Items.AddRange(new object[] { "1: Incomplete", "2: Complete", "3: Pending", "4: Removed", "5: Archived" });
            status_CB.Location = new Point(133, 247);
            status_CB.Name = "status_CB";
            status_CB.Size = new Size(200, 23);
            status_CB.TabIndex = 18;
            status_CB.Text = "(Choose your task status)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.FromArgb(253, 248, 225);
            label6.Location = new Point(17, 250);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 17;
            label6.Text = "Task Status";
            // 
            // DueDate
            // 
            DueDate.Location = new Point(133, 215);
            DueDate.Name = "DueDate";
            DueDate.Size = new Size(200, 23);
            DueDate.TabIndex = 16;
            // 
            // StartDate
            // 
            StartDate.Location = new Point(133, 184);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(200, 23);
            StartDate.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.FromArgb(253, 248, 225);
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(17, 221);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 14;
            label5.Text = "Due Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.FromArgb(253, 248, 225);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(17, 190);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 13;
            label4.Text = "Start Date";
            // 
            // taskID
            // 
            taskID.Location = new Point(133, 10);
            taskID.Name = "taskID";
            taskID.ReadOnly = true;
            taskID.Size = new Size(73, 23);
            taskID.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(253, 248, 225);
            label3.Location = new Point(17, 14);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 11;
            label3.Text = "Task ID (Auto)";
            // 
            // ED_RTB
            // 
            ED_RTB.BackColor = Color.FromArgb(254, 248, 235);
            ED_RTB.BorderStyle = BorderStyle.None;
            ED_RTB.Location = new Point(133, 45);
            ED_RTB.Name = "ED_RTB";
            ED_RTB.Size = new Size(300, 68);
            ED_RTB.TabIndex = 10;
            ED_RTB.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(253, 248, 225);
            label2.Location = new Point(17, 51);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 9;
            label2.Text = "Task Description";
            // 
            // category_CB
            // 
            category_CB.FormattingEnabled = true;
            category_CB.Items.AddRange(new object[] { "1: Requirements Analysis", "2: Designing", "3: Coding", "4: Testing", "5: Project Management" });
            category_CB.Location = new Point(133, 153);
            category_CB.Name = "category_CB";
            category_CB.Size = new Size(200, 23);
            category_CB.TabIndex = 8;
            category_CB.Text = "(Choose your task category)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(253, 248, 225);
            label1.Location = new Point(17, 156);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 7;
            label1.Text = "Task Category";
            // 
            // assign_CB
            // 
            assign_CB.FormattingEnabled = true;
            assign_CB.Location = new Point(133, 121);
            assign_CB.Name = "assign_CB";
            assign_CB.Size = new Size(200, 23);
            assign_CB.TabIndex = 6;
            assign_CB.Text = "(Assign your task to someone)";
            // 
            // Role_Label
            // 
            Role_Label.AutoSize = true;
            Role_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Role_Label.ForeColor = Color.FromArgb(253, 248, 225);
            Role_Label.Location = new Point(17, 129);
            Role_Label.Name = "Role_Label";
            Role_Label.Size = new Size(66, 15);
            Role_Label.TabIndex = 5;
            Role_Label.Text = "Assign to:";
            // 
            // Title_Panel
            // 
            Title_Panel.Controls.Add(AddTask_Label);
            Title_Panel.Location = new Point(21, 48);
            Title_Panel.Name = "Title_Panel";
            Title_Panel.Size = new Size(433, 35);
            Title_Panel.TabIndex = 11;
            // 
            // SubmitButton_Panel
            // 
            SubmitButton_Panel.Controls.Add(Cancel_Btn);
            SubmitButton_Panel.Controls.Add(Submit_Btn);
            SubmitButton_Panel.Location = new Point(21, 392);
            SubmitButton_Panel.Name = "SubmitButton_Panel";
            SubmitButton_Panel.Size = new Size(433, 55);
            SubmitButton_Panel.TabIndex = 14;
            // 
            // Cancel_Btn
            // 
            Cancel_Btn.BackColor = Color.FromArgb(60, 90, 130);
            Cancel_Btn.FlatAppearance.BorderSize = 0;
            Cancel_Btn.FlatStyle = FlatStyle.Flat;
            Cancel_Btn.Font = new Font("Helvetica 2 BQ ", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            Cancel_Btn.Location = new Point(133, 3);
            Cancel_Btn.Name = "Cancel_Btn";
            Cancel_Btn.Size = new Size(118, 29);
            Cancel_Btn.TabIndex = 16;
            Cancel_Btn.Text = "Cancel";
            Cancel_Btn.UseVisualStyleBackColor = false;
            Cancel_Btn.Click += Cancel_Btn_Click;
            // 
            // Submit_Btn
            // 
            Submit_Btn.BackColor = Color.FromArgb(60, 90, 130);
            Submit_Btn.FlatAppearance.BorderSize = 0;
            Submit_Btn.FlatStyle = FlatStyle.Flat;
            Submit_Btn.Font = new Font("Helvetica 2 BQ ", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            Submit_Btn.Location = new Point(315, 3);
            Submit_Btn.Name = "Submit_Btn";
            Submit_Btn.Size = new Size(118, 29);
            Submit_Btn.TabIndex = 0;
            Submit_Btn.Text = "Submit";
            Submit_Btn.UseVisualStyleBackColor = false;
            Submit_Btn.Click += Submit_Btn_Click;
            // 
            // ATNav_Panel
            // 
            ATNav_Panel.BackColor = Color.FromArgb(8, 23, 45);
            ATNav_Panel.Controls.Add(ATNavClose_Btn);
            ATNav_Panel.Dock = DockStyle.Top;
            ATNav_Panel.Location = new Point(0, 0);
            ATNav_Panel.Name = "ATNav_Panel";
            ATNav_Panel.Size = new Size(475, 33);
            ATNav_Panel.TabIndex = 15;
            // 
            // ATNavClose_Btn
            // 
            ATNavClose_Btn.BackColor = Color.Transparent;
            ATNavClose_Btn.Dock = DockStyle.Right;
            ATNavClose_Btn.FlatAppearance.BorderSize = 0;
            ATNavClose_Btn.FlatStyle = FlatStyle.Flat;
            ATNavClose_Btn.Image = Properties.Resources.close;
            ATNavClose_Btn.Location = new Point(445, 0);
            ATNavClose_Btn.Name = "ATNavClose_Btn";
            ATNavClose_Btn.Size = new Size(30, 33);
            ATNavClose_Btn.TabIndex = 1;
            ATNavClose_Btn.UseVisualStyleBackColor = false;
            ATNavClose_Btn.Click += ATNavClose_Btn_Click;
            // 
            // AddTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 57);
            ClientSize = new Size(475, 450);
            Controls.Add(Main_Panel);
            Controls.Add(Title_Panel);
            Controls.Add(SubmitButton_Panel);
            Controls.Add(ATNav_Panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTask";
            Text = "AddTask";
            Main_Panel.ResumeLayout(false);
            Main_Panel.PerformLayout();
            Title_Panel.ResumeLayout(false);
            Title_Panel.PerformLayout();
            SubmitButton_Panel.ResumeLayout(false);
            ATNav_Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label AddTask_Label;
        private Panel Main_Panel;
        private ComboBox assign_CB;
        private Label Role_Label;
        private Panel Title_Panel;
        private Panel SubmitButton_Panel;
        private Button Submit_Btn;
        private Panel ATNav_Panel;
        private Button ATNavClose_Btn;
        private ComboBox category_CB;
        private Label label1;
        private Label label2;
        private RichTextBox ED_RTB;
        private TextBox taskID;
        private Label label3;
        private Label label4;
        private DateTimePicker DueDate;
        private DateTimePicker StartDate;
        private Label label5;
        private Button Cancel_Btn;
        private ComboBox status_CB;
        private Label label6;
    }
}