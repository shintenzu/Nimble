namespace Nimble
{
    partial class Team_UC
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
            team_Panel = new Panel();
            UserRole_Label = new Label();
            label1 = new Label();
            TaskID_Label = new Label();
            TD_Label = new Label();
            UserEffort_Label = new Label();
            uTaskCount_Label = new Label();
            UserTask_Label = new Label();
            UTL_LB = new ListBox();
            UserID_Label = new Label();
            TeamName_Label = new Label();
            user_LB = new ListBox();
            editteam_Btn = new Button();
            addteam_Btn = new Button();
            team_Label = new Label();
            overviewtitle_Panel = new Panel();
            overviewtitle_Label = new Label();
            overviewbody_Panel.SuspendLayout();
            team_Panel.SuspendLayout();
            overviewtitle_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // overviewbody_Panel
            // 
            overviewbody_Panel.Controls.Add(team_Panel);
            overviewbody_Panel.Dock = DockStyle.Fill;
            overviewbody_Panel.Location = new Point(0, 42);
            overviewbody_Panel.Name = "overviewbody_Panel";
            overviewbody_Panel.Size = new Size(960, 573);
            overviewbody_Panel.TabIndex = 4;
            // 
            // team_Panel
            // 
            team_Panel.Controls.Add(UserRole_Label);
            team_Panel.Controls.Add(label1);
            team_Panel.Controls.Add(TaskID_Label);
            team_Panel.Controls.Add(TD_Label);
            team_Panel.Controls.Add(UserEffort_Label);
            team_Panel.Controls.Add(uTaskCount_Label);
            team_Panel.Controls.Add(UserTask_Label);
            team_Panel.Controls.Add(UTL_LB);
            team_Panel.Controls.Add(UserID_Label);
            team_Panel.Controls.Add(TeamName_Label);
            team_Panel.Controls.Add(user_LB);
            team_Panel.Controls.Add(editteam_Btn);
            team_Panel.Controls.Add(addteam_Btn);
            team_Panel.Controls.Add(team_Label);
            team_Panel.Location = new Point(24, 17);
            team_Panel.Margin = new Padding(10);
            team_Panel.Name = "team_Panel";
            team_Panel.Padding = new Padding(5);
            team_Panel.Size = new Size(926, 528);
            team_Panel.TabIndex = 4;
            // 
            // UserRole_Label
            // 
            UserRole_Label.AutoSize = true;
            UserRole_Label.BackColor = Color.Transparent;
            UserRole_Label.FlatStyle = FlatStyle.Flat;
            UserRole_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserRole_Label.ForeColor = Color.FromArgb(253, 248, 225);
            UserRole_Label.Location = new Point(139, 161);
            UserRole_Label.Margin = new Padding(3);
            UserRole_Label.Name = "UserRole_Label";
            UserRole_Label.Padding = new Padding(0, 0, 0, 5);
            UserRole_Label.Size = new Size(72, 21);
            UserRole_Label.TabIndex = 38;
            UserRole_Label.Text = "User Role:";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(245, 215, 140);
            label1.Location = new Point(355, 40);
            label1.Name = "label1";
            label1.Size = new Size(2, 429);
            label1.TabIndex = 37;
            // 
            // TaskID_Label
            // 
            TaskID_Label.AutoSize = true;
            TaskID_Label.BackColor = Color.Transparent;
            TaskID_Label.FlatStyle = FlatStyle.Flat;
            TaskID_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskID_Label.ForeColor = Color.FromArgb(253, 248, 225);
            TaskID_Label.Location = new Point(554, 52);
            TaskID_Label.Margin = new Padding(3);
            TaskID_Label.Name = "TaskID_Label";
            TaskID_Label.Padding = new Padding(0, 0, 0, 5);
            TaskID_Label.Size = new Size(56, 21);
            TaskID_Label.TabIndex = 22;
            TaskID_Label.Text = "Task ID:";
            // 
            // TD_Label
            // 
            TD_Label.AutoSize = true;
            TD_Label.BackColor = Color.Transparent;
            TD_Label.FlatStyle = FlatStyle.Flat;
            TD_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TD_Label.ForeColor = Color.FromArgb(253, 248, 225);
            TD_Label.Location = new Point(554, 79);
            TD_Label.Margin = new Padding(3);
            TD_Label.Name = "TD_Label";
            TD_Label.Padding = new Padding(0, 0, 0, 5);
            TD_Label.Size = new Size(118, 21);
            TD_Label.TabIndex = 21;
            TD_Label.Text = "Task Description: ";
            // 
            // UserEffort_Label
            // 
            UserEffort_Label.AutoSize = true;
            UserEffort_Label.BackColor = Color.Transparent;
            UserEffort_Label.FlatStyle = FlatStyle.Flat;
            UserEffort_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserEffort_Label.ForeColor = Color.FromArgb(253, 248, 225);
            UserEffort_Label.Location = new Point(139, 133);
            UserEffort_Label.Margin = new Padding(3);
            UserEffort_Label.Name = "UserEffort_Label";
            UserEffort_Label.Padding = new Padding(0, 0, 0, 5);
            UserEffort_Label.Size = new Size(76, 21);
            UserEffort_Label.TabIndex = 20;
            UserEffort_Label.Text = "User Effort:";
            // 
            // uTaskCount_Label
            // 
            uTaskCount_Label.AutoSize = true;
            uTaskCount_Label.BackColor = Color.Transparent;
            uTaskCount_Label.FlatStyle = FlatStyle.Flat;
            uTaskCount_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uTaskCount_Label.ForeColor = Color.FromArgb(253, 248, 225);
            uTaskCount_Label.Location = new Point(139, 106);
            uTaskCount_Label.Margin = new Padding(3);
            uTaskCount_Label.Name = "uTaskCount_Label";
            uTaskCount_Label.Padding = new Padding(0, 0, 0, 5);
            uTaskCount_Label.Size = new Size(80, 21);
            uTaskCount_Label.TabIndex = 19;
            uTaskCount_Label.Text = "Task Count:";
            // 
            // UserTask_Label
            // 
            UserTask_Label.AutoSize = true;
            UserTask_Label.BackColor = Color.Transparent;
            UserTask_Label.FlatStyle = FlatStyle.Flat;
            UserTask_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserTask_Label.ForeColor = Color.FromArgb(253, 248, 225);
            UserTask_Label.Location = new Point(407, 52);
            UserTask_Label.Margin = new Padding(3);
            UserTask_Label.Name = "UserTask_Label";
            UserTask_Label.Padding = new Padding(0, 0, 0, 5);
            UserTask_Label.Size = new Size(106, 21);
            UserTask_Label.TabIndex = 18;
            UserTask_Label.Text = "User's Task List:";
            // 
            // UTL_LB
            // 
            UTL_LB.BackColor = Color.FromArgb(254, 248, 235);
            UTL_LB.FormattingEnabled = true;
            UTL_LB.ItemHeight = 15;
            UTL_LB.Location = new Point(407, 79);
            UTL_LB.Name = "UTL_LB";
            UTL_LB.Size = new Size(106, 394);
            UTL_LB.TabIndex = 17;
            UTL_LB.Click += UTL_LB_Click;
            // 
            // UserID_Label
            // 
            UserID_Label.AutoSize = true;
            UserID_Label.BackColor = Color.Transparent;
            UserID_Label.FlatStyle = FlatStyle.Flat;
            UserID_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserID_Label.ForeColor = Color.FromArgb(253, 248, 225);
            UserID_Label.Location = new Point(139, 52);
            UserID_Label.Margin = new Padding(3);
            UserID_Label.Name = "UserID_Label";
            UserID_Label.Padding = new Padding(0, 0, 0, 5);
            UserID_Label.Size = new Size(24, 21);
            UserID_Label.TabIndex = 16;
            UserID_Label.Text = "ID:";
            // 
            // TeamName_Label
            // 
            TeamName_Label.AutoSize = true;
            TeamName_Label.BackColor = Color.Transparent;
            TeamName_Label.FlatStyle = FlatStyle.Flat;
            TeamName_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeamName_Label.ForeColor = Color.FromArgb(253, 248, 225);
            TeamName_Label.Location = new Point(139, 79);
            TeamName_Label.Margin = new Padding(3);
            TeamName_Label.Name = "TeamName_Label";
            TeamName_Label.Padding = new Padding(0, 0, 0, 5);
            TeamName_Label.Size = new Size(48, 21);
            TeamName_Label.TabIndex = 15;
            TeamName_Label.Text = "Name:";
            // 
            // user_LB
            // 
            user_LB.BackColor = Color.FromArgb(254, 248, 235);
            user_LB.FormattingEnabled = true;
            user_LB.ItemHeight = 15;
            user_LB.Location = new Point(8, 41);
            user_LB.Name = "user_LB";
            user_LB.Size = new Size(120, 424);
            user_LB.TabIndex = 14;
            user_LB.Click += user_LB_Click;
            // 
            // editteam_Btn
            // 
            editteam_Btn.AutoSize = true;
            editteam_Btn.BackColor = Color.FromArgb(21, 35, 57);
            editteam_Btn.BackgroundImageLayout = ImageLayout.None;
            editteam_Btn.FlatAppearance.BorderSize = 0;
            editteam_Btn.FlatStyle = FlatStyle.Flat;
            editteam_Btn.Font = new Font("Helvetica 2 BQ ", 9.749999F);
            editteam_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            editteam_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            editteam_Btn.Location = new Point(186, 488);
            editteam_Btn.Margin = new Padding(10, 50, 10, 10);
            editteam_Btn.Name = "editteam_Btn";
            editteam_Btn.Size = new Size(146, 25);
            editteam_Btn.TabIndex = 6;
            editteam_Btn.Text = "Edit Team Member";
            editteam_Btn.TextAlign = ContentAlignment.MiddleLeft;
            editteam_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            editteam_Btn.UseVisualStyleBackColor = false;
            editteam_Btn.Click += editteam_Btn_Click;
            // 
            // addteam_Btn
            // 
            addteam_Btn.AutoSize = true;
            addteam_Btn.BackColor = Color.FromArgb(21, 35, 57);
            addteam_Btn.BackgroundImageLayout = ImageLayout.None;
            addteam_Btn.FlatAppearance.BorderSize = 0;
            addteam_Btn.FlatStyle = FlatStyle.Flat;
            addteam_Btn.Font = new Font("Helvetica 2 BQ ", 9.749999F);
            addteam_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            addteam_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            addteam_Btn.Location = new Point(5, 488);
            addteam_Btn.Margin = new Padding(10, 50, 10, 10);
            addteam_Btn.Name = "addteam_Btn";
            addteam_Btn.Size = new Size(146, 25);
            addteam_Btn.TabIndex = 3;
            addteam_Btn.Text = "Add Team Member";
            addteam_Btn.TextAlign = ContentAlignment.MiddleLeft;
            addteam_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addteam_Btn.UseVisualStyleBackColor = false;
            addteam_Btn.Click += addteam_Btn_Click;
            // 
            // team_Label
            // 
            team_Label.AutoSize = true;
            team_Label.BackColor = Color.Transparent;
            team_Label.Dock = DockStyle.Top;
            team_Label.FlatStyle = FlatStyle.Flat;
            team_Label.Font = new Font("Helvetica 2 BQ ", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            team_Label.ForeColor = Color.FromArgb(253, 248, 225);
            team_Label.Location = new Point(5, 5);
            team_Label.Margin = new Padding(3);
            team_Label.Name = "team_Label";
            team_Label.Padding = new Padding(0, 0, 0, 5);
            team_Label.Size = new Size(79, 28);
            team_Label.TabIndex = 1;
            team_Label.Text = "Team List";
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
            overviewtitle_Label.Size = new Size(190, 34);
            overviewtitle_Label.TabIndex = 0;
            overviewtitle_Label.Text = "TEAM MEMBERS";
            // 
            // Team_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 90, 130);
            Controls.Add(overviewbody_Panel);
            Controls.Add(overviewtitle_Panel);
            Name = "Team_UC";
            Size = new Size(960, 615);
            overviewbody_Panel.ResumeLayout(false);
            team_Panel.ResumeLayout(false);
            team_Panel.PerformLayout();
            overviewtitle_Panel.ResumeLayout(false);
            overviewtitle_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel overviewbody_Panel;
        private Panel team_Panel;
        private Button editteam_Btn;
        private Button addteam_Btn;
        private Label team_Label;
        private Panel overviewtitle_Panel;
        private Label overviewtitle_Label;
        private Label uTaskCount_Label;
        private Label UserTask_Label;
        private ListBox UTL_LB;
        private Label UserID_Label;
        private Label TeamName_Label;
        private ListBox user_LB;
        private Label UserEffort_Label;
        private Label TaskID_Label;
        private Label TD_Label;
        private Label label1;
        private Label UserRole_Label;
    }
}
