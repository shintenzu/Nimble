namespace Nimble
{
    partial class EditDesc
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
            EditDescTitle_Label = new Label();
            EDTitle_Panel = new Panel();
            EditDescEntryRTB_Panel = new Panel();
            ED_RTB = new RichTextBox();
            EDFormat_Panel = new Panel();
            EDButton_Panel = new Panel();
            EDSubmit_Btn = new Button();
            panel1 = new Panel();
            EDNavClose_Btn = new Button();
            Cancel_Btn = new Button();
            EDTitle_Panel.SuspendLayout();
            EditDescEntryRTB_Panel.SuspendLayout();
            EDButton_Panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EditDescTitle_Label
            // 
            EditDescTitle_Label.AutoSize = true;
            EditDescTitle_Label.Font = new Font("Helvetica 2 BQ ", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditDescTitle_Label.ForeColor = Color.FromArgb(253, 248, 225);
            EditDescTitle_Label.Location = new Point(17, 10);
            EditDescTitle_Label.Name = "EditDescTitle_Label";
            EditDescTitle_Label.Size = new Size(99, 19);
            EditDescTitle_Label.TabIndex = 0;
            EditDescTitle_Label.Text = "Edit Description";
            // 
            // EDTitle_Panel
            // 
            EDTitle_Panel.Controls.Add(EditDescTitle_Label);
            EDTitle_Panel.Location = new Point(21, 39);
            EDTitle_Panel.Name = "EDTitle_Panel";
            EDTitle_Panel.Size = new Size(433, 35);
            EDTitle_Panel.TabIndex = 1;
            // 
            // EditDescEntryRTB_Panel
            // 
            EditDescEntryRTB_Panel.Controls.Add(ED_RTB);
            EditDescEntryRTB_Panel.Location = new Point(21, 82);
            EditDescEntryRTB_Panel.Name = "EditDescEntryRTB_Panel";
            EditDescEntryRTB_Panel.Size = new Size(433, 256);
            EditDescEntryRTB_Panel.TabIndex = 2;
            // 
            // ED_RTB
            // 
            ED_RTB.BackColor = Color.FromArgb(254, 248, 235);
            ED_RTB.BorderStyle = BorderStyle.None;
            ED_RTB.Dock = DockStyle.Fill;
            ED_RTB.Location = new Point(0, 0);
            ED_RTB.Name = "ED_RTB";
            ED_RTB.Size = new Size(433, 256);
            ED_RTB.TabIndex = 0;
            ED_RTB.Text = "";
            // 
            // EDFormat_Panel
            // 
            EDFormat_Panel.Location = new Point(21, 344);
            EDFormat_Panel.Name = "EDFormat_Panel";
            EDFormat_Panel.Size = new Size(433, 33);
            EDFormat_Panel.TabIndex = 3;
            // 
            // EDButton_Panel
            // 
            EDButton_Panel.Controls.Add(Cancel_Btn);
            EDButton_Panel.Controls.Add(EDSubmit_Btn);
            EDButton_Panel.Location = new Point(21, 383);
            EDButton_Panel.Name = "EDButton_Panel";
            EDButton_Panel.Size = new Size(433, 55);
            EDButton_Panel.TabIndex = 4;
            // 
            // EDSubmit_Btn
            // 
            EDSubmit_Btn.BackColor = Color.FromArgb(60, 90, 130);
            EDSubmit_Btn.FlatAppearance.BorderSize = 0;
            EDSubmit_Btn.FlatStyle = FlatStyle.Flat;
            EDSubmit_Btn.Font = new Font("Helvetica 2 BQ ", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EDSubmit_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            EDSubmit_Btn.Location = new Point(315, 3);
            EDSubmit_Btn.Name = "EDSubmit_Btn";
            EDSubmit_Btn.Size = new Size(118, 29);
            EDSubmit_Btn.TabIndex = 0;
            EDSubmit_Btn.Text = "Submit";
            EDSubmit_Btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 90, 130);
            panel1.Controls.Add(EDNavClose_Btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 33);
            panel1.TabIndex = 5;
            // 
            // EDNavClose_Btn
            // 
            EDNavClose_Btn.BackColor = Color.Transparent;
            EDNavClose_Btn.Dock = DockStyle.Right;
            EDNavClose_Btn.FlatAppearance.BorderSize = 0;
            EDNavClose_Btn.FlatStyle = FlatStyle.Flat;
            EDNavClose_Btn.Image = Properties.Resources.close;
            EDNavClose_Btn.Location = new Point(445, 0);
            EDNavClose_Btn.Name = "EDNavClose_Btn";
            EDNavClose_Btn.Size = new Size(30, 33);
            EDNavClose_Btn.TabIndex = 1;
            EDNavClose_Btn.UseVisualStyleBackColor = false;
            EDNavClose_Btn.Click += EDNavClose_Btn_Click;
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
            Cancel_Btn.TabIndex = 3;
            Cancel_Btn.Text = "Cancel";
            Cancel_Btn.UseVisualStyleBackColor = false;
            // 
            // EditDesc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 57);
            ClientSize = new Size(475, 450);
            Controls.Add(panel1);
            Controls.Add(EDButton_Panel);
            Controls.Add(EDFormat_Panel);
            Controls.Add(EditDescEntryRTB_Panel);
            Controls.Add(EDTitle_Panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditDesc";
            Text = "EditDesc";
            EDTitle_Panel.ResumeLayout(false);
            EDTitle_Panel.PerformLayout();
            EditDescEntryRTB_Panel.ResumeLayout(false);
            EDButton_Panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label EditDescTitle_Label;
        private Panel EDTitle_Panel;
        private Panel EditDescEntryRTB_Panel;
        private RichTextBox ED_RTB;
        private Panel EDFormat_Panel;
        private Panel EDButton_Panel;
        private Button EDSubmit_Btn;
        private Panel panel1;
        private Button EDNavClose_Btn;
        private Button Cancel_Btn;
    }
}