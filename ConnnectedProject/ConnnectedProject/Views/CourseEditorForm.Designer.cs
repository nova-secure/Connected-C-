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
            checkBoxPublie = new CheckBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Créer un nouveau cours";
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Location = new Point(24, 74);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(39, 20);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Titre";
            // 
            // txtTitre
            // 
            txtTitre.Location = new Point(24, 97);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(530, 27);
            txtTitre.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(24, 141);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(24, 164);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(530, 190);
            txtDescription.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 120, 215);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(24, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 35);
            btnSave.TabIndex = 5;
            btnSave.Text = "Sauvegarder";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // checkBoxPublie
            // 
            checkBoxPublie.AutoSize = true;
            checkBoxPublie.Location = new Point(237, 380);
            checkBoxPublie.Name = "checkBoxPublie";
            checkBoxPublie.Size = new Size(77, 24);
            checkBoxPublie.TabIndex = 6;
            checkBoxPublie.Text = "Publier";
            checkBoxPublie.UseVisualStyleBackColor = true;
            // 
            // CourseEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 431);
            Controls.Add(checkBoxPublie);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtTitre);
            Controls.Add(lblTitre);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CourseEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Éditeur de cours";
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckBox checkBoxPublie;
    }
}
