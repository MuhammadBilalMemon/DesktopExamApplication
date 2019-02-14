namespace ExamProgram
{
    partial class SelectUserExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectUserExam));
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.listBoxSelectedCourse = new System.Windows.Forms.ListBox();
            this.btnCourseRemoveForCourse = new System.Windows.Forms.Button();
            this.btnAddCourseForCourse = new System.Windows.Forms.Button();
            this.grbUserSelection = new System.Windows.Forms.GroupBox();
            this.listBoxUserExam = new System.Windows.Forms.ListBox();
            this.ListBoxUserSelectedForExam = new System.Windows.Forms.ListBox();
            this.dateTimePiker = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveUsersForUser = new System.Windows.Forms.Button();
            this.btnAddUsersForUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbUserSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(420, 556);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 61);
            this.btnSave.TabIndex = 21;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.listBoxCourse);
            this.groupBox1.Controls.Add(this.listBoxSelectedCourse);
            this.groupBox1.Controls.Add(this.btnCourseRemoveForCourse);
            this.groupBox1.Controls.Add(this.btnAddCourseForCourse);
            this.groupBox1.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 260);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Selection";
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Italic);
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 22;
            this.listBoxCourse.Location = new System.Drawing.Point(12, 30);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(174, 202);
            this.listBoxCourse.TabIndex = 0;
            // 
            // listBoxSelectedCourse
            // 
            this.listBoxSelectedCourse.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Italic);
            this.listBoxSelectedCourse.FormattingEnabled = true;
            this.listBoxSelectedCourse.ItemHeight = 22;
            this.listBoxSelectedCourse.Location = new System.Drawing.Point(300, 30);
            this.listBoxSelectedCourse.Name = "listBoxSelectedCourse";
            this.listBoxSelectedCourse.Size = new System.Drawing.Size(174, 202);
            this.listBoxSelectedCourse.TabIndex = 1;
            // 
            // btnCourseRemoveForCourse
            // 
            this.btnCourseRemoveForCourse.Font = new System.Drawing.Font("Californian FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseRemoveForCourse.Location = new System.Drawing.Point(201, 149);
            this.btnCourseRemoveForCourse.Name = "btnCourseRemoveForCourse";
            this.btnCourseRemoveForCourse.Size = new System.Drawing.Size(87, 32);
            this.btnCourseRemoveForCourse.TabIndex = 2;
            this.btnCourseRemoveForCourse.Text = "Remove";
            this.btnCourseRemoveForCourse.UseVisualStyleBackColor = true;
            this.btnCourseRemoveForCourse.Click += new System.EventHandler(this.btnCourseRemoveForCourse_Click);
            // 
            // btnAddCourseForCourse
            // 
            this.btnAddCourseForCourse.Font = new System.Drawing.Font("Californian FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourseForCourse.Location = new System.Drawing.Point(201, 91);
            this.btnAddCourseForCourse.Name = "btnAddCourseForCourse";
            this.btnAddCourseForCourse.Size = new System.Drawing.Size(87, 32);
            this.btnAddCourseForCourse.TabIndex = 3;
            this.btnAddCourseForCourse.Text = "Select";
            this.btnAddCourseForCourse.UseVisualStyleBackColor = true;
            this.btnAddCourseForCourse.Click += new System.EventHandler(this.btnAddCourseForCourse_Click);
            // 
            // grbUserSelection
            // 
            this.grbUserSelection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbUserSelection.Controls.Add(this.listBoxUserExam);
            this.grbUserSelection.Controls.Add(this.ListBoxUserSelectedForExam);
            this.grbUserSelection.Controls.Add(this.dateTimePiker);
            this.grbUserSelection.Controls.Add(this.btnRemoveUsersForUser);
            this.grbUserSelection.Controls.Add(this.btnAddUsersForUser);
            this.grbUserSelection.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUserSelection.Location = new System.Drawing.Point(12, 8);
            this.grbUserSelection.Name = "grbUserSelection";
            this.grbUserSelection.Size = new System.Drawing.Size(486, 277);
            this.grbUserSelection.TabIndex = 19;
            this.grbUserSelection.TabStop = false;
            this.grbUserSelection.Text = "User Selection";
            // 
            // listBoxUserExam
            // 
            this.listBoxUserExam.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUserExam.FormattingEnabled = true;
            this.listBoxUserExam.ItemHeight = 22;
            this.listBoxUserExam.Location = new System.Drawing.Point(12, 36);
            this.listBoxUserExam.Name = "listBoxUserExam";
            this.listBoxUserExam.Size = new System.Drawing.Size(174, 202);
            this.listBoxUserExam.TabIndex = 0;
            // 
            // ListBoxUserSelectedForExam
            // 
            this.ListBoxUserSelectedForExam.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxUserSelectedForExam.FormattingEnabled = true;
            this.ListBoxUserSelectedForExam.ItemHeight = 22;
            this.ListBoxUserSelectedForExam.Location = new System.Drawing.Point(300, 36);
            this.ListBoxUserSelectedForExam.Name = "ListBoxUserSelectedForExam";
            this.ListBoxUserSelectedForExam.Size = new System.Drawing.Size(174, 202);
            this.ListBoxUserSelectedForExam.TabIndex = 1;
            // 
            // dateTimePiker
            // 
            this.dateTimePiker.AllowDrop = true;
            this.dateTimePiker.Location = new System.Drawing.Point(131, 245);
            this.dateTimePiker.Name = "dateTimePiker";
            this.dateTimePiker.Size = new System.Drawing.Size(224, 31);
            this.dateTimePiker.TabIndex = 5;
            this.dateTimePiker.ValueChanged += new System.EventHandler(this.dateTimePiker_ValueChanged);
            // 
            // btnRemoveUsersForUser
            // 
            this.btnRemoveUsersForUser.Font = new System.Drawing.Font("Californian FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUsersForUser.Location = new System.Drawing.Point(201, 148);
            this.btnRemoveUsersForUser.Name = "btnRemoveUsersForUser";
            this.btnRemoveUsersForUser.Size = new System.Drawing.Size(87, 31);
            this.btnRemoveUsersForUser.TabIndex = 2;
            this.btnRemoveUsersForUser.Text = "Remove";
            this.btnRemoveUsersForUser.UseVisualStyleBackColor = true;
            this.btnRemoveUsersForUser.Click += new System.EventHandler(this.btnRemoveUsersForUser_Click);
            // 
            // btnAddUsersForUser
            // 
            this.btnAddUsersForUser.Font = new System.Drawing.Font("Californian FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsersForUser.Location = new System.Drawing.Point(201, 92);
            this.btnAddUsersForUser.Name = "btnAddUsersForUser";
            this.btnAddUsersForUser.Size = new System.Drawing.Size(87, 32);
            this.btnAddUsersForUser.TabIndex = 3;
            this.btnAddUsersForUser.Text = "Select";
            this.btnAddUsersForUser.UseVisualStyleBackColor = true;
            this.btnAddUsersForUser.Click += new System.EventHandler(this.btnAddUsersForUser_Click);
            // 
            // SelectUserExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 624);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbUserSelection);
            this.Name = "SelectUserExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select UserExam";
            this.Load += new System.EventHandler(this.SelectUserExam_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbUserSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.ListBox listBoxSelectedCourse;
        private System.Windows.Forms.Button btnCourseRemoveForCourse;
        private System.Windows.Forms.Button btnAddCourseForCourse;
        private System.Windows.Forms.GroupBox grbUserSelection;
        private System.Windows.Forms.ListBox listBoxUserExam;
        private System.Windows.Forms.ListBox ListBoxUserSelectedForExam;
        private System.Windows.Forms.DateTimePicker dateTimePiker;
        private System.Windows.Forms.Button btnRemoveUsersForUser;
        private System.Windows.Forms.Button btnAddUsersForUser;
    }
}