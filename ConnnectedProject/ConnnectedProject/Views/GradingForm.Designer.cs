namespace ConnnectedProject.Views
{
    partial class GradingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.NumericUpDown numNote;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblStudent = new Label();
            cmbStudents = new ComboBox();
            lblCourse = new Label();
            cmbCourses = new ComboBox();
            lblNote = new Label();
            numNote = new NumericUpDown();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numNote).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(254, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Noter un étudiant";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(30, 100);
            lblStudent.Margin = new Padding(4, 0, 4, 0);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(77, 25);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Étudiant";
            // 
            // cmbStudents
            // 
            cmbStudents.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(30, 129);
            cmbStudents.Margin = new Padding(4, 4, 4, 4);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(662, 33);
            cmbStudents.TabIndex = 2;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(30, 188);
            lblCourse.Margin = new Padding(4, 0, 4, 0);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(58, 25);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Cours";
            // 
            // cmbCourses
            // 
            cmbCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(30, 216);
            cmbCourses.Margin = new Padding(4, 4, 4, 4);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(662, 33);
            cmbCourses.TabIndex = 4;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(30, 275);
            lblNote.Margin = new Padding(4, 0, 4, 0);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(51, 25);
            lblNote.TabIndex = 5;
            lblNote.Text = "Note";
            // 
            // numNote
            // 
            numNote.DecimalPlaces = 1;
            numNote.Location = new Point(30, 304);
            numNote.Margin = new Padding(4, 4, 4, 4);
            numNote.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numNote.Name = "numNote";
            numNote.Size = new Size(150, 31);
            numNote.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 120, 215);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 366);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 44);
            btnSave.TabIndex = 7;
            btnSave.Text = "Sauvegarder";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // GradingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 439);
            Controls.Add(btnSave);
            Controls.Add(numNote);
            Controls.Add(lblNote);
            Controls.Add(cmbCourses);
            Controls.Add(lblCourse);
            Controls.Add(cmbStudents);
            Controls.Add(lblStudent);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GradingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Noter un étudiant";
            Load += GradingForm_Load;
            ((System.ComponentModel.ISupportInitialize)numNote).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
