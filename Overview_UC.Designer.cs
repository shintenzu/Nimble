namespace Nimble
{
    partial class Overview_UC
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
            components = new System.ComponentModel.Container();
            overviewtitle_Label = new Label();
            overviewtitle_Panel = new Panel();
            projectdesc_Panel = new Panel();
            Desc_RTB = new RichTextBox();
            changedesc_Btn = new Button();
            projectdesc_Label = new Label();
            req_Panel = new Panel();
            label1 = new Label();
            ReqCat_Label = new Label();
            reqs_LB = new ListBox();
            AddReq_Btn = new Button();
            ReqDesc_RTB = new RichTextBox();
            ReqID_Label = new Label();
            projectreq_Label = new Label();
            RD_Label = new Label();
            team_Panel = new Panel();
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
            taskBindingSource = new BindingSource(components);
            task_Panel = new Panel();
            TaskEstEffort_Label = new Label();
            assignID_Label = new Label();
            taskCat_Label = new Label();
            TaskDesc_RTB = new RichTextBox();
            DueDate_Label = new Label();
            StartDate_Label = new Label();
            TaskID_Label = new Label();
            task_LB = new ListBox();
            TD_Label = new Label();
            edittasks_Btn = new Button();
            addtask_Btn = new Button();
            task_Label = new Label();
            taskBindingSource1 = new BindingSource(components);
            overviewtitle_Panel.SuspendLayout();
            projectdesc_Panel.SuspendLayout();
            req_Panel.SuspendLayout();
            team_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).BeginInit();
            task_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource1).BeginInit();
            SuspendLayout();
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
            overviewtitle_Label.Size = new Size(226, 34);
            overviewtitle_Label.TabIndex = 0;
            overviewtitle_Label.Text = "PROJECT OVERVIEW";
            // 
            // overviewtitle_Panel
            // 
            overviewtitle_Panel.Controls.Add(overviewtitle_Label);
            overviewtitle_Panel.Dock = DockStyle.Top;
            overviewtitle_Panel.Location = new Point(0, 0);
            overviewtitle_Panel.Name = "overviewtitle_Panel";
            overviewtitle_Panel.Size = new Size(960, 42);
            overviewtitle_Panel.TabIndex = 1;
            // 
            // projectdesc_Panel
            // 
            projectdesc_Panel.Controls.Add(Desc_RTB);
            projectdesc_Panel.Controls.Add(changedesc_Btn);
            projectdesc_Panel.Controls.Add(projectdesc_Label);
            projectdesc_Panel.Location = new Point(25, 65);
            projectdesc_Panel.Margin = new Padding(10);
            projectdesc_Panel.Name = "projectdesc_Panel";
            projectdesc_Panel.Padding = new Padding(5);
            projectdesc_Panel.Size = new Size(349, 219);
            projectdesc_Panel.TabIndex = 0;
            // 
            // Desc_RTB
            // 
            Desc_RTB.BackColor = Color.FromArgb(254, 248, 235);
            Desc_RTB.BorderStyle = BorderStyle.None;
            Desc_RTB.Location = new Point(5, 33);
            Desc_RTB.Name = "Desc_RTB";
            Desc_RTB.ReadOnly = true;
            Desc_RTB.ScrollBars = RichTextBoxScrollBars.Vertical;
            Desc_RTB.Size = new Size(339, 139);
            Desc_RTB.TabIndex = 7;
            Desc_RTB.Text = "";
            // 
            // changedesc_Btn
            // 
            changedesc_Btn.AutoSize = true;
            changedesc_Btn.BackColor = Color.FromArgb(21, 35, 57);
            changedesc_Btn.BackgroundImageLayout = ImageLayout.None;
            changedesc_Btn.FlatAppearance.BorderSize = 0;
            changedesc_Btn.FlatStyle = FlatStyle.Flat;
            changedesc_Btn.Font = new Font("Helvetica 2 BQ ", 9.749999F);
            changedesc_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            changedesc_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            changedesc_Btn.Location = new Point(5, 189);
            changedesc_Btn.Margin = new Padding(10, 50, 10, 10);
            changedesc_Btn.Name = "changedesc_Btn";
            changedesc_Btn.Size = new Size(146, 25);
            changedesc_Btn.TabIndex = 3;
            changedesc_Btn.Text = "Change Description";
            changedesc_Btn.TextAlign = ContentAlignment.MiddleLeft;
            changedesc_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            changedesc_Btn.UseVisualStyleBackColor = false;
            changedesc_Btn.Click += changedesc_Btn_Click;
            // 
            // projectdesc_Label
            // 
            projectdesc_Label.AutoSize = true;
            projectdesc_Label.BackColor = Color.Transparent;
            projectdesc_Label.Dock = DockStyle.Top;
            projectdesc_Label.FlatStyle = FlatStyle.Flat;
            projectdesc_Label.Font = new Font("Helvetica 2 BQ ", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectdesc_Label.ForeColor = Color.FromArgb(253, 248, 225);
            projectdesc_Label.Location = new Point(5, 5);
            projectdesc_Label.Margin = new Padding(3);
            projectdesc_Label.Name = "projectdesc_Label";
            projectdesc_Label.Padding = new Padding(0, 0, 0, 5);
            projectdesc_Label.Size = new Size(146, 28);
            projectdesc_Label.TabIndex = 1;
            projectdesc_Label.Text = "Project Description";
            // 
            // req_Panel
            // 
            req_Panel.Controls.Add(label1);
            req_Panel.Controls.Add(ReqCat_Label);
            req_Panel.Controls.Add(reqs_LB);
            req_Panel.Controls.Add(AddReq_Btn);
            req_Panel.Controls.Add(ReqDesc_RTB);
            req_Panel.Controls.Add(ReqID_Label);
            req_Panel.Controls.Add(projectreq_Label);
            req_Panel.Controls.Add(RD_Label);
            req_Panel.Location = new Point(25, 296);
            req_Panel.Margin = new Padding(10);
            req_Panel.Name = "req_Panel";
            req_Panel.Padding = new Padding(5);
            req_Panel.Size = new Size(349, 300);
            req_Panel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(253, 248, 225);
            label1.Location = new Point(118, 191);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 5);
            label1.Size = new Size(137, 21);
            label1.TabIndex = 50;
            label1.Text = "Requirements Type: ";
            // 
            // ReqCat_Label
            // 
            ReqCat_Label.AutoSize = true;
            ReqCat_Label.BackColor = Color.Transparent;
            ReqCat_Label.FlatStyle = FlatStyle.Flat;
            ReqCat_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReqCat_Label.ForeColor = Color.FromArgb(253, 248, 225);
            ReqCat_Label.Location = new Point(124, 214);
            ReqCat_Label.Margin = new Padding(3);
            ReqCat_Label.Name = "ReqCat_Label";
            ReqCat_Label.Padding = new Padding(0, 0, 0, 5);
            ReqCat_Label.Size = new Size(11, 21);
            ReqCat_Label.TabIndex = 49;
            ReqCat_Label.Text = "-";
            // 
            // reqs_LB
            // 
            reqs_LB.BackColor = Color.FromArgb(254, 248, 235);
            reqs_LB.FormattingEnabled = true;
            reqs_LB.ItemHeight = 15;
            reqs_LB.Location = new Point(8, 39);
            reqs_LB.Name = "reqs_LB";
            reqs_LB.Size = new Size(104, 214);
            reqs_LB.TabIndex = 41;
            reqs_LB.Click += reqs_LB_Click;
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
            AddReq_Btn.Location = new Point(5, 263);
            AddReq_Btn.Margin = new Padding(10, 50, 10, 10);
            AddReq_Btn.Name = "AddReq_Btn";
            AddReq_Btn.Size = new Size(146, 25);
            AddReq_Btn.TabIndex = 40;
            AddReq_Btn.Text = "Add Requirement";
            AddReq_Btn.TextAlign = ContentAlignment.MiddleLeft;
            AddReq_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddReq_Btn.UseVisualStyleBackColor = false;
            AddReq_Btn.Click += AddReq_Btn_Click;
            // 
            // ReqDesc_RTB
            // 
            ReqDesc_RTB.BackColor = Color.FromArgb(254, 248, 235);
            ReqDesc_RTB.BorderStyle = BorderStyle.None;
            ReqDesc_RTB.Location = new Point(133, 94);
            ReqDesc_RTB.Name = "ReqDesc_RTB";
            ReqDesc_RTB.ReadOnly = true;
            ReqDesc_RTB.ScrollBars = RichTextBoxScrollBars.Vertical;
            ReqDesc_RTB.Size = new Size(195, 85);
            ReqDesc_RTB.TabIndex = 48;
            ReqDesc_RTB.Text = "";
            // 
            // ReqID_Label
            // 
            ReqID_Label.AutoSize = true;
            ReqID_Label.BackColor = Color.Transparent;
            ReqID_Label.FlatStyle = FlatStyle.Flat;
            ReqID_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReqID_Label.ForeColor = Color.FromArgb(253, 248, 225);
            ReqID_Label.Location = new Point(118, 40);
            ReqID_Label.Margin = new Padding(3);
            ReqID_Label.Name = "ReqID_Label";
            ReqID_Label.Padding = new Padding(0, 0, 0, 5);
            ReqID_Label.Size = new Size(116, 21);
            ReqID_Label.TabIndex = 47;
            ReqID_Label.Text = "Requirements ID:";
            // 
            // projectreq_Label
            // 
            projectreq_Label.AutoSize = true;
            projectreq_Label.BackColor = Color.Transparent;
            projectreq_Label.Dock = DockStyle.Top;
            projectreq_Label.FlatStyle = FlatStyle.Flat;
            projectreq_Label.Font = new Font("Helvetica 2 BQ ", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectreq_Label.ForeColor = Color.FromArgb(253, 248, 225);
            projectreq_Label.Location = new Point(5, 5);
            projectreq_Label.Margin = new Padding(3);
            projectreq_Label.Name = "projectreq_Label";
            projectreq_Label.Padding = new Padding(0, 0, 0, 5);
            projectreq_Label.Size = new Size(164, 28);
            projectreq_Label.TabIndex = 1;
            projectreq_Label.Text = "Project Requirements";
            // 
            // RD_Label
            // 
            RD_Label.AutoSize = true;
            RD_Label.BackColor = Color.Transparent;
            RD_Label.FlatStyle = FlatStyle.Flat;
            RD_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RD_Label.ForeColor = Color.FromArgb(253, 248, 225);
            RD_Label.Location = new Point(118, 67);
            RD_Label.Margin = new Padding(3);
            RD_Label.Name = "RD_Label";
            RD_Label.Padding = new Padding(0, 0, 0, 5);
            RD_Label.Size = new Size(178, 21);
            RD_Label.TabIndex = 46;
            RD_Label.Text = "Requirements Description: ";
            // 
            // team_Panel
            // 
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
            team_Panel.Location = new Point(412, 65);
            team_Panel.Margin = new Padding(10);
            team_Panel.Name = "team_Panel";
            team_Panel.Padding = new Padding(5);
            team_Panel.Size = new Size(523, 219);
            team_Panel.TabIndex = 4;
            // 
            // UserEffort_Label
            // 
            UserEffort_Label.AutoSize = true;
            UserEffort_Label.BackColor = Color.Transparent;
            UserEffort_Label.FlatStyle = FlatStyle.Flat;
            UserEffort_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserEffort_Label.ForeColor = Color.FromArgb(253, 248, 225);
            UserEffort_Label.Location = new Point(186, 110);
            UserEffort_Label.Margin = new Padding(3);
            UserEffort_Label.Name = "UserEffort_Label";
            UserEffort_Label.Padding = new Padding(0, 0, 0, 5);
            UserEffort_Label.Size = new Size(76, 21);
            UserEffort_Label.TabIndex = 14;
            UserEffort_Label.Text = "User Effort:";
            // 
            // uTaskCount_Label
            // 
            uTaskCount_Label.AutoSize = true;
            uTaskCount_Label.BackColor = Color.Transparent;
            uTaskCount_Label.FlatStyle = FlatStyle.Flat;
            uTaskCount_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uTaskCount_Label.ForeColor = Color.FromArgb(253, 248, 225);
            uTaskCount_Label.Location = new Point(186, 83);
            uTaskCount_Label.Margin = new Padding(3);
            uTaskCount_Label.Name = "uTaskCount_Label";
            uTaskCount_Label.Padding = new Padding(0, 0, 0, 5);
            uTaskCount_Label.Size = new Size(80, 21);
            uTaskCount_Label.TabIndex = 13;
            uTaskCount_Label.Text = "Task Count:";
            // 
            // UserTask_Label
            // 
            UserTask_Label.AutoSize = true;
            UserTask_Label.BackColor = Color.Transparent;
            UserTask_Label.FlatStyle = FlatStyle.Flat;
            UserTask_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserTask_Label.ForeColor = Color.FromArgb(253, 248, 225);
            UserTask_Label.Location = new Point(409, 29);
            UserTask_Label.Margin = new Padding(3);
            UserTask_Label.Name = "UserTask_Label";
            UserTask_Label.Padding = new Padding(0, 0, 0, 5);
            UserTask_Label.Size = new Size(106, 21);
            UserTask_Label.TabIndex = 12;
            UserTask_Label.Text = "User's Task List:";
            // 
            // UTL_LB
            // 
            UTL_LB.BackColor = Color.FromArgb(254, 248, 235);
            UTL_LB.FormattingEnabled = true;
            UTL_LB.ItemHeight = 15;
            UTL_LB.Location = new Point(409, 56);
            UTL_LB.Name = "UTL_LB";
            UTL_LB.Size = new Size(106, 124);
            UTL_LB.TabIndex = 11;
            // 
            // UserID_Label
            // 
            UserID_Label.AutoSize = true;
            UserID_Label.BackColor = Color.Transparent;
            UserID_Label.FlatStyle = FlatStyle.Flat;
            UserID_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserID_Label.ForeColor = Color.FromArgb(253, 248, 225);
            UserID_Label.Location = new Point(186, 29);
            UserID_Label.Margin = new Padding(3);
            UserID_Label.Name = "UserID_Label";
            UserID_Label.Padding = new Padding(0, 0, 0, 5);
            UserID_Label.Size = new Size(24, 21);
            UserID_Label.TabIndex = 10;
            UserID_Label.Text = "ID:";
            // 
            // TeamName_Label
            // 
            TeamName_Label.AutoSize = true;
            TeamName_Label.BackColor = Color.Transparent;
            TeamName_Label.FlatStyle = FlatStyle.Flat;
            TeamName_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeamName_Label.ForeColor = Color.FromArgb(253, 248, 225);
            TeamName_Label.Location = new Point(186, 56);
            TeamName_Label.Margin = new Padding(3);
            TeamName_Label.Name = "TeamName_Label";
            TeamName_Label.Padding = new Padding(0, 0, 0, 5);
            TeamName_Label.Size = new Size(48, 21);
            TeamName_Label.TabIndex = 9;
            TeamName_Label.Text = "Name:";
            // 
            // user_LB
            // 
            user_LB.BackColor = Color.FromArgb(254, 248, 235);
            user_LB.FormattingEnabled = true;
            user_LB.ItemHeight = 15;
            user_LB.Location = new Point(8, 33);
            user_LB.Name = "user_LB";
            user_LB.Size = new Size(120, 139);
            user_LB.TabIndex = 8;
            user_LB.Click += user_LB_Click;
            user_LB.SelectedIndexChanged += user_LB_SelectedIndexChanged;
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
            editteam_Btn.Location = new Point(186, 189);
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
            addteam_Btn.Location = new Point(5, 189);
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
            team_Label.Size = new Size(121, 28);
            team_Label.TabIndex = 1;
            team_Label.Text = "Team Members";
            // 
            // task_Panel
            // 
            task_Panel.Controls.Add(TaskEstEffort_Label);
            task_Panel.Controls.Add(assignID_Label);
            task_Panel.Controls.Add(taskCat_Label);
            task_Panel.Controls.Add(TaskDesc_RTB);
            task_Panel.Controls.Add(DueDate_Label);
            task_Panel.Controls.Add(StartDate_Label);
            task_Panel.Controls.Add(TaskID_Label);
            task_Panel.Controls.Add(task_LB);
            task_Panel.Controls.Add(TD_Label);
            task_Panel.Controls.Add(edittasks_Btn);
            task_Panel.Controls.Add(addtask_Btn);
            task_Panel.Controls.Add(task_Label);
            task_Panel.Location = new Point(412, 296);
            task_Panel.Margin = new Padding(10);
            task_Panel.Name = "task_Panel";
            task_Panel.Padding = new Padding(5);
            task_Panel.Size = new Size(523, 300);
            task_Panel.TabIndex = 5;
            // 
            // TaskEstEffort_Label
            // 
            TaskEstEffort_Label.AutoSize = true;
            TaskEstEffort_Label.BackColor = Color.Transparent;
            TaskEstEffort_Label.FlatStyle = FlatStyle.Flat;
            TaskEstEffort_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskEstEffort_Label.ForeColor = Color.FromArgb(253, 248, 225);
            TaskEstEffort_Label.Location = new Point(186, 170);
            TaskEstEffort_Label.Margin = new Padding(3);
            TaskEstEffort_Label.Name = "TaskEstEffort_Label";
            TaskEstEffort_Label.Padding = new Padding(0, 0, 0, 5);
            TaskEstEffort_Label.Size = new Size(146, 21);
            TaskEstEffort_Label.TabIndex = 15;
            TaskEstEffort_Label.Text = "Task Estimated Effort: ";
            // 
            // assignID_Label
            // 
            assignID_Label.AutoSize = true;
            assignID_Label.BackColor = Color.Transparent;
            assignID_Label.FlatStyle = FlatStyle.Flat;
            assignID_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assignID_Label.ForeColor = Color.FromArgb(253, 248, 225);
            assignID_Label.Location = new Point(187, 150);
            assignID_Label.Margin = new Padding(3);
            assignID_Label.Name = "assignID_Label";
            assignID_Label.Padding = new Padding(0, 0, 0, 5);
            assignID_Label.Size = new Size(88, 21);
            assignID_Label.TabIndex = 23;
            assignID_Label.Text = "Assigned to: ";
            // 
            // taskCat_Label
            // 
            taskCat_Label.AutoSize = true;
            taskCat_Label.BackColor = Color.Transparent;
            taskCat_Label.FlatStyle = FlatStyle.Flat;
            taskCat_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskCat_Label.ForeColor = Color.FromArgb(253, 248, 225);
            taskCat_Label.Location = new Point(186, 191);
            taskCat_Label.Margin = new Padding(3);
            taskCat_Label.Name = "taskCat_Label";
            taskCat_Label.Padding = new Padding(0, 0, 0, 5);
            taskCat_Label.Size = new Size(72, 21);
            taskCat_Label.TabIndex = 18;
            taskCat_Label.Text = "Category: ";
            // 
            // TaskDesc_RTB
            // 
            TaskDesc_RTB.BackColor = Color.FromArgb(254, 248, 235);
            TaskDesc_RTB.BorderStyle = BorderStyle.None;
            TaskDesc_RTB.Location = new Point(195, 79);
            TaskDesc_RTB.Name = "TaskDesc_RTB";
            TaskDesc_RTB.ReadOnly = true;
            TaskDesc_RTB.ScrollBars = RichTextBoxScrollBars.Vertical;
            TaskDesc_RTB.Size = new Size(320, 63);
            TaskDesc_RTB.TabIndex = 8;
            TaskDesc_RTB.Text = "";
            // 
            // DueDate_Label
            // 
            DueDate_Label.AutoSize = true;
            DueDate_Label.BackColor = Color.Transparent;
            DueDate_Label.FlatStyle = FlatStyle.Flat;
            DueDate_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DueDate_Label.ForeColor = Color.FromArgb(253, 248, 225);
            DueDate_Label.Location = new Point(187, 236);
            DueDate_Label.Margin = new Padding(3);
            DueDate_Label.Name = "DueDate_Label";
            DueDate_Label.Padding = new Padding(0, 0, 0, 5);
            DueDate_Label.Size = new Size(73, 21);
            DueDate_Label.TabIndex = 17;
            DueDate_Label.Text = "Due Date: ";
            // 
            // StartDate_Label
            // 
            StartDate_Label.AutoSize = true;
            StartDate_Label.BackColor = Color.Transparent;
            StartDate_Label.FlatStyle = FlatStyle.Flat;
            StartDate_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartDate_Label.ForeColor = Color.FromArgb(253, 248, 225);
            StartDate_Label.Location = new Point(186, 214);
            StartDate_Label.Margin = new Padding(3);
            StartDate_Label.Name = "StartDate_Label";
            StartDate_Label.Padding = new Padding(0, 0, 0, 5);
            StartDate_Label.Size = new Size(78, 21);
            StartDate_Label.TabIndex = 16;
            StartDate_Label.Text = "Start Date: ";
            // 
            // TaskID_Label
            // 
            TaskID_Label.AutoSize = true;
            TaskID_Label.BackColor = Color.Transparent;
            TaskID_Label.FlatStyle = FlatStyle.Flat;
            TaskID_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskID_Label.ForeColor = Color.FromArgb(253, 248, 225);
            TaskID_Label.Location = new Point(186, 37);
            TaskID_Label.Margin = new Padding(3);
            TaskID_Label.Name = "TaskID_Label";
            TaskID_Label.Padding = new Padding(0, 0, 0, 5);
            TaskID_Label.Size = new Size(56, 21);
            TaskID_Label.TabIndex = 14;
            TaskID_Label.Text = "Task ID:";
            // 
            // task_LB
            // 
            task_LB.BackColor = Color.FromArgb(254, 248, 235);
            task_LB.FormattingEnabled = true;
            task_LB.ItemHeight = 15;
            task_LB.Location = new Point(8, 39);
            task_LB.Name = "task_LB";
            task_LB.Size = new Size(120, 214);
            task_LB.TabIndex = 13;
            task_LB.Click += task_LB_Click;
            // 
            // TD_Label
            // 
            TD_Label.AutoSize = true;
            TD_Label.BackColor = Color.Transparent;
            TD_Label.FlatStyle = FlatStyle.Flat;
            TD_Label.Font = new Font("Helvetica", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TD_Label.ForeColor = Color.FromArgb(253, 248, 225);
            TD_Label.Location = new Point(186, 56);
            TD_Label.Margin = new Padding(3);
            TD_Label.Name = "TD_Label";
            TD_Label.Padding = new Padding(0, 0, 0, 5);
            TD_Label.Size = new Size(118, 21);
            TD_Label.TabIndex = 13;
            TD_Label.Text = "Task Description: ";
            // 
            // edittasks_Btn
            // 
            edittasks_Btn.AutoSize = true;
            edittasks_Btn.BackColor = Color.FromArgb(21, 35, 57);
            edittasks_Btn.BackgroundImageLayout = ImageLayout.None;
            edittasks_Btn.FlatAppearance.BorderSize = 0;
            edittasks_Btn.FlatStyle = FlatStyle.Flat;
            edittasks_Btn.Font = new Font("Helvetica 2 BQ ", 9.749999F);
            edittasks_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            edittasks_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            edittasks_Btn.Location = new Point(186, 271);
            edittasks_Btn.Margin = new Padding(10, 50, 10, 10);
            edittasks_Btn.Name = "edittasks_Btn";
            edittasks_Btn.Size = new Size(146, 25);
            edittasks_Btn.TabIndex = 8;
            edittasks_Btn.Text = "Edit Task";
            edittasks_Btn.TextAlign = ContentAlignment.MiddleLeft;
            edittasks_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            edittasks_Btn.UseVisualStyleBackColor = false;
            edittasks_Btn.Click += edittasks_Btn_Click;
            // 
            // addtask_Btn
            // 
            addtask_Btn.AutoSize = true;
            addtask_Btn.BackColor = Color.FromArgb(21, 35, 57);
            addtask_Btn.BackgroundImageLayout = ImageLayout.None;
            addtask_Btn.FlatAppearance.BorderSize = 0;
            addtask_Btn.FlatStyle = FlatStyle.Flat;
            addtask_Btn.Font = new Font("Helvetica 2 BQ ", 9.749999F);
            addtask_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            addtask_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            addtask_Btn.Location = new Point(5, 271);
            addtask_Btn.Margin = new Padding(10, 50, 10, 10);
            addtask_Btn.Name = "addtask_Btn";
            addtask_Btn.Size = new Size(146, 25);
            addtask_Btn.TabIndex = 3;
            addtask_Btn.Text = "Add Task";
            addtask_Btn.TextAlign = ContentAlignment.MiddleLeft;
            addtask_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addtask_Btn.UseVisualStyleBackColor = false;
            addtask_Btn.Click += addtask_Btn_Click;
            // 
            // task_Label
            // 
            task_Label.AutoSize = true;
            task_Label.BackColor = Color.Transparent;
            task_Label.Dock = DockStyle.Top;
            task_Label.FlatStyle = FlatStyle.Flat;
            task_Label.Font = new Font("Helvetica 2 BQ ", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            task_Label.ForeColor = Color.FromArgb(253, 248, 225);
            task_Label.Location = new Point(5, 5);
            task_Label.Margin = new Padding(3);
            task_Label.Name = "task_Label";
            task_Label.Padding = new Padding(0, 0, 0, 5);
            task_Label.Size = new Size(51, 28);
            task_Label.TabIndex = 1;
            task_Label.Text = "Tasks";
            // 
            // Overview_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 90, 130);
            Controls.Add(task_Panel);
            Controls.Add(team_Panel);
            Controls.Add(overviewtitle_Panel);
            Controls.Add(req_Panel);
            Controls.Add(projectdesc_Panel);
            Name = "Overview_UC";
            Size = new Size(960, 615);
            Load += Overview_UC_Load;
            overviewtitle_Panel.ResumeLayout(false);
            overviewtitle_Panel.PerformLayout();
            projectdesc_Panel.ResumeLayout(false);
            projectdesc_Panel.PerformLayout();
            req_Panel.ResumeLayout(false);
            req_Panel.PerformLayout();
            team_Panel.ResumeLayout(false);
            team_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).EndInit();
            task_Panel.ResumeLayout(false);
            task_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label overviewtitle_Label;
        private Panel overviewtitle_Panel;
        private Panel projectdesc_Panel;
        private RichTextBox Desc_RTB;
        private Button changedesc_Btn;
        private Label projectdesc_Label;
        private Panel req_Panel;
        private Label projectreq_Label;
        private Panel team_Panel;
        private Button editteam_Btn;
        private Button addteam_Btn;
        private Label team_Label;
        private Panel task_Panel;
        private Button edittasks_Btn;
        private Button addtask_Btn;
        private Label task_Label;
        private BindingSource taskBindingSource;
        private BindingSource taskBindingSource1;
        private ListBox user_LB;
        private Label TeamName_Label;
        private Label UserID_Label;
        private Label UserTask_Label;
        private ListBox UTL_LB;
        private Label TaskID_Label;
        private ListBox task_LB;
        private Label TD_Label;
        private Label uTaskCount_Label;
        private Label UserEffort_Label;
        private Label TaskEstEffort_Label;
        private Label DueDate_Label;
        private Label StartDate_Label;
        private RichTextBox TaskDesc_RTB;
        private Label taskCat_Label;
        private Label assignID_Label;
        private ListBox reqs_LB;
        private Button AddReq_Btn;
        private Label ReqCat_Label;
        private RichTextBox ReqDesc_RTB;
        private Label ReqID_Label;
        private Label RD_Label;
        private Label label1;
    }
}
