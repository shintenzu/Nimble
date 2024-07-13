namespace Nimble
{
    partial class Effort_UC
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
            task_Panel = new Panel();
            task_Label = new Label();
            overviewtitle_Panel = new Panel();
            overviewtitle_Label = new Label();
            overviewbody_Panel.SuspendLayout();
            task_Panel.SuspendLayout();
            overviewtitle_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // overviewbody_Panel
            // 
            overviewbody_Panel.Controls.Add(task_Panel);
            overviewbody_Panel.Dock = DockStyle.Fill;
            overviewbody_Panel.Location = new Point(0, 42);
            overviewbody_Panel.Name = "overviewbody_Panel";
            overviewbody_Panel.Size = new Size(960, 573);
            overviewbody_Panel.TabIndex = 6;
            // 
            // task_Panel
            // 
            task_Panel.Controls.Add(task_Label);
            task_Panel.Location = new Point(24, 17);
            task_Panel.Margin = new Padding(10);
            task_Panel.Name = "task_Panel";
            task_Panel.Padding = new Padding(5);
            task_Panel.Size = new Size(926, 528);
            task_Panel.TabIndex = 5;
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
            task_Label.Size = new Size(164, 28);
            task_Label.TabIndex = 1;
            task_Label.Text = "Developement Stages";
            // 
            // overviewtitle_Panel
            // 
            overviewtitle_Panel.Controls.Add(overviewtitle_Label);
            overviewtitle_Panel.Dock = DockStyle.Top;
            overviewtitle_Panel.Location = new Point(0, 0);
            overviewtitle_Panel.Name = "overviewtitle_Panel";
            overviewtitle_Panel.Size = new Size(960, 42);
            overviewtitle_Panel.TabIndex = 5;
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
            overviewtitle_Label.Size = new Size(202, 34);
            overviewtitle_Label.TabIndex = 0;
            overviewtitle_Label.Text = "EFFORT MONITOR";
            // 
            // Effort_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 90, 130);
            Controls.Add(overviewbody_Panel);
            Controls.Add(overviewtitle_Panel);
            Name = "Effort_UC";
            Size = new Size(960, 615);
            overviewbody_Panel.ResumeLayout(false);
            task_Panel.ResumeLayout(false);
            task_Panel.PerformLayout();
            overviewtitle_Panel.ResumeLayout(false);
            overviewtitle_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel overviewbody_Panel;
        private Panel task_Panel;
        private Label task_Label;
        private Panel overviewtitle_Panel;
        private Label overviewtitle_Label;
    }
}
