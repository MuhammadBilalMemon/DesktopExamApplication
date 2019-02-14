namespace ExamProgram
{
    partial class frmAddQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQuestion));
            this.grbAddQuestion = new System.Windows.Forms.GroupBox();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbShowQuestion = new System.Windows.Forms.GroupBox();
            this.dgvSeeQuestion = new System.Windows.Forms.DataGridView();
            this.dgvQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbAddQuestion.SuspendLayout();
            this.grbShowQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeeQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAddQuestion
            // 
            this.grbAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAddQuestion.Controls.Add(this.cmbCourseName);
            this.grbAddQuestion.Controls.Add(this.btnAdd);
            this.grbAddQuestion.Controls.Add(this.txtQuestion);
            this.grbAddQuestion.Controls.Add(this.label2);
            this.grbAddQuestion.Controls.Add(this.label1);
            this.grbAddQuestion.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold);
            this.grbAddQuestion.Location = new System.Drawing.Point(17, 19);
            this.grbAddQuestion.Name = "grbAddQuestion";
            this.grbAddQuestion.Size = new System.Drawing.Size(625, 176);
            this.grbAddQuestion.TabIndex = 10;
            this.grbAddQuestion.TabStop = false;
            this.grbAddQuestion.Text = "Add Question";
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(127, 34);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(420, 26);
            this.cmbCourseName.TabIndex = 14;
            this.cmbCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbCourseName_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(457, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 15);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(127, 80);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(420, 26);
            this.txtQuestion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Course Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(540, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 53);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbShowQuestion
            // 
            this.grbShowQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grbShowQuestion.Controls.Add(this.dgvSeeQuestion);
            this.grbShowQuestion.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbShowQuestion.Location = new System.Drawing.Point(17, 203);
            this.grbShowQuestion.Name = "grbShowQuestion";
            this.grbShowQuestion.Size = new System.Drawing.Size(625, 306);
            this.grbShowQuestion.TabIndex = 9;
            this.grbShowQuestion.TabStop = false;
            this.grbShowQuestion.Text = "See Question";
            // 
            // dgvSeeQuestion
            // 
            this.dgvSeeQuestion.AllowUserToAddRows = false;
            this.dgvSeeQuestion.AllowUserToDeleteRows = false;
            this.dgvSeeQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSeeQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeeQuestion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSeeQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeeQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvQuestion,
            this.dgvQuestionID,
            this.dgvCourseID});
            this.dgvSeeQuestion.Location = new System.Drawing.Point(6, 22);
            this.dgvSeeQuestion.Name = "dgvSeeQuestion";
            this.dgvSeeQuestion.ReadOnly = true;
            this.dgvSeeQuestion.Size = new System.Drawing.Size(613, 278);
            this.dgvSeeQuestion.TabIndex = 2;
            this.dgvSeeQuestion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeeQuestion_CellContentClick);
            // 
            // dgvQuestion
            // 
            this.dgvQuestion.DataPropertyName = "Question";
            this.dgvQuestion.HeaderText = "Question";
            this.dgvQuestion.Name = "dgvQuestion";
            this.dgvQuestion.ReadOnly = true;
            // 
            // dgvQuestionID
            // 
            this.dgvQuestionID.DataPropertyName = "QuestionID";
            this.dgvQuestionID.HeaderText = "QuestionID";
            this.dgvQuestionID.Name = "dgvQuestionID";
            this.dgvQuestionID.ReadOnly = true;
            this.dgvQuestionID.Visible = false;
            // 
            // dgvCourseID
            // 
            this.dgvCourseID.DataPropertyName = "CourseID";
            this.dgvCourseID.HeaderText = "CourseID";
            this.dgvCourseID.Name = "dgvCourseID";
            this.dgvCourseID.ReadOnly = true;
            this.dgvCourseID.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(474, 509);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 53);
            this.btnSave.TabIndex = 13;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 568);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbAddQuestion);
            this.Controls.Add(this.grbShowQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Question";
            this.Load += new System.EventHandler(this.frmAddQuestion_Load);
            this.grbAddQuestion.ResumeLayout(false);
            this.grbAddQuestion.PerformLayout();
            this.grbShowQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeeQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddQuestion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbShowQuestion;
        private System.Windows.Forms.DataGridView dgvSeeQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCourseID;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Button btnSave;
    }
}