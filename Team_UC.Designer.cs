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
            editteam_Btn = new Button();
            team_DGV = new DataGridView();
            addteam_Btn = new Button();
            team_Label = new Label();
            overviewtitle_Panel = new Panel();
            overviewtitle_Label = new Label();
            overviewbody_Panel.SuspendLayout();
            team_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)team_DGV).BeginInit();
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
            team_Panel.Controls.Add(editteam_Btn);
            team_Panel.Controls.Add(team_DGV);
            team_Panel.Controls.Add(addteam_Btn);
            team_Panel.Controls.Add(team_Label);
            team_Panel.Location = new Point(24, 17);
            team_Panel.Margin = new Padding(10);
            team_Panel.Name = "team_Panel";
            team_Panel.Padding = new Padding(5);
            team_Panel.Size = new Size(926, 528);
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
            editteam_Btn.Location = new Point(186, 488);
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
            team_DGV.Size = new Size(896, 443);
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
            addteam_Btn.Location = new Point(5, 488);
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
            ((System.ComponentModel.ISupportInitialize)team_DGV).EndInit();
            overviewtitle_Panel.ResumeLayout(false);
            overviewtitle_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel overviewbody_Panel;
        private Panel team_Panel;
        private Button editteam_Btn;
        private DataGridView team_DGV;
        private Button addteam_Btn;
        private Label team_Label;
        private Panel overviewtitle_Panel;
        private Label overviewtitle_Label;
    }
}
