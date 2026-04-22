namespace ConnnectedProject.Views
{
    partial class LoginForm
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
            txtEmail = new TextBox();
            txtMdp = new TextBox();
            btnConnection = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(376, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 27);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "Exemple@Exemple.com";
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtMdp
            // 
            txtMdp.ForeColor = Color.LightGray;
            txtMdp.Location = new Point(376, 328);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(213, 27);
            txtMdp.TabIndex = 1;
            txtMdp.Tag = "";
            txtMdp.Text = "Password";
            txtMdp.UseSystemPasswordChar = true;
            // 
            // btnConnection
            // 
            btnConnection.Location = new Point(421, 404);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(135, 29);
            btnConnection.TabIndex = 2;
            btnConnection.Text = "Se Connecter";
            btnConnection.UseVisualStyleBackColor = true;
            btnConnection.Click += btnConnection_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 725);
            Controls.Add(btnConnection);
            Controls.Add(txtMdp);
            Controls.Add(txtEmail);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtMdp;
        private Button btnConnection;
    }
}