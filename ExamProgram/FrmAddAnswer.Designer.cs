namespace ExamProgram
{
    partial class FrmAddAnswer
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
            this.grbAddAnswer = new System.Windows.Forms.GroupBox();
            this.cmdSelectQue = new System.Windows.Forms.ComboBox();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTrueOrFalse = new System.Windows.Forms.Label();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbShowAnswer = new System.Windows.Forms.GroupBox();
            this.dgvAnswer = new System.Windows.Forms.DataGridView();
            this.DvgAnswerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DvgAnswerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DvgisCorrect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DvgQuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAddAnswer.SuspendLayout();
            this.grbShowAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAddAnswer
            // 
            this.grbAddAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbAddAnswer.Controls.Add(this.cmdSelectQue);
            this.grbAddAnswer.Controls.Add(this.cmbCourseName);
            this.grbAddAnswer.Controls.Add(this.label3);
            this.grbAddAnswer.Controls.Add(this.lblTrueOrFalse);
            this.grbAddAnswer.Controls.Add(this.rdoFalse);
            this.grbAddAnswer.Controls.Add(this.rdoTrue);
            this.grbAddAnswer.Controls.Add(this.btnCancel);
            this.grbAddAnswer.Controls.Add(this.btnSave);
            this.grbAddAnswer.Controls.Add(this.txtAnswer);
            this.grbAddAnswer.Controls.Add(this.label2);
            this.grbAddAnswer.Controls.Add(this.label1);
            this.grbAddAnswer.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold);
            this.grbAddAnswer.Location = new System.Drawing.Point(25, 28);
            this.grbAddAnswer.Name = "grbAddAnswer";
            this.grbAddAnswer.Size = new System.Drawing.Size(625, 211);
            this.grbAddAnswer.TabIndex = 11;
            this.grbAddAnswer.TabStop = false;
            this.grbAddAnswer.Text = "Add Question";
            // 
            // cmdSelectQue
            // 
            this.cmdSelectQue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdSelectQue.FormattingEnabled = true;
            this.cmdSelectQue.Location = new System.Drawing.Point(133, 62);
            this.cmdSelectQue.Name = "cmdSelectQue";
            this.cmdSelectQue.Size = new System.Drawing.Size(420, 26);
            this.cmdSelectQue.TabIndex = 19;
            this.cmdSelectQue.SelectedIndexChanged += new System.EventHandler(this.cmdSelectQue_SelectedIndexChanged);
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(133, 25);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(420, 26);
            this.cmbCourseName.TabIndex = 18;
            this.cmbCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbCourseName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Course Name";
            // 
            // lblTrueOrFalse
            // 
            this.lblTrueOrFalse.AutoSize = true;
            this.lblTrueOrFalse.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrueOrFalse.Location = new System.Drawing.Point(270, 169);
            this.lblTrueOrFalse.Name = "lblTrueOrFalse";
            this.lblTrueOrFalse.Size = new System.Drawing.Size(16, 18);
            this.lblTrueOrFalse.TabIndex = 16;
            this.lblTrueOrFalse.Text = "*";
            this.lblTrueOrFalse.Visible = false;
            // 
            // rdoFalse
            // 
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Location = new System.Drawing.Point(207, 167);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(57, 22);
            this.rdoFalse.TabIndex = 15;
            this.rdoFalse.TabStop = true;
            this.rdoFalse.Text = "False";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Location = new System.Drawing.Point(133, 167);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(59, 22);
            this.rdoTrue.TabIndex = 14;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "True";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(519, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(435, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(133, 99);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(420, 26);
            this.txtAnswer.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Question";
            // 
            // grbShowAnswer
            // 
            this.grbShowAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbShowAnswer.Controls.Add(this.dgvAnswer);
            this.grbShowAnswer.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbShowAnswer.Location = new System.Drawing.Point(25, 260);
            this.grbShowAnswer.Name = "grbShowAnswer";
            this.grbShowAnswer.Size = new System.Drawing.Size(625, 252);
            this.grbShowAnswer.TabIndex = 10;
            this.grbShowAnswer.TabStop = false;
            this.grbShowAnswer.Text = "See Answers";
            // 
            // dgvAnswer
            // 
            this.dgvAnswer.AllowUserToAddRows = false;
            this.dgvAnswer.AllowUserToDeleteRows = false;
            this.dgvAnswer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnswer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DvgAnswerID,
            this.DgvCourseID,
            this.DvgAnswerName,
            this.DvgisCorrect,
            this.DvgQuestionID});
            this.dgvAnswer.Location = new System.Drawing.Point(6, 25);
            this.dgvAnswer.Name = "dgvAnswer";
            this.dgvAnswer.ReadOnly = true;
            this.dgvAnswer.Size = new System.Drawing.Size(613, 221);
            this.dgvAnswer.TabIndex = 0;
            // 
            // DvgAnswerID
            // 
            this.DvgAnswerID.DataPropertyName = "AnswerID";
            this.DvgAnswerID.HeaderText = "AnswerID";
            this.DvgAnswerID.Name = "DvgAnswerID";
            this.DvgAnswerID.ReadOnly = true;
            this.DvgAnswerID.Visible = false;
            // 
            // DgvCourseID
            // 
            this.DgvCourseID.DataPropertyName = "COurseid";
            this.DgvCourseID.HeaderText = "Course ID";
            this.DgvCourseID.Name = "DgvCourseID";
            this.DgvCourseID.ReadOnly = true;
            this.DgvCourseID.Visible = false;
            // 
            // DvgAnswerName
            // 
            this.DvgAnswerName.DataPropertyName = "AnswerName";
            this.DvgAnswerName.HeaderText = "Answer";
            this.DvgAnswerName.Name = "DvgAnswerName";
            this.DvgAnswerName.ReadOnly = true;
            // 
            // DvgisCorrect
            // 
            this.DvgisCorrect.DataPropertyName = "isCorrect";
            this.DvgisCorrect.HeaderText = "Corrert Or Not";
            this.DvgisCorrect.Name = "DvgisCorrect";
            this.DvgisCorrect.ReadOnly = true;
            // 
            // DvgQuestionID
            // 
            this.DvgQuestionID.DataPropertyName = "QuestionID";
            this.DvgQuestionID.HeaderText = "Question ID";
            this.DvgQuestionID.Name = "DvgQuestionID";
            this.DvgQuestionID.ReadOnly = true;
            this.DvgQuestionID.Visible = false;
            // 
            // FrmAddAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 545);
            this.Controls.Add(this.grbAddAnswer);
            this.Controls.Add(this.grbShowAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAddAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Answer";
            this.Load += new System.EventHandler(this.FrmAddAnswer_Load);
            this.grbAddAnswer.ResumeLayout(false);
            this.grbAddAnswer.PerformLayout();
            this.grbShowAnswer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddAnswer;
        private System.Windows.Forms.Label lblTrueOrFalse;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.RadioButton rdoTrue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbShowAnswer;
        private System.Windows.Forms.DataGridView dgvAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DvgAnswerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DvgAnswerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DvgisCorrect;
        private System.Windows.Forms.DataGridViewTextBoxColumn DvgQuestionID;
        private System.Windows.Forms.ComboBox cmdSelectQue;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Label label3;
    }
}