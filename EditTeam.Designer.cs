namespace Nimble
{
    partial class EditTeam
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
            Submit_Btn = new Button();
            EditTeam_Label = new Label();
            Main_Panel = new Panel();
            assign_CB = new ComboBox();
            label1 = new Label();
            Role_CB = new ComboBox();
            Role_Label = new Label();
            FirstName_Label = new Label();
            FullName_TB = new TextBox();
            Title_Panel = new Panel();
            SubmitButton_Panel = new Panel();
            Cancel_Btn = new Button();
            Format_Panel = new Panel();
            ATNav_Panel = new Panel();
            ATNavClose_Btn = new Button();
            Main_Panel.SuspendLayout();
            Title_Panel.SuspendLayout();
            SubmitButton_Panel.SuspendLayout();
            ATNav_Panel.SuspendLayout();
            SuspendLayout();
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
            // EditTeam_Label
            // 
            EditTeam_Label.AutoSize = true;
            EditTeam_Label.Font = new Font("Helvetica 2 BQ ", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditTeam_Label.ForeColor = Color.FromArgb(253, 248, 225);
            EditTeam_Label.Location = new Point(17, 10);
            EditTeam_Label.Name = "EditTeam_Label";
            EditTeam_Label.Size = new Size(68, 19);
            EditTeam_Label.TabIndex = 0;
            EditTeam_Label.Text = "Edit Team";
            // 
            // Main_Panel
            // 
            Main_Panel.Controls.Add(assign_CB);
            Main_Panel.Controls.Add(label1);
            Main_Panel.Controls.Add(Role_CB);
            Main_Panel.Controls.Add(Role_Label);
            Main_Panel.Controls.Add(FirstName_Label);
            Main_Panel.Controls.Add(FullName_TB);
            Main_Panel.Location = new Point(21, 91);
            Main_Panel.Name = "Main_Panel";
            Main_Panel.Size = new Size(433, 256);
            Main_Panel.TabIndex = 12;
            // 
            // assign_CB
            // 
            assign_CB.FormattingEnabled = true;
            assign_CB.Location = new Point(136, 7);
            assign_CB.Name = "assign_CB";
            assign_CB.Size = new Size(192, 23);
            assign_CB.TabIndex = 8;
            assign_CB.SelectedIndexChanged += assign_CB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(253, 248, 225);
            label1.Location = new Point(20, 7);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 7;
            label1.Text = "Select User";
            // 
            // Role_CB
            // 
            Role_CB.FormattingEnabled = true;
            Role_CB.Items.AddRange(new object[] { "1: Project Owner", "2: Project Manager", "3: Designer", "4: Programmer", "5: Tester" });
            Role_CB.Location = new Point(136, 81);
            Role_CB.Name = "Role_CB";
            Role_CB.Size = new Size(192, 23);
            Role_CB.TabIndex = 6;
            // 
            // Role_Label
            // 
            Role_Label.AutoSize = true;
            Role_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Role_Label.ForeColor = Color.FromArgb(253, 248, 225);
            Role_Label.Location = new Point(20, 81);
            Role_Label.Name = "Role_Label";
            Role_Label.Size = new Size(33, 15);
            Role_Label.TabIndex = 5;
            Role_Label.Text = "Role";
            // 
            // FirstName_Label
            // 
            FirstName_Label.AutoSize = true;
            FirstName_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FirstName_Label.ForeColor = Color.FromArgb(253, 248, 225);
            FirstName_Label.Location = new Point(20, 47);
            FirstName_Label.Name = "FirstName_Label";
            FirstName_Label.Size = new Size(66, 15);
            FirstName_Label.TabIndex = 1;
            FirstName_Label.Text = "Full Name";
            // 
            // FullName_TB
            // 
            FullName_TB.Location = new Point(136, 44);
            FullName_TB.Name = "FullName_TB";
            FullName_TB.Size = new Size(297, 23);
            FullName_TB.TabIndex = 0;
            // 
            // Title_Panel
            // 
            Title_Panel.Controls.Add(EditTeam_Label);
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
            Cancel_Btn.Location = new Point(136, 3);
            Cancel_Btn.Name = "Cancel_Btn";
            Cancel_Btn.Size = new Size(118, 29);
            Cancel_Btn.TabIndex = 9;
            Cancel_Btn.Text = "Cancel";
            Cancel_Btn.UseVisualStyleBackColor = false;
            Cancel_Btn.Click += Cancel_Btn_Click;
            // 
            // Format_Panel
            // 
            Format_Panel.Location = new Point(21, 353);
            Format_Panel.Name = "Format_Panel";
            Format_Panel.Size = new Size(433, 33);
            Format_Panel.TabIndex = 13;
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
            // EditTeam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 57);
            ClientSize = new Size(475, 450);
            Controls.Add(Main_Panel);
            Controls.Add(Title_Panel);
            Controls.Add(SubmitButton_Panel);
            Controls.Add(Format_Panel);
            Controls.Add(ATNav_Panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditTeam";
            Text = "EditTeam";
            Main_Panel.ResumeLayout(false);
            Main_Panel.PerformLayout();
            Title_Panel.ResumeLayout(false);
            Title_Panel.PerformLayout();
            SubmitButton_Panel.ResumeLayout(false);
            ATNav_Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Submit_Btn;
        private Label EditTeam_Label;
        private Panel Main_Panel;
        private ComboBox Role_CB;
        private Label Role_Label;
        private Label FirstName_Label;
        private TextBox FullName_TB;
        private Panel Title_Panel;
        private Panel SubmitButton_Panel;
        private Panel Format_Panel;
        private Panel ATNav_Panel;
        private Button ATNavClose_Btn;
        private ComboBox assign_CB;
        private Label label1;
        private Button Cancel_Btn;
    }
}