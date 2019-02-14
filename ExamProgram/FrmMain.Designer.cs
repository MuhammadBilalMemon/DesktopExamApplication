namespace ExamProgram
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStudentDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.addQuestionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.userExamToolStripMenuItem,
            this.deleteQuestionToolStripMenuItem,
            this.showExamToolStripMenuItem,
            this.showStudentDataToolStripMenuItem});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // addQuestionToolStripMenuItem
            // 
            this.addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            this.addQuestionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addQuestionToolStripMenuItem.Text = "Add Question";
            this.addQuestionToolStripMenuItem.Click += new System.EventHandler(this.addQuestionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem1.Text = "Add Answer";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // userExamToolStripMenuItem
            // 
            this.userExamToolStripMenuItem.Name = "userExamToolStripMenuItem";
            this.userExamToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.userExamToolStripMenuItem.Text = "User Exam";
            this.userExamToolStripMenuItem.Click += new System.EventHandler(this.userExamToolStripMenuItem_Click);
            // 
            // deleteQuestionToolStripMenuItem
            // 
            this.deleteQuestionToolStripMenuItem.Name = "deleteQuestionToolStripMenuItem";
            this.deleteQuestionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteQuestionToolStripMenuItem.Text = "Delete Question";
            // 
            // showExamToolStripMenuItem
            // 
            this.showExamToolStripMenuItem.Name = "showExamToolStripMenuItem";
            this.showExamToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.showExamToolStripMenuItem.Text = "Show Exam ";
            // 
            // showStudentDataToolStripMenuItem
            // 
            this.showStudentDataToolStripMenuItem.Name = "showStudentDataToolStripMenuItem";
            this.showStudentDataToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.showStudentDataToolStripMenuItem.Text = "Show Student Data";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examsToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // examsToolStripMenuItem
            // 
            this.examsToolStripMenuItem.Name = "examsToolStripMenuItem";
            this.examsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.examsToolStripMenuItem.Text = "Exam\'s";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 360);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStudentDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}