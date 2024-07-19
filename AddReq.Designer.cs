namespace Nimble
{
    partial class AddReq
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
            AddReqTitle_Label = new Label();
            EditDescEntryRTB_Panel = new Panel();
            Main_Panel = new Panel();
            Req_TB = new TextBox();
            ReqID_Label = new Label();
            RD_RTB = new RichTextBox();
            RiskDesc_Label = new Label();
            Category_CB = new ComboBox();
            Role_Label = new Label();
            Title_Panel = new Panel();
            Button_Panel = new Panel();
            Cancel_Btn = new Button();
            Submit_Btn = new Button();
            nav_Panel = new Panel();
            NavClose_Btn = new Button();
            Format_Panel = new Panel();
            EditDescEntryRTB_Panel.SuspendLayout();
            Main_Panel.SuspendLayout();
            Title_Panel.SuspendLayout();
            Button_Panel.SuspendLayout();
            nav_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // AddReqTitle_Label
            // 
            AddReqTitle_Label.AutoSize = true;
            AddReqTitle_Label.Font = new Font("Helvetica 2 BQ ", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddReqTitle_Label.ForeColor = Color.FromArgb(253, 248, 225);
            AddReqTitle_Label.Location = new Point(17, 10);
            AddReqTitle_Label.Name = "AddReqTitle_Label";
            AddReqTitle_Label.Size = new Size(116, 19);
            AddReqTitle_Label.TabIndex = 0;
            AddReqTitle_Label.Text = "Add Requirements";
            // 
            // EditDescEntryRTB_Panel
            // 
            EditDescEntryRTB_Panel.Controls.Add(Main_Panel);
            EditDescEntryRTB_Panel.Location = new Point(21, 91);
            EditDescEntryRTB_Panel.Name = "EditDescEntryRTB_Panel";
            EditDescEntryRTB_Panel.Size = new Size(433, 256);
            EditDescEntryRTB_Panel.TabIndex = 12;
            // 
            // Main_Panel
            // 
            Main_Panel.Controls.Add(Req_TB);
            Main_Panel.Controls.Add(ReqID_Label);
            Main_Panel.Controls.Add(RD_RTB);
            Main_Panel.Controls.Add(RiskDesc_Label);
            Main_Panel.Controls.Add(Category_CB);
            Main_Panel.Controls.Add(Role_Label);
            Main_Panel.Location = new Point(0, -19);
            Main_Panel.Name = "Main_Panel";
            Main_Panel.Size = new Size(433, 295);
            Main_Panel.TabIndex = 18;
            // 
            // Req_TB
            // 
            Req_TB.Location = new Point(135, 23);
            Req_TB.Name = "Req_TB";
            Req_TB.ReadOnly = true;
            Req_TB.Size = new Size(73, 23);
            Req_TB.TabIndex = 12;
            // 
            // ReqID_Label
            // 
            ReqID_Label.AutoSize = true;
            ReqID_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ReqID_Label.ForeColor = Color.FromArgb(253, 248, 225);
            ReqID_Label.Location = new Point(21, 27);
            ReqID_Label.Name = "ReqID_Label";
            ReqID_Label.Size = new Size(86, 15);
            ReqID_Label.TabIndex = 11;
            ReqID_Label.Text = "Req ID (Auto)";
            // 
            // RD_RTB
            // 
            RD_RTB.BackColor = Color.FromArgb(254, 248, 235);
            RD_RTB.BorderStyle = BorderStyle.None;
            RD_RTB.Location = new Point(135, 62);
            RD_RTB.Name = "RD_RTB";
            RD_RTB.Size = new Size(300, 60);
            RD_RTB.TabIndex = 10;
            RD_RTB.Text = "";
            // 
            // RiskDesc_Label
            // 
            RiskDesc_Label.AutoSize = true;
            RiskDesc_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RiskDesc_Label.ForeColor = Color.FromArgb(253, 248, 225);
            RiskDesc_Label.Location = new Point(21, 68);
            RiskDesc_Label.Name = "RiskDesc_Label";
            RiskDesc_Label.Size = new Size(99, 15);
            RiskDesc_Label.TabIndex = 9;
            RiskDesc_Label.Text = "Req Description";
            // 
            // Category_CB
            // 
            Category_CB.AutoCompleteCustomSource.AddRange(new string[] { "1. Functional Requirement", "2. Non Functional Requirement" });
            Category_CB.FormattingEnabled = true;
            Category_CB.Items.AddRange(new object[] { "1: Functional", "2: Non-Functional" });
            Category_CB.Location = new Point(133, 135);
            Category_CB.Name = "Category_CB";
            Category_CB.Size = new Size(200, 23);
            Category_CB.TabIndex = 6;
            Category_CB.Text = "Select Your Requirement Type:";
            // 
            // Role_Label
            // 
            Role_Label.AutoSize = true;
            Role_Label.Font = new Font("Helvetica CE", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Role_Label.ForeColor = Color.FromArgb(253, 248, 225);
            Role_Label.Location = new Point(22, 141);
            Role_Label.Name = "Role_Label";
            Role_Label.Size = new Size(67, 15);
            Role_Label.TabIndex = 5;
            Role_Label.Text = "Req Type:";
            // 
            // Title_Panel
            // 
            Title_Panel.Controls.Add(AddReqTitle_Label);
            Title_Panel.Location = new Point(21, 48);
            Title_Panel.Name = "Title_Panel";
            Title_Panel.Size = new Size(433, 35);
            Title_Panel.TabIndex = 11;
            // 
            // Button_Panel
            // 
            Button_Panel.Controls.Add(Cancel_Btn);
            Button_Panel.Controls.Add(Submit_Btn);
            Button_Panel.Location = new Point(21, 392);
            Button_Panel.Name = "Button_Panel";
            Button_Panel.Size = new Size(433, 55);
            Button_Panel.TabIndex = 14;
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
            Cancel_Btn.TabIndex = 2;
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
            // nav_Panel
            // 
            nav_Panel.BackColor = Color.FromArgb(8, 23, 45);
            nav_Panel.Controls.Add(NavClose_Btn);
            nav_Panel.Dock = DockStyle.Top;
            nav_Panel.Location = new Point(0, 0);
            nav_Panel.Name = "nav_Panel";
            nav_Panel.Size = new Size(475, 33);
            nav_Panel.TabIndex = 15;
            // 
            // NavClose_Btn
            // 
            NavClose_Btn.BackColor = Color.Transparent;
            NavClose_Btn.Dock = DockStyle.Right;
            NavClose_Btn.FlatAppearance.BorderSize = 0;
            NavClose_Btn.FlatStyle = FlatStyle.Flat;
            NavClose_Btn.Image = Properties.Resources.close;
            NavClose_Btn.Location = new Point(445, 0);
            NavClose_Btn.Name = "NavClose_Btn";
            NavClose_Btn.Size = new Size(30, 33);
            NavClose_Btn.TabIndex = 1;
            NavClose_Btn.UseVisualStyleBackColor = false;
            NavClose_Btn.Click += NavClose_Btn_Click;
            // 
            // Format_Panel
            // 
            Format_Panel.Location = new Point(21, 353);
            Format_Panel.Name = "Format_Panel";
            Format_Panel.Size = new Size(433, 33);
            Format_Panel.TabIndex = 13;
            // 
            // AddReq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 57);
            ClientSize = new Size(475, 450);
            Controls.Add(EditDescEntryRTB_Panel);
            Controls.Add(Title_Panel);
            Controls.Add(Button_Panel);
            Controls.Add(Format_Panel);
            Controls.Add(nav_Panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddReq";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddReq";
            EditDescEntryRTB_Panel.ResumeLayout(false);
            Main_Panel.ResumeLayout(false);
            Main_Panel.PerformLayout();
            Title_Panel.ResumeLayout(false);
            Title_Panel.PerformLayout();
            Button_Panel.ResumeLayout(false);
            nav_Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label AddReqTitle_Label;
        private Panel EditDescEntryRTB_Panel;
        private Panel Title_Panel;
        private Panel Button_Panel;
        private Button Cancel_Btn;
        private Button Submit_Btn;
        private Panel nav_Panel;
        private Button NavClose_Btn;
        private Panel Format_Panel;
        private Panel Main_Panel;
        private TextBox Req_TB;
        private Label ReqID_Label;
        private RichTextBox RD_RTB;
        private Label RiskDesc_Label;
        private ComboBox Category_CB;
        private Label Role_Label;
    }
}