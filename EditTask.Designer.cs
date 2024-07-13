namespace Nimble
{
    partial class EditTask
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
            ATNavClose_Btn = new Button();
            Title_Panel = new Panel();
            AddTask_Label = new Label();
            SubmitButton_Panel = new Panel();
            Submit_Btn = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ED_RTB = new RichTextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            Role_CB = new ComboBox();
            Role_Label = new Label();
            Main_Panel = new Panel();
            ATNav_Panel = new Panel();
            comboBox2 = new ComboBox();
            Cancel_Btn = new Button();
            Title_Panel.SuspendLayout();
            SubmitButton_Panel.SuspendLayout();
            Main_Panel.SuspendLayout();
            ATNav_Panel.SuspendLayout();
            SuspendLayout();
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
            // 
            // Title_Panel
            // 
            Title_Panel.Controls.Add(AddTask_Label);
            Title_Panel.Location = new Point(21, 50);
            Title_Panel.Name = "Title_Panel";
            Title_Panel.Size = new Size(433, 35);
            Title_Panel.TabIndex = 16;
            // 
            // AddTask_Label
            // 
            AddTask_Label.AutoSize = true;
            AddTask_Label.Font = new Font("Helvetica 2 BQ ", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTask_Label.ForeColor = Color.FromArgb(253, 248, 225);
            AddTask_Label.Location = new Point(17, 10);
            AddTask_Label.Name = "AddTask_Label";
            AddTask_Label.Size = new Size(62, 19);
            AddTask_Label.TabIndex = 0;
            AddTask_Label.Text = "Edit Task";
            // 
            // SubmitButton_Panel
            // 
            SubmitButton_Panel.Controls.Add(Cancel_Btn);
            SubmitButton_Panel.Controls.Add(Submit_Btn);
            SubmitButton_Panel.Location = new Point(21, 394);
            SubmitButton_Panel.Name = "SubmitButton_Panel";
            SubmitButton_Panel.Size = new Size(433, 55);
            SubmitButton_Panel.TabIndex = 18;
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
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(133, 254);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(133, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.FromArgb(253, 248, 225);
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(17, 260);
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
            label4.Location = new Point(17, 221);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 13;
            label4.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(253, 248, 225);
            label3.Location = new Point(17, 7);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 11;
            label3.Text = "Select Task";
            // 
            // ED_RTB
            // 
            ED_RTB.BackColor = Color.FromArgb(254, 248, 235);
            ED_RTB.BorderStyle = BorderStyle.None;
            ED_RTB.Location = new Point(133, 40);
            ED_RTB.Name = "ED_RTB";
            ED_RTB.Size = new Size(300, 87);
            ED_RTB.TabIndex = 10;
            ED_RTB.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(253, 248, 225);
            label2.Location = new Point(17, 46);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 9;
            label2.Text = "Task Description";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(253, 248, 225);
            label1.Location = new Point(17, 182);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 7;
            label1.Text = "Task Category";
            // 
            // Role_CB
            // 
            Role_CB.FormattingEnabled = true;
            Role_CB.Location = new Point(133, 143);
            Role_CB.Name = "Role_CB";
            Role_CB.Size = new Size(200, 23);
            Role_CB.TabIndex = 6;
            // 
            // Role_Label
            // 
            Role_Label.AutoSize = true;
            Role_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Role_Label.ForeColor = Color.FromArgb(253, 248, 225);
            Role_Label.Location = new Point(17, 151);
            Role_Label.Name = "Role_Label";
            Role_Label.Size = new Size(66, 15);
            Role_Label.TabIndex = 5;
            Role_Label.Text = "Assign to:";
            // 
            // Main_Panel
            // 
            Main_Panel.Controls.Add(comboBox2);
            Main_Panel.Controls.Add(dateTimePicker2);
            Main_Panel.Controls.Add(label3);
            Main_Panel.Controls.Add(dateTimePicker1);
            Main_Panel.Controls.Add(label5);
            Main_Panel.Controls.Add(label4);
            Main_Panel.Controls.Add(ED_RTB);
            Main_Panel.Controls.Add(label2);
            Main_Panel.Controls.Add(comboBox1);
            Main_Panel.Controls.Add(label1);
            Main_Panel.Controls.Add(Role_CB);
            Main_Panel.Controls.Add(Role_Label);
            Main_Panel.Location = new Point(21, 93);
            Main_Panel.Name = "Main_Panel";
            Main_Panel.Size = new Size(433, 295);
            Main_Panel.TabIndex = 17;
            // 
            // ATNav_Panel
            // 
            ATNav_Panel.BackColor = Color.FromArgb(60, 90, 130);
            ATNav_Panel.Controls.Add(ATNavClose_Btn);
            ATNav_Panel.Dock = DockStyle.Top;
            ATNav_Panel.Location = new Point(0, 0);
            ATNav_Panel.Name = "ATNav_Panel";
            ATNav_Panel.Size = new Size(475, 33);
            ATNav_Panel.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(133, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 17;
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
            Cancel_Btn.TabIndex = 1;
            Cancel_Btn.Text = "Cancel";
            Cancel_Btn.UseVisualStyleBackColor = false;
            // 
            // EditTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 57);
            ClientSize = new Size(475, 450);
            Controls.Add(Title_Panel);
            Controls.Add(SubmitButton_Panel);
            Controls.Add(Main_Panel);
            Controls.Add(ATNav_Panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditTask";
            Text = "EditTask";
            Title_Panel.ResumeLayout(false);
            Title_Panel.PerformLayout();
            SubmitButton_Panel.ResumeLayout(false);
            Main_Panel.ResumeLayout(false);
            Main_Panel.PerformLayout();
            ATNav_Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ATNavClose_Btn;
        private Panel Title_Panel;
        private Label AddTask_Label;
        private Panel SubmitButton_Panel;
        private Button Submit_Btn;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox ED_RTB;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox Role_CB;
        private Label Role_Label;
        private Panel Main_Panel;
        private Panel ATNav_Panel;
        private ComboBox comboBox2;
        private Button Cancel_Btn;
    }
}