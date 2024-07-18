namespace Nimble
{
    partial class AddRisk
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
            Submit_Btn = new Button();
            RiskID_TB = new TextBox();
            RiskID_Label = new Label();
            RD_RTB = new RichTextBox();
            Cancel_Btn = new Button();
            Title_Panel = new Panel();
            AddRisk_Label = new Label();
            SubmitButton_Panel = new Panel();
            RiskDesc_Label = new Label();
            Probability_CB = new ComboBox();
            prob_Label = new Label();
            Role_Label = new Label();
            Main_Panel = new Panel();
            RM_RTB = new RichTextBox();
            RiskMit_Label = new Label();
            label2 = new Label();
            label1 = new Label();
            cost_TB = new TextBox();
            cost_Label = new Label();
            Priority_CB = new ComboBox();
            ATNav_Panel = new Panel();
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
            ATNavClose_Btn.Click += ATNavClose_Btn_Click;
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
            // RiskID_TB
            // 
            RiskID_TB.Location = new Point(135, 5);
            RiskID_TB.Name = "RiskID_TB";
            RiskID_TB.ReadOnly = true;
            RiskID_TB.Size = new Size(73, 23);
            RiskID_TB.TabIndex = 12;
            // 
            // RiskID_Label
            // 
            RiskID_Label.AutoSize = true;
            RiskID_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RiskID_Label.ForeColor = Color.FromArgb(253, 248, 225);
            RiskID_Label.Location = new Point(21, 9);
            RiskID_Label.Name = "RiskID_Label";
            RiskID_Label.Size = new Size(89, 15);
            RiskID_Label.TabIndex = 11;
            RiskID_Label.Text = "Risk ID (Auto)";
            // 
            // RD_RTB
            // 
            RD_RTB.BackColor = Color.FromArgb(254, 248, 235);
            RD_RTB.BorderStyle = BorderStyle.None;
            RD_RTB.Location = new Point(135, 44);
            RD_RTB.Name = "RD_RTB";
            RD_RTB.Size = new Size(300, 60);
            RD_RTB.TabIndex = 10;
            RD_RTB.Text = "";
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
            // Title_Panel
            // 
            Title_Panel.Controls.Add(AddRisk_Label);
            Title_Panel.Location = new Point(21, 50);
            Title_Panel.Name = "Title_Panel";
            Title_Panel.Size = new Size(433, 35);
            Title_Panel.TabIndex = 16;
            // 
            // AddRisk_Label
            // 
            AddRisk_Label.AutoSize = true;
            AddRisk_Label.Font = new Font("Helvetica 2 BQ ", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddRisk_Label.ForeColor = Color.FromArgb(253, 248, 225);
            AddRisk_Label.Location = new Point(17, 10);
            AddRisk_Label.Name = "AddRisk_Label";
            AddRisk_Label.Size = new Size(60, 19);
            AddRisk_Label.TabIndex = 0;
            AddRisk_Label.Text = "Add Risk";
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
            // RiskDesc_Label
            // 
            RiskDesc_Label.AutoSize = true;
            RiskDesc_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RiskDesc_Label.ForeColor = Color.FromArgb(253, 248, 225);
            RiskDesc_Label.Location = new Point(21, 50);
            RiskDesc_Label.Name = "RiskDesc_Label";
            RiskDesc_Label.Size = new Size(102, 15);
            RiskDesc_Label.TabIndex = 9;
            RiskDesc_Label.Text = "Risk Description";
            // 
            // Probability_CB
            // 
            Probability_CB.FormattingEnabled = true;
            Probability_CB.Items.AddRange(new object[] { "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%" });
            Probability_CB.Location = new Point(134, 226);
            Probability_CB.Name = "Probability_CB";
            Probability_CB.Size = new Size(200, 23);
            Probability_CB.TabIndex = 8;
            Probability_CB.Text = "Select Your Probability %";
            // 
            // prob_Label
            // 
            prob_Label.AutoSize = true;
            prob_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            prob_Label.ForeColor = Color.FromArgb(253, 248, 225);
            prob_Label.Location = new Point(18, 229);
            prob_Label.Name = "prob_Label";
            prob_Label.Size = new Size(72, 15);
            prob_Label.TabIndex = 7;
            prob_Label.Text = "Probability:";
            // 
            // Role_Label
            // 
            Role_Label.AutoSize = true;
            Role_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Role_Label.ForeColor = Color.FromArgb(253, 248, 225);
            Role_Label.Location = new Point(18, 198);
            Role_Label.Name = "Role_Label";
            Role_Label.Size = new Size(52, 15);
            Role_Label.TabIndex = 5;
            Role_Label.Text = "Priority:";
            // 
            // Main_Panel
            // 
            Main_Panel.Controls.Add(RM_RTB);
            Main_Panel.Controls.Add(RiskMit_Label);
            Main_Panel.Controls.Add(label2);
            Main_Panel.Controls.Add(label1);
            Main_Panel.Controls.Add(cost_TB);
            Main_Panel.Controls.Add(cost_Label);
            Main_Panel.Controls.Add(RiskID_TB);
            Main_Panel.Controls.Add(RiskID_Label);
            Main_Panel.Controls.Add(RD_RTB);
            Main_Panel.Controls.Add(RiskDesc_Label);
            Main_Panel.Controls.Add(Probability_CB);
            Main_Panel.Controls.Add(prob_Label);
            Main_Panel.Controls.Add(Priority_CB);
            Main_Panel.Controls.Add(Role_Label);
            Main_Panel.Location = new Point(21, 93);
            Main_Panel.Name = "Main_Panel";
            Main_Panel.Size = new Size(433, 295);
            Main_Panel.TabIndex = 17;
            // 
            // RM_RTB
            // 
            RM_RTB.BackColor = Color.FromArgb(254, 248, 235);
            RM_RTB.BorderStyle = BorderStyle.None;
            RM_RTB.Location = new Point(135, 119);
            RM_RTB.Name = "RM_RTB";
            RM_RTB.Size = new Size(300, 60);
            RM_RTB.TabIndex = 18;
            RM_RTB.Text = "";
            // 
            // RiskMit_Label
            // 
            RiskMit_Label.AutoSize = true;
            RiskMit_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RiskMit_Label.ForeColor = Color.FromArgb(253, 248, 225);
            RiskMit_Label.Location = new Point(21, 125);
            RiskMit_Label.Name = "RiskMit_Label";
            RiskMit_Label.Size = new Size(93, 15);
            RiskMit_Label.TabIndex = 17;
            RiskMit_Label.Text = "Risk Mitigation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.FromArgb(253, 248, 225);
            label2.Location = new Point(236, 267);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 16;
            label2.Text = ".00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(253, 248, 225);
            label1.Location = new Point(116, 267);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 15;
            label1.Text = "$";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cost_TB
            // 
            cost_TB.Location = new Point(134, 263);
            cost_TB.Name = "cost_TB";
            cost_TB.Size = new Size(100, 23);
            cost_TB.TabIndex = 14;
            cost_TB.KeyPress += cost_TB_KeyPress;
            // 
            // cost_Label
            // 
            cost_Label.AutoSize = true;
            cost_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            cost_Label.ForeColor = Color.FromArgb(253, 248, 225);
            cost_Label.Location = new Point(18, 266);
            cost_Label.Name = "cost_Label";
            cost_Label.Size = new Size(38, 15);
            cost_Label.TabIndex = 13;
            cost_Label.Text = "Cost:";
            // 
            // Priority_CB
            // 
            Priority_CB.FormattingEnabled = true;
            Priority_CB.Items.AddRange(new object[] { "1: High", "2: Medium", "3: Low" });
            Priority_CB.Location = new Point(134, 190);
            Priority_CB.Name = "Priority_CB";
            Priority_CB.Size = new Size(200, 23);
            Priority_CB.TabIndex = 6;
            Priority_CB.Text = "Select Your Priority Level:";
            // 
            // ATNav_Panel
            // 
            ATNav_Panel.BackColor = Color.FromArgb(8, 23, 45);
            ATNav_Panel.Controls.Add(ATNavClose_Btn);
            ATNav_Panel.Dock = DockStyle.Top;
            ATNav_Panel.Location = new Point(0, 0);
            ATNav_Panel.Name = "ATNav_Panel";
            ATNav_Panel.Size = new Size(475, 33);
            ATNav_Panel.TabIndex = 19;
            // 
            // AddRisk
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
            Name = "AddRisk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddRisk";
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
        private Button Submit_Btn;
        private DateTimePicker DueDate;
        private DateTimePicker StartDate;
        private Label label5;
        private Label RiskID_Label;
        private Label label4;
        private TextBox RiskID_TB;
        private Label label3;
        private RichTextBox RD_RTB;
        private Button Cancel_Btn;
        private Panel Title_Panel;
        private Label AddRisk_Label;
        private Panel SubmitButton_Panel;
        private Label RiskDesc_Label;
        private ComboBox Probability_CB;
        private Label prob_Label;
        private Label Role_Label;
        private Panel Main_Panel;
        private ComboBox Priority_CB;
        private Panel ATNav_Panel;
        private Label cost_Label;
        private TextBox cost_TB;
        private Label label2;
        private Label label1;
        private RichTextBox RM_RTB;
        private Label RiskMit_Label;
    }
}