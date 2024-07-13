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
            overviewtitle_Label = new Label();
            overviewtitle_Panel = new Panel();
            projectdesc_Panel = new Panel();
            Desc_RTB = new RichTextBox();
            changedesc_Btn = new Button();
            projectdesc_Label = new Label();
            req_Panel = new Panel();
            req_RTB = new RichTextBox();
            editreq_Btn = new Button();
            projectreq_Label = new Label();
            team_Panel = new Panel();
            editteam_Btn = new Button();
            team_DGV = new DataGridView();
            addteam_Btn = new Button();
            team_Label = new Label();
            task_Panel = new Panel();
            edittasks_Btn = new Button();
            task_DGV = new DataGridView();
            addtask_Btn = new Button();
            task_Label = new Label();
            overviewbody_Panel = new Panel();
            overviewtitle_Panel.SuspendLayout();
            projectdesc_Panel.SuspendLayout();
            req_Panel.SuspendLayout();
            team_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)team_DGV).BeginInit();
            task_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)task_DGV).BeginInit();
            overviewbody_Panel.SuspendLayout();
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
            projectdesc_Panel.Location = new Point(24, 17);
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
            Desc_RTB.Size = new Size(339, 147);
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
            req_Panel.Controls.Add(req_RTB);
            req_Panel.Controls.Add(editreq_Btn);
            req_Panel.Controls.Add(projectreq_Label);
            req_Panel.Location = new Point(24, 248);
            req_Panel.Margin = new Padding(10);
            req_Panel.Name = "req_Panel";
            req_Panel.Padding = new Padding(5);
            req_Panel.Size = new Size(349, 300);
            req_Panel.TabIndex = 4;
            // 
            // req_RTB
            // 
            req_RTB.BackColor = Color.FromArgb(254, 248, 235);
            req_RTB.BorderStyle = BorderStyle.None;
            req_RTB.Location = new Point(5, 39);
            req_RTB.Name = "req_RTB";
            req_RTB.ReadOnly = true;
            req_RTB.ScrollBars = RichTextBoxScrollBars.Vertical;
            req_RTB.Size = new Size(339, 221);
            req_RTB.TabIndex = 8;
            req_RTB.Text = "";
            // 
            // editreq_Btn
            // 
            editreq_Btn.AutoSize = true;
            editreq_Btn.BackColor = Color.FromArgb(21, 35, 57);
            editreq_Btn.BackgroundImageLayout = ImageLayout.None;
            editreq_Btn.FlatAppearance.BorderSize = 0;
            editreq_Btn.FlatStyle = FlatStyle.Flat;
            editreq_Btn.Font = new Font("Helvetica 2 BQ ", 9.749999F);
            editreq_Btn.ForeColor = Color.FromArgb(253, 248, 225);
            editreq_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            editreq_Btn.Location = new Point(5, 271);
            editreq_Btn.Margin = new Padding(10, 50, 10, 10);
            editreq_Btn.Name = "editreq_Btn";
            editreq_Btn.Size = new Size(146, 25);
            editreq_Btn.TabIndex = 3;
            editreq_Btn.Text = "Edit Requirements";
            editreq_Btn.TextAlign = ContentAlignment.MiddleLeft;
            editreq_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            editreq_Btn.UseVisualStyleBackColor = false;
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
            // team_Panel
            // 
            team_Panel.Controls.Add(editteam_Btn);
            team_Panel.Controls.Add(team_DGV);
            team_Panel.Controls.Add(addteam_Btn);
            team_Panel.Controls.Add(team_Label);
            team_Panel.Location = new Point(411, 17);
            team_Panel.Margin = new Padding(10);
            team_Panel.Name = "team_Panel";
            team_Panel.Padding = new Padding(5);
            team_Panel.Size = new Size(523, 219);
            team_Panel.TabIndex = 4;
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
            // 
            // team_DGV
            // 
            team_DGV.BackgroundColor = Color.FromArgb(254, 248, 235);
            team_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            team_DGV.Location = new Point(5, 33);
            team_DGV.Name = "team_DGV";
            team_DGV.Size = new Size(510, 147);
            team_DGV.TabIndex = 5;
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
            task_Panel.Controls.Add(edittasks_Btn);
            task_Panel.Controls.Add(task_DGV);
            task_Panel.Controls.Add(addtask_Btn);
            task_Panel.Controls.Add(task_Label);
            task_Panel.Location = new Point(411, 248);
            task_Panel.Margin = new Padding(10);
            task_Panel.Name = "task_Panel";
            task_Panel.Padding = new Padding(5);
            task_Panel.Size = new Size(523, 300);
            task_Panel.TabIndex = 5;
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
            // 
            // task_DGV
            // 
            task_DGV.BackgroundColor = Color.FromArgb(254, 248, 235);
            task_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            task_DGV.Location = new Point(5, 33);
            task_DGV.Name = "task_DGV";
            task_DGV.Size = new Size(510, 227);
            task_DGV.TabIndex = 7;
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
            // overviewbody_Panel
            // 
            overviewbody_Panel.Controls.Add(task_Panel);
            overviewbody_Panel.Controls.Add(team_Panel);
            overviewbody_Panel.Controls.Add(req_Panel);
            overviewbody_Panel.Controls.Add(projectdesc_Panel);
            overviewbody_Panel.Dock = DockStyle.Fill;
            overviewbody_Panel.Location = new Point(0, 42);
            overviewbody_Panel.Name = "overviewbody_Panel";
            overviewbody_Panel.Size = new Size(960, 573);
            overviewbody_Panel.TabIndex = 2;
            // 
            // Overview_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 90, 130);
            Controls.Add(overviewbody_Panel);
            Controls.Add(overviewtitle_Panel);
            Name = "Overview_UC";
            Size = new Size(960, 615);
            overviewtitle_Panel.ResumeLayout(false);
            overviewtitle_Panel.PerformLayout();
            projectdesc_Panel.ResumeLayout(false);
            projectdesc_Panel.PerformLayout();
            req_Panel.ResumeLayout(false);
            req_Panel.PerformLayout();
            team_Panel.ResumeLayout(false);
            team_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)team_DGV).EndInit();
            task_Panel.ResumeLayout(false);
            task_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)task_DGV).EndInit();
            overviewbody_Panel.ResumeLayout(false);
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
        private RichTextBox req_RTB;
        private Button editreq_Btn;
        private Label projectreq_Label;
        private Panel team_Panel;
        private Button editteam_Btn;
        private DataGridView team_DGV;
        private Button addteam_Btn;
        private Label team_Label;
        private Panel task_Panel;
        private Button edittasks_Btn;
        private DataGridView task_DGV;
        private Button addtask_Btn;
        private Label task_Label;
        private Panel overviewbody_Panel;
    }
}
