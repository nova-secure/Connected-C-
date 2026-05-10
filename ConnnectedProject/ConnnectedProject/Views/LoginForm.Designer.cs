namespace ConnnectedProject.Views
{
    partial class LoginForm
    {
        
        
        
        private System.ComponentModel.IContainer components = null;

        
        
        
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        
        
        
        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnConnection = new Button();
            SuspendLayout();
            
            
            
            txtEmail.Location = new Point(376, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 27);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "Exemple@Exemple.com";
            txtEmail.TextChanged += txtEmail_TextChanged;
            
            
            
            txtPassword.ForeColor = Color.LightGray;
            txtPassword.Location = new Point(376, 328);
            txtPassword.Name = "txtMdp";
            txtPassword.Size = new Size(213, 27);
            txtPassword.TabIndex = 1;
            txtPassword.Tag = "";
            txtPassword.Text = "Password";
            txtPassword.UseSystemPasswordChar = true;
            
            
            
            btnConnection.Location = new Point(421, 404);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(135, 29);
            btnConnection.TabIndex = 2;
            btnConnection.Text = "Se Connecter";
            btnConnection.UseVisualStyleBackColor = true;
            btnConnection.Click += btnConnection_Click;
            
            
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 725);
            Controls.Add(btnConnection);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnConnection;
    }
}