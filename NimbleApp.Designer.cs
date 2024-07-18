namespace Nimble
{
    partial class NimbleApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nav_Panel = new Panel();
            navclose_Btn = new Button();
            side_Panel = new Panel();
            exit_Btn = new Button();
            back_Btn = new Button();
            selectproject_Panel = new Panel();
            projectselect_Cbox = new ComboBox();
            selectproject_Btn = new Button();
            risk_Btn = new Button();
            effort_Btn = new Button();
            tasks_Btn = new Button();
            team_Btn = new Button();
            overview_Btn = new Button();
            dashboard_Btn = new Button();
            logo_Box = new PictureBox();
            account_Panel = new Panel();
            PO_Label = new Label();
            PM_Label = new Label();
            overview_uc1 = new Overview_UC();
            team_uc1 = new Team_UC();
            task_uc1 = new Task_UC();
            effort_uc1 = new Effort_UC();
            risk_uc1 = new Risk_UC();
            nav_Panel.SuspendLayout();
            side_Panel.SuspendLayout();
            selectproject_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_Box).BeginInit();
            account_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // nav_Panel
            // 
            nav_Panel.BackColor = Color.FromArgb(8, 23, 45);
            nav_Panel.Controls.Add(navclose_Btn);
            nav_Panel.Dock = DockStyle.Top;
            nav_Panel.Location = new Point(0, 0);
            nav_Panel.Name = "nav_Panel";
            nav_Panel.Size = new Size(1200, 30);
            nav_Panel.TabIndex = 0;
            // 
            // navclose_Btn
            // 
            navclose_Btn.BackColor = Color.Transparent;
            navclose_Btn.Dock = DockStyle.Right;
            navclose_Btn.FlatAppearance.BorderSize = 0;
            navclose_Btn.FlatStyle = FlatStyle.Flat;
            navclose_Btn.Image = Properties.Resources.close;
            navclose_Btn.Location = new Point(1170, 0);
            navclose_Btn.Name = "navclose_Btn";
            navclose_Btn.Size = new Size(30, 30);
            navclose_Btn.TabIndex = 0;
            navclose_Btn.UseVisualStyleBackColor = false;
            navclose_Btn.Click += navclose_Btn_Click;
            // 
            // side_Panel
            // 
            side_Panel.BackColor = Color.FromArgb(21, 35, 57);
            side_Panel.Controls.Add(exit_Btn);
            side_Panel.Controls.Add(back_Btn);
            side_Panel.Controls.Add(selectproject_Panel);
            side_Panel.Controls.Add(selectproject_Btn);
            side_Panel.Controls.Add(risk_Btn);
            side_Panel.Controls.Add(effort_Btn);
            side_Panel.Controls.Add(tasks_Btn);
            side_Panel.Controls.Add(team_Btn);
            side_Panel.Controls.Add(overview_Btn);
            side_Panel.Controls.Add(dashboard_Btn);
            side_Panel.Controls.Add(logo_Box);
            side_Panel.Dock = DockStyle.Left;
            side_Panel.Location = new Point(0, 30);
            side_Panel.Name = "side_Panel";
            side_Panel.Size = new Size(240, 645);
            side_Panel.TabIndex = 1;
            // 
            // exit_Btn
            // 
            exit_Btn.BackColor = Color.FromArgb(21, 35, 57);
            exit_Btn.BackgroundImageLayout = ImageLayout.None;
            exit_Btn.Dock = DockStyle.Top;
            exit_Btn.FlatAppearance.BorderSize = 0;
            exit_Btn.FlatStyle = FlatStyle.Flat;
            exit_Btn.Font = new Font("Helvetica 2 BQ ", 15.7499981F, FontStyle.Bold);
            exit_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            exit_Btn.Image = Properties.Resources.Empty_Icon;
            exit_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            exit_Btn.Location = new Point(0, 530);
            exit_Btn.Name = "exit_Btn";
            exit_Btn.Padding = new Padding(10, 0, 0, 0);
            exit_Btn.Size = new Size(240, 40);
            exit_Btn.TabIndex = 9;
            exit_Btn.Text = "Exit App";
            exit_Btn.TextAlign = ContentAlignment.MiddleLeft;
            exit_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            exit_Btn.UseVisualStyleBackColor = false;
            exit_Btn.Click += exit_Btn_Click;
            exit_Btn.MouseClick += exit_Btn_MouseClick;
            // 
            // back_Btn
            // 
            back_Btn.BackColor = Color.FromArgb(21, 35, 57);
            back_Btn.BackgroundImageLayout = ImageLayout.None;
            back_Btn.Dock = DockStyle.Top;
            back_Btn.FlatAppearance.BorderSize = 0;
            back_Btn.FlatStyle = FlatStyle.Flat;
            back_Btn.Font = new Font("Helvetica 2 BQ ", 15.7499981F, FontStyle.Bold);
            back_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            back_Btn.Image = Properties.Resources.return_104;
            back_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            back_Btn.Location = new Point(0, 490);
            back_Btn.Name = "back_Btn";
            back_Btn.Padding = new Padding(10, 0, 0, 0);
            back_Btn.Size = new Size(240, 40);
            back_Btn.TabIndex = 8;
            back_Btn.Text = "Back to Sign-In";
            back_Btn.TextAlign = ContentAlignment.MiddleLeft;
            back_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            back_Btn.UseVisualStyleBackColor = false;
            // 
            // selectproject_Panel
            // 
            selectproject_Panel.Controls.Add(projectselect_Cbox);
            selectproject_Panel.Dock = DockStyle.Top;
            selectproject_Panel.Location = new Point(0, 370);
            selectproject_Panel.Name = "selectproject_Panel";
            selectproject_Panel.Size = new Size(240, 120);
            selectproject_Panel.TabIndex = 7;
            // 
            // projectselect_Cbox
            // 
            projectselect_Cbox.BackColor = SystemColors.Window;
            projectselect_Cbox.FlatStyle = FlatStyle.Flat;
            projectselect_Cbox.FormattingEnabled = true;
            projectselect_Cbox.Location = new Point(58, 17);
            projectselect_Cbox.Name = "projectselect_Cbox";
            projectselect_Cbox.Size = new Size(146, 23);
            projectselect_Cbox.TabIndex = 0;
            // 
            // selectproject_Btn
            // 
            selectproject_Btn.BackColor = Color.FromArgb(21, 35, 57);
            selectproject_Btn.BackgroundImageLayout = ImageLayout.None;
            selectproject_Btn.Dock = DockStyle.Top;
            selectproject_Btn.FlatAppearance.BorderSize = 0;
            selectproject_Btn.FlatStyle = FlatStyle.Flat;
            selectproject_Btn.Font = new Font("Helvetica 2 BQ ", 15.7499981F, FontStyle.Bold);
            selectproject_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            selectproject_Btn.Image = Properties.Resources.Empty_Icon;
            selectproject_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            selectproject_Btn.Location = new Point(0, 330);
            selectproject_Btn.Name = "selectproject_Btn";
            selectproject_Btn.Padding = new Padding(10, 0, 0, 0);
            selectproject_Btn.Size = new Size(240, 40);
            selectproject_Btn.TabIndex = 6;
            selectproject_Btn.Text = "Select Project";
            selectproject_Btn.TextAlign = ContentAlignment.MiddleLeft;
            selectproject_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            selectproject_Btn.UseVisualStyleBackColor = false;
            // 
            // risk_Btn
            // 
            risk_Btn.BackColor = Color.FromArgb(21, 35, 57);
            risk_Btn.BackgroundImageLayout = ImageLayout.None;
            risk_Btn.Dock = DockStyle.Top;
            risk_Btn.FlatAppearance.BorderSize = 0;
            risk_Btn.FlatStyle = FlatStyle.Flat;
            risk_Btn.Font = new Font("Helvetica 2 BQ ", 14.2499981F);
            risk_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            risk_Btn.Image = Properties.Resources.Empty_Icon;
            risk_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            risk_Btn.Location = new Point(0, 290);
            risk_Btn.Name = "risk_Btn";
            risk_Btn.Padding = new Padding(40, 0, 0, 0);
            risk_Btn.Size = new Size(240, 40);
            risk_Btn.TabIndex = 5;
            risk_Btn.Text = "Risk";
            risk_Btn.TextAlign = ContentAlignment.MiddleLeft;
            risk_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            risk_Btn.UseVisualStyleBackColor = false;
            risk_Btn.Click += risk_Btn_Click;
            // 
            // effort_Btn
            // 
            effort_Btn.BackColor = Color.FromArgb(21, 35, 57);
            effort_Btn.BackgroundImageLayout = ImageLayout.None;
            effort_Btn.Dock = DockStyle.Top;
            effort_Btn.FlatAppearance.BorderSize = 0;
            effort_Btn.FlatStyle = FlatStyle.Flat;
            effort_Btn.Font = new Font("Helvetica 2 BQ ", 14.2499981F);
            effort_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            effort_Btn.Image = Properties.Resources.Empty_Icon;
            effort_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            effort_Btn.Location = new Point(0, 250);
            effort_Btn.Name = "effort_Btn";
            effort_Btn.Padding = new Padding(40, 0, 0, 0);
            effort_Btn.Size = new Size(240, 40);
            effort_Btn.TabIndex = 4;
            effort_Btn.Text = "Effort Monitor";
            effort_Btn.TextAlign = ContentAlignment.MiddleLeft;
            effort_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            effort_Btn.UseVisualStyleBackColor = false;
            effort_Btn.Click += effort_Btn_Click;
            // 
            // tasks_Btn
            // 
            tasks_Btn.BackColor = Color.FromArgb(21, 35, 57);
            tasks_Btn.BackgroundImageLayout = ImageLayout.None;
            tasks_Btn.Dock = DockStyle.Top;
            tasks_Btn.FlatAppearance.BorderSize = 0;
            tasks_Btn.FlatStyle = FlatStyle.Flat;
            tasks_Btn.Font = new Font("Helvetica 2 BQ ", 14.2499981F);
            tasks_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            tasks_Btn.Image = Properties.Resources.Empty_Icon;
            tasks_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            tasks_Btn.Location = new Point(0, 210);
            tasks_Btn.Name = "tasks_Btn";
            tasks_Btn.Padding = new Padding(40, 0, 0, 0);
            tasks_Btn.Size = new Size(240, 40);
            tasks_Btn.TabIndex = 3;
            tasks_Btn.Text = "Tasks";
            tasks_Btn.TextAlign = ContentAlignment.MiddleLeft;
            tasks_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            tasks_Btn.UseVisualStyleBackColor = false;
            tasks_Btn.Click += tasks_Btn_Click;
            // 
            // team_Btn
            // 
            team_Btn.BackColor = Color.FromArgb(21, 35, 57);
            team_Btn.BackgroundImageLayout = ImageLayout.None;
            team_Btn.Dock = DockStyle.Top;
            team_Btn.FlatAppearance.BorderSize = 0;
            team_Btn.FlatStyle = FlatStyle.Flat;
            team_Btn.Font = new Font("Helvetica 2 BQ ", 14.2499981F);
            team_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            team_Btn.Image = Properties.Resources.Empty_Icon;
            team_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            team_Btn.Location = new Point(0, 170);
            team_Btn.Name = "team_Btn";
            team_Btn.Padding = new Padding(40, 0, 0, 0);
            team_Btn.Size = new Size(240, 40);
            team_Btn.TabIndex = 2;
            team_Btn.Text = "Team";
            team_Btn.TextAlign = ContentAlignment.MiddleLeft;
            team_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            team_Btn.UseVisualStyleBackColor = false;
            team_Btn.Click += team_Btn_Click;
            // 
            // overview_Btn
            // 
            overview_Btn.BackColor = Color.FromArgb(21, 35, 57);
            overview_Btn.BackgroundImageLayout = ImageLayout.None;
            overview_Btn.Dock = DockStyle.Top;
            overview_Btn.FlatAppearance.BorderSize = 0;
            overview_Btn.FlatStyle = FlatStyle.Flat;
            overview_Btn.Font = new Font("Helvetica 2 BQ ", 14.2499981F);
            overview_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            overview_Btn.Image = Properties.Resources.Empty_Icon;
            overview_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            overview_Btn.Location = new Point(0, 130);
            overview_Btn.Name = "overview_Btn";
            overview_Btn.Padding = new Padding(40, 0, 0, 0);
            overview_Btn.Size = new Size(240, 40);
            overview_Btn.TabIndex = 1;
            overview_Btn.Text = "Overview";
            overview_Btn.TextAlign = ContentAlignment.MiddleLeft;
            overview_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            overview_Btn.UseVisualStyleBackColor = false;
            overview_Btn.Click += overview_Btn_Click;
            // 
            // dashboard_Btn
            // 
            dashboard_Btn.BackColor = Color.FromArgb(21, 35, 57);
            dashboard_Btn.BackgroundImageLayout = ImageLayout.None;
            dashboard_Btn.Dock = DockStyle.Top;
            dashboard_Btn.FlatAppearance.BorderSize = 0;
            dashboard_Btn.FlatStyle = FlatStyle.Flat;
            dashboard_Btn.Font = new Font("Helvetica 2 BQ ", 15.7499981F, FontStyle.Bold);
            dashboard_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            dashboard_Btn.Image = Properties.Resources.Empty_Icon;
            dashboard_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_Btn.Location = new Point(0, 90);
            dashboard_Btn.Name = "dashboard_Btn";
            dashboard_Btn.Padding = new Padding(10, 0, 0, 0);
            dashboard_Btn.Size = new Size(240, 40);
            dashboard_Btn.TabIndex = 0;
            dashboard_Btn.Text = "Dashboard";
            dashboard_Btn.TextAlign = ContentAlignment.MiddleLeft;
            dashboard_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboard_Btn.UseVisualStyleBackColor = false;
            // 
            // logo_Box
            // 
            logo_Box.Dock = DockStyle.Top;
            logo_Box.Image = Properties.Resources.Nimble_Logo;
            logo_Box.Location = new Point(0, 0);
            logo_Box.Name = "logo_Box";
            logo_Box.Size = new Size(240, 90);
            logo_Box.TabIndex = 0;
            logo_Box.TabStop = false;
            // 
            // account_Panel
            // 
            account_Panel.Controls.Add(PO_Label);
            account_Panel.Controls.Add(PM_Label);
            account_Panel.Dock = DockStyle.Top;
            account_Panel.Location = new Point(240, 30);
            account_Panel.Name = "account_Panel";
            account_Panel.Size = new Size(960, 30);
            account_Panel.TabIndex = 2;
            // 
            // PO_Label
            // 
            PO_Label.AutoSize = true;
            PO_Label.BackColor = Color.Transparent;
            PO_Label.FlatStyle = FlatStyle.Flat;
            PO_Label.Font = new Font("Helvetica 2 BQ ", 15.7499981F, FontStyle.Bold);
            PO_Label.ForeColor = Color.FromArgb(253, 248, 225);
            PO_Label.Location = new Point(0, 0);
            PO_Label.Name = "PO_Label";
            PO_Label.Padding = new Padding(20, 5, 0, 0);
            PO_Label.Size = new Size(358, 30);
            PO_Label.TabIndex = 9;
            PO_Label.Text = "Project Owner: NA (Add A Project Owner)";
            // 
            // PM_Label
            // 
            PM_Label.AutoSize = true;
            PM_Label.BackColor = Color.Transparent;
            PM_Label.FlatStyle = FlatStyle.Flat;
            PM_Label.Font = new Font("Helvetica 2 BQ ", 15.7499981F, FontStyle.Bold);
            PM_Label.ForeColor = Color.FromArgb(253, 248, 225);
            PM_Label.Location = new Point(504, 0);
            PM_Label.Name = "PM_Label";
            PM_Label.Padding = new Padding(20, 5, 0, 0);
            PM_Label.Size = new Size(394, 30);
            PM_Label.TabIndex = 8;
            PM_Label.Text = "Project Manager: NA (Add A Project Manager)";
            // 
            // overview_uc1
            // 
            overview_uc1.BackColor = Color.FromArgb(60, 90, 130);
            overview_uc1.Location = new Point(240, 60);
            overview_uc1.Name = "overview_uc1";
            overview_uc1.Size = new Size(960, 615);
            overview_uc1.TabIndex = 3;
            // 
            // team_uc1
            // 
            team_uc1.BackColor = Color.FromArgb(60, 90, 130);
            team_uc1.Location = new Point(240, 93);
            team_uc1.Name = "team_uc1";
            team_uc1.Size = new Size(960, 615);
            team_uc1.TabIndex = 4;
            // 
            // task_uc1
            // 
            task_uc1.BackColor = Color.FromArgb(60, 90, 130);
            task_uc1.Location = new Point(240, 126);
            task_uc1.Name = "task_uc1";
            task_uc1.Size = new Size(960, 615);
            task_uc1.TabIndex = 5;
            // 
            // effort_uc1
            // 
            effort_uc1.BackColor = Color.FromArgb(60, 90, 130);
            effort_uc1.Location = new Point(240, 160);
            effort_uc1.Name = "effort_uc1";
            effort_uc1.Size = new Size(960, 615);
            effort_uc1.TabIndex = 6;
            // 
            // risk_uc1
            // 
            risk_uc1.BackColor = Color.FromArgb(60, 90, 130);
            risk_uc1.Location = new Point(240, 206);
            risk_uc1.Name = "risk_uc1";
            risk_uc1.Size = new Size(960, 615);
            risk_uc1.TabIndex = 7;
            // 
            // NimbleApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 90, 130);
            ClientSize = new Size(1200, 675);
            Controls.Add(risk_uc1);
            Controls.Add(effort_uc1);
            Controls.Add(task_uc1);
            Controls.Add(team_uc1);
            Controls.Add(overview_uc1);
            Controls.Add(account_Panel);
            Controls.Add(side_Panel);
            Controls.Add(nav_Panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NimbleApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nimble";
            Load += Nimble_Load;
            nav_Panel.ResumeLayout(false);
            side_Panel.ResumeLayout(false);
            selectproject_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo_Box).EndInit();
            account_Panel.ResumeLayout(false);
            account_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel nav_Panel;
        private Panel side_Panel;
        private PictureBox logo_Box;
        private Panel account_Panel;
        private Button dashboard_Btn;
        private Button overview_Btn;
        private Button tasks_Btn;
        private Button team_Btn;
        private Button back_Btn;
        private Panel selectproject_Panel;
        private Button selectproject_Btn;
        private Button effort_Btn;
        private Button risk_Btn;
        private Button exit_Btn;
        private ComboBox projectselect_Cbox;
        private Button navclose_Btn;
        private Overview_UC overview_uc1;
        private Team_UC team_uc1;
        private Task_UC task_uc1;
        private Effort_UC effort_uc1;        
        private Risk_UC risk_uc1;
        public Label PM_Label;
        public Label PO_Label;
    }
}
