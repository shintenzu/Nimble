namespace Nimble
{
    partial class Req_UC
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
            reqs_LB = new ListBox();
            EditReq_Btn = new Button();
            overviewtitle_Panel = new Panel();
            overviewtitle_Label = new Label();
            ReqCat_Label = new Label();
            AddReq_Btn = new Button();
            task_Label = new Label();
            ReqDesc_RTB = new RichTextBox();
            ReqID_Label = new Label();
            RD_Label = new Label();
            label1 = new Label();
            overviewtitle_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // reqs_LB
            // 
            reqs_LB.BackColor = Color.FromArgb(254, 248, 235);
            reqs_LB.FormattingEnabled = true;
            reqs_LB.ItemHeight = 15;
            reqs_LB.Location = new Point(32, 128);
            reqs_LB.Name = "reqs_LB";
            reqs_LB.Size = new Size(120, 424);
            reqs_LB.TabIndex = 39;
            reqs_LB.Click += reqs_LB_Click;
            // 
            // EditReq_Btn
            // 
            EditReq_Btn.AutoSize = true;
            EditReq_Btn.BackColor = Color.FromArgb(21, 35, 57);
            EditReq_Btn.BackgroundImageLayout = ImageLayout.None;
            EditReq_Btn.FlatAppearance.BorderSize = 0;
            EditReq_Btn.FlatStyle = FlatStyle.Flat;
            EditReq_Btn.Font = new Font("Helvetica 2 BQ ", 9.749999F);
            EditReq_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            EditReq_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            EditReq_Btn.Location = new Point(209, 572);
            EditReq_Btn.Margin = new Padding(10, 50, 10, 10);
            EditReq_Btn.Name = "EditReq_Btn";
            EditReq_Btn.Size = new Size(146, 25);
            EditReq_Btn.TabIndex = 38;
            EditReq_Btn.Text = "Edit Requirements";
            EditReq_Btn.TextAlign = ContentAlignment.MiddleLeft;
            EditReq_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            EditReq_Btn.UseVisualStyleBackColor = false;
            EditReq_Btn.Click += EditReq_Btn_Click;
            // 
            // overviewtitle_Panel
            // 
            overviewtitle_Panel.Controls.Add(overviewtitle_Label);
            overviewtitle_Panel.Dock = DockStyle.Top;
            overviewtitle_Panel.Location = new Point(0, 0);
            overviewtitle_Panel.Name = "overviewtitle_Panel";
            overviewtitle_Panel.Size = new Size(960, 42);
            overviewtitle_Panel.TabIndex = 36;
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
            overviewtitle_Label.Size = new Size(184, 34);
            overviewtitle_Label.TabIndex = 0;
            overviewtitle_Label.Text = "REQUIREMENTS";
            // 
            // ReqCat_Label
            // 
            ReqCat_Label.AutoSize = true;
            ReqCat_Label.BackColor = Color.Transparent;
            ReqCat_Label.FlatStyle = FlatStyle.Flat;
            ReqCat_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReqCat_Label.ForeColor = Color.FromArgb(253, 248, 225);
            ReqCat_Label.Location = new Point(219, 152);
            ReqCat_Label.Margin = new Padding(3);
            ReqCat_Label.Name = "ReqCat_Label";
            ReqCat_Label.Padding = new Padding(0, 0, 0, 5);
            ReqCat_Label.Size = new Size(137, 21);
            ReqCat_Label.TabIndex = 45;
            ReqCat_Label.Text = "Requirements Type: ";
            // 
            // AddReq_Btn
            // 
            AddReq_Btn.AutoSize = true;
            AddReq_Btn.BackColor = Color.FromArgb(21, 35, 57);
            AddReq_Btn.BackgroundImageLayout = ImageLayout.None;
            AddReq_Btn.FlatAppearance.BorderSize = 0;
            AddReq_Btn.FlatStyle = FlatStyle.Flat;
            AddReq_Btn.Font = new Font("Helvetica 2 BQ ", 9.749999F);
            AddReq_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            AddReq_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            AddReq_Btn.Location = new Point(28, 572);
            AddReq_Btn.Margin = new Padding(10, 50, 10, 10);
            AddReq_Btn.Name = "AddReq_Btn";
            AddReq_Btn.Size = new Size(146, 25);
            AddReq_Btn.TabIndex = 37;
            AddReq_Btn.Text = "Add Requirement";
            AddReq_Btn.TextAlign = ContentAlignment.MiddleLeft;
            AddReq_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddReq_Btn.UseVisualStyleBackColor = false;
            AddReq_Btn.Click += AddReq_Btn_Click;
            // 
            // task_Label
            // 
            task_Label.AutoSize = true;
            task_Label.BackColor = Color.Transparent;
            task_Label.FlatStyle = FlatStyle.Flat;
            task_Label.Font = new Font("Helvetica 2 BQ ", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            task_Label.ForeColor = Color.FromArgb(253, 248, 225);
            task_Label.Location = new Point(28, 89);
            task_Label.Margin = new Padding(3);
            task_Label.Name = "task_Label";
            task_Label.Padding = new Padding(0, 0, 0, 5);
            task_Label.Size = new Size(139, 28);
            task_Label.TabIndex = 35;
            task_Label.Text = "Requirements List";
            // 
            // ReqDesc_RTB
            // 
            ReqDesc_RTB.BackColor = Color.FromArgb(254, 248, 235);
            ReqDesc_RTB.BorderStyle = BorderStyle.None;
            ReqDesc_RTB.Location = new Point(223, 206);
            ReqDesc_RTB.Name = "ReqDesc_RTB";
            ReqDesc_RTB.ReadOnly = true;
            ReqDesc_RTB.ScrollBars = RichTextBoxScrollBars.Vertical;
            ReqDesc_RTB.Size = new Size(664, 85);
            ReqDesc_RTB.TabIndex = 42;
            ReqDesc_RTB.Text = "";
            // 
            // ReqID_Label
            // 
            ReqID_Label.AutoSize = true;
            ReqID_Label.BackColor = Color.Transparent;
            ReqID_Label.FlatStyle = FlatStyle.Flat;
            ReqID_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReqID_Label.ForeColor = Color.FromArgb(253, 248, 225);
            ReqID_Label.Location = new Point(219, 124);
            ReqID_Label.Margin = new Padding(3);
            ReqID_Label.Name = "ReqID_Label";
            ReqID_Label.Padding = new Padding(0, 0, 0, 5);
            ReqID_Label.Size = new Size(116, 21);
            ReqID_Label.TabIndex = 41;
            ReqID_Label.Text = "Requirements ID:";
            // 
            // RD_Label
            // 
            RD_Label.AutoSize = true;
            RD_Label.BackColor = Color.Transparent;
            RD_Label.FlatStyle = FlatStyle.Flat;
            RD_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RD_Label.ForeColor = Color.FromArgb(253, 248, 225);
            RD_Label.Location = new Point(219, 179);
            RD_Label.Margin = new Padding(3);
            RD_Label.Name = "RD_Label";
            RD_Label.Padding = new Padding(0, 0, 0, 5);
            RD_Label.Size = new Size(178, 21);
            RD_Label.TabIndex = 40;
            RD_Label.Text = "Requirements Description: ";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(245, 215, 140);
            label1.Location = new Point(191, 125);
            label1.Name = "label1";
            label1.Size = new Size(2, 429);
            label1.TabIndex = 46;
            // 
            // Req_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 90, 130);
            Controls.Add(label1);
            Controls.Add(reqs_LB);
            Controls.Add(EditReq_Btn);
            Controls.Add(overviewtitle_Panel);
            Controls.Add(ReqCat_Label);
            Controls.Add(AddReq_Btn);
            Controls.Add(task_Label);
            Controls.Add(ReqDesc_RTB);
            Controls.Add(ReqID_Label);
            Controls.Add(RD_Label);
            Name = "Req_UC";
            Size = new Size(960, 615);
            overviewtitle_Panel.ResumeLayout(false);
            overviewtitle_Panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox reqs_LB;
        private Button EditReq_Btn;
        private Panel overviewtitle_Panel;
        private Label overviewtitle_Label;
        private Label ReqCat_Label;
        private Button AddReq_Btn;
        private Label task_Label;
        private RichTextBox ReqDesc_RTB;
        private Label ReqID_Label;
        private Label RD_Label;
        private Label label1;
    }
}
