namespace ConnnectedProject.Views
{
    partial class ProfessorDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnGradeStudent;
        private System.Windows.Forms.Button btnRefresh;

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
            lblTitle = new System.Windows.Forms.Label();
            dgvCourses = new System.Windows.Forms.DataGridView();
            btnAddCourse = new System.Windows.Forms.Button();
            btnGradeStudent = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(211, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mes cours publiés";
            // 
            // dgvCourses
            // 
            dgvCourses.AllowUserToAddRows = false;
            dgvCourses.AllowUserToDeleteRows = false;
            dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new System.Drawing.Point(24, 65);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersVisible = false;
            dgvCourses.RowTemplate.Height = 29;
            dgvCourses.Size = new System.Drawing.Size(772, 340);
            dgvCourses.TabIndex = 1;
            // 
            // btnAddCourse
            // 
            btnAddCourse.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddCourse.ForeColor = System.Drawing.Color.White;
            btnAddCourse.Location = new System.Drawing.Point(24, 425);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new System.Drawing.Size(180, 500);
            btnAddCourse.TabIndex = 2;
            btnAddCourse.Text = "Créer un cours";
            btnAddCourse.UseVisualStyleBackColor = false;
            btnAddCourse.Click += BtnAddCourse_Click;
            // 
            // btnGradeStudent
            // 
            btnGradeStudent.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnGradeStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGradeStudent.ForeColor = System.Drawing.Color.White;
            btnGradeStudent.Location = new System.Drawing.Point(224, 425);
            btnGradeStudent.Name = "btnGradeStudent";
            btnGradeStudent.Size = new System.Drawing.Size(180, 35);
            btnGradeStudent.TabIndex = 3;
            btnGradeStudent.Text = "Noter un étudiant";
            btnGradeStudent.UseVisualStyleBackColor = false;
            btnGradeStudent.Click += BtnGradeStudent_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.Location = new System.Drawing.Point(642, 425);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(154, 35);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Actualiser";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // ProfessorDashboardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(820, 480);
            Controls.Add(btnRefresh);
            Controls.Add(btnGradeStudent);
            Controls.Add(btnAddCourse);
            Controls.Add(dgvCourses);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProfessorDashboardForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Espace Professeur";
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

