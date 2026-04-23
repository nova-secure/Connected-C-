namespace ConnnectedProject.Views
{
    partial class CourseEditorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
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
            lblTitre = new Label();
            txtTitre = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 25);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(327, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Créer un nouveau cours";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Location = new Point(30, 92);
            lblTitre.Margin = new Padding(4, 0, 4, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(46, 25);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Titre";
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(30, 121);
            txtTitre.Margin = new Padding(4, 4, 4, 4);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(662, 31);
            txtTitre.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(30, 176);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(30, 205);
            txtDescription.Margin = new Padding(4, 4, 4, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(662, 236);
            txtDescription.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 120, 215);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(30, 468);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 44);
            btnSave.TabIndex = 5;
            btnSave.Text = "Sauvegarder";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // CourseEditorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 539);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtTitre);
            Controls.Add(lblTitre);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CourseEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Éditeur de cours";
           // Load += this.CourseEditorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
