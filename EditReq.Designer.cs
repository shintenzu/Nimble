namespace Nimble
{
    partial class EditReq
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
            EditReqTitle_Label = new Label();
            EditDescEntryRTB_Panel = new Panel();
            RTB = new RichTextBox();
            Title_Panel = new Panel();
            Button_Panel = new Panel();
            Submit_Btn = new Button();
            Format_Panel = new Panel();
            nav_Panel = new Panel();
            NavClose_Btn = new Button();
            Cancel_Btn = new Button();
            EditDescEntryRTB_Panel.SuspendLayout();
            Title_Panel.SuspendLayout();
            Button_Panel.SuspendLayout();
            nav_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // EditReqTitle_Label
            // 
            EditReqTitle_Label.AutoSize = true;
            EditReqTitle_Label.Font = new Font("Helvetica 2 BQ ", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditReqTitle_Label.ForeColor = Color.FromArgb(253, 248, 225);
            EditReqTitle_Label.Location = new Point(17, 10);
            EditReqTitle_Label.Name = "EditReqTitle_Label";
            EditReqTitle_Label.Size = new Size(115, 19);
            EditReqTitle_Label.TabIndex = 0;
            EditReqTitle_Label.Text = "Edit Requirements";
            // 
            // EditDescEntryRTB_Panel
            // 
            EditDescEntryRTB_Panel.Controls.Add(RTB);
            EditDescEntryRTB_Panel.Location = new Point(21, 88);
            EditDescEntryRTB_Panel.Name = "EditDescEntryRTB_Panel";
            EditDescEntryRTB_Panel.Size = new Size(433, 256);
            EditDescEntryRTB_Panel.TabIndex = 7;
            // 
            // RTB
            // 
            RTB.BackColor = Color.FromArgb(254, 248, 235);
            RTB.BorderStyle = BorderStyle.None;
            RTB.Dock = DockStyle.Fill;
            RTB.Location = new Point(0, 0);
            RTB.Name = "RTB";
            RTB.Size = new Size(433, 256);
            RTB.TabIndex = 0;
            RTB.Text = "";
            // 
            // Title_Panel
            // 
            Title_Panel.Controls.Add(EditReqTitle_Label);
            Title_Panel.Location = new Point(21, 45);
            Title_Panel.Name = "Title_Panel";
            Title_Panel.Size = new Size(433, 35);
            Title_Panel.TabIndex = 6;
            // 
            // Button_Panel
            // 
            Button_Panel.Controls.Add(Cancel_Btn);
            Button_Panel.Controls.Add(Submit_Btn);
            Button_Panel.Location = new Point(21, 389);
            Button_Panel.Name = "Button_Panel";
            Button_Panel.Size = new Size(433, 55);
            Button_Panel.TabIndex = 9;
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
            // Format_Panel
            // 
            Format_Panel.Location = new Point(21, 350);
            Format_Panel.Name = "Format_Panel";
            Format_Panel.Size = new Size(433, 33);
            Format_Panel.TabIndex = 8;
            // 
            // nav_Panel
            // 
            nav_Panel.BackColor = Color.FromArgb(60, 90, 130);
            nav_Panel.Controls.Add(NavClose_Btn);
            nav_Panel.Dock = DockStyle.Top;
            nav_Panel.Location = new Point(0, 0);
            nav_Panel.Name = "nav_Panel";
            nav_Panel.Size = new Size(475, 33);
            nav_Panel.TabIndex = 10;
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
            // 
            // EditReq
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
            Name = "EditReq";
            Text = "EditReq";
            EditDescEntryRTB_Panel.ResumeLayout(false);
            Title_Panel.ResumeLayout(false);
            Title_Panel.PerformLayout();
            Button_Panel.ResumeLayout(false);
            nav_Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label EditReqTitle_Label;
        private Panel EditDescEntryRTB_Panel;
        private RichTextBox RTB;
        private Panel Title_Panel;
        private Panel Button_Panel;
        private Button Submit_Btn;
        private Panel Format_Panel;
        private Panel nav_Panel;
        private Button NavClose_Btn;
        private Button Cancel_Btn;
    }
}