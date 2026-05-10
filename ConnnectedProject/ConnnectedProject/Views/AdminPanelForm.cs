using ConnnectedProject.Controllers;
using ConnnectedProject.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConnnectedProject.Views
{
    public class UserDisplayDto
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string SchoolClass { get; set; }
    }

    public class AdminPanelForm : Form
    {
        private readonly AdminController adminController;
        private DataGridView dgvUsers = null!;
        private Button btnRefresh = null!;
        private Button btnAddUser = null!;
        private Button btnUpdateUser = null!;
        private Button btnDeleteUser = null!;
        private TextBox txtLastName = null!;
        private TextBox txtFirstName = null!;
        private TextBox txtEmail = null!;
        private TextBox txtPassword = null!;
        private ComboBox cboSchoolClass = null!;
        private ComboBox cboRole = null!;
        private Label lblHeader = null!;
        private Label lblLastName = null!;
        private Label lblFirstName = null!;
        private Label lblEmail = null!;
        private Label lblPassword = null!;
        private Label lblRole = null!;
        private Label lblSchoolClass = null!;
        
        private Label lblStats = null!;
        private int selectedUserId = -1;

        public AdminPanelForm()
        {
            adminController = new AdminController();
            InitializeComponent();
            RefreshList();
        }

        private void InitializeComponent()
        {
            dgvUsers = new DataGridView();
            btnRefresh = new Button();
            btnAddUser = new Button();
            btnUpdateUser = new Button();
            btnDeleteUser = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cboSchoolClass = new ComboBox();
            cboRole = new ComboBox();
            lblHeader = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            lblSchoolClass = new Label();

            
            lblStats = new Label();

            SuspendLayout();
            
            
            
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(24, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(218, 37);
            lblHeader.Text = "Panneau Admin";
            
            
            
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblStats.Location = new Point(300, 25);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(200, 25);
            lblStats.Text = "Statistiques chargement...";
            
            
            
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(24, 70);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(740, 420);
            dgvUsers.SelectionChanged += DgvUsers_SelectionChanged;
            dgvUsers.CellClick += DgvUsers_CellClick;
            
            
            
            btnRefresh.Location = new Point(24, 510);
            btnRefresh.Name = "btnActualiser";
            btnRefresh.Size = new Size(120, 30);
            btnRefresh.Text = "Actualiser";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnActualiser_Click;
            
            
            
            btnDeleteUser.Location = new Point(154, 510);
            btnDeleteUser.Name = "btnSupprimerUtilisateur";
            btnDeleteUser.Size = new Size(170, 30);
            btnDeleteUser.Text = "Supprimer utilisateur";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += BtnSupprimerUtilisateur_Click;
            
            
            
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(788, 80);
            lblLastName.Name = "lblNom";
            lblLastName.Size = new Size(41, 20);
            lblLastName.Text = "Nom :";
            
            
            
            txtLastName.Location = new Point(788, 104);
            txtLastName.Name = "txtNom";
            txtLastName.Size = new Size(220, 27);
            
            
            
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(788, 145);
            lblFirstName.Name = "lblPrenom";
            lblFirstName.Size = new Size(65, 20);
            lblFirstName.Text = "Prénom :";
            
            
            
            txtFirstName.Location = new Point(788, 168);
            txtFirstName.Name = "txtPrenom";
            txtFirstName.Size = new Size(220, 27);
            
            
            
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(788, 209);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 20);
            lblEmail.Text = "Email :";
            
            
            
            txtEmail.Location = new Point(788, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 27);
            
            
            
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(788, 273);
            lblPassword.Name = "lblMdp";
            lblPassword.Size = new Size(123, 20);
            lblPassword.Text = "Mot de passe :";
            
            
            
            txtPassword.Location = new Point(788, 296);
            txtPassword.Name = "txtMdp";
            txtPassword.Size = new Size(220, 27);
            txtPassword.UseSystemPasswordChar = true;
            
            
            
            lblRole.AutoSize = true;
            lblRole.Location = new Point(788, 335);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(41, 20);
            lblRole.Text = "Rôle :";
            
            
            
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.Items.AddRange(new object[] { "Admin", "Professeur", "Etudiant" });
            cboRole.Location = new Point(788, 358);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(220, 28);
            cboRole.SelectedIndexChanged += CboRole_SelectedIndexChanged;
            cboRole.SelectedIndex = 0;
            
            
            
            lblSchoolClass.AutoSize = true;
            lblSchoolClass.Location = new Point(788, 395);
            lblSchoolClass.Name = "lblClasse";
            lblSchoolClass.Size = new Size(52, 20);
            lblSchoolClass.Text = "Classe :";
            
            
            
            cboSchoolClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSchoolClass.Location = new Point(788, 418);
            cboSchoolClass.Name = "cboClasse";
            cboSchoolClass.Size = new Size(220, 27);
            cboSchoolClass.Enabled = false;
            
            
            
            btnAddUser.Location = new Point(788, 455);
            btnAddUser.Name = "btnAjouterUtilisateur";
            btnAddUser.Size = new Size(220, 30);
            btnAddUser.Text = "Créer utilisateur";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += BtnAjouterUtilisateur_Click;
            
            
            
            btnUpdateUser.Location = new Point(788, 495);
            btnUpdateUser.Name = "btnModifierUtilisateur";
            btnUpdateUser.Size = new Size(220, 30);
            btnUpdateUser.Text = "Modifier utilisateur";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += BtnModifierUtilisateur_Click;
            
            
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 540);
            Controls.Add(lblHeader);
            
            Controls.Add(lblStats);
            Controls.Add(dgvUsers);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteUser);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(cboRole);
            Controls.Add(lblSchoolClass);
            Controls.Add(cboSchoolClass);
            Controls.Add(btnAddUser);
            Controls.Add(btnUpdateUser);
            Name = "PanelController";
            Text = "Panneau Admin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private void RefreshList()
        {
            //linq recupere tous les  users et les map en obj anonyme pour la grille data grid, parcequ'il y a trop d'infos inutiles sinon
            System.Collections.Generic.List<UserDisplayDto> users = adminController.GetAllUsers()
                .Select(u => new UserDisplayDto
                {
                    Id = u.Id,
                    LastName = u.LastName,
                    FirstName = u.FirstName,
                    Email = u.Email,
                    Role = GetFrenchRoleName(u.Role),
                    SchoolClass = u is Student student ? student.SchoolClass : string.Empty
                })
                .ToList();

            dgvUsers.DataSource = users;
            PopulateClassList();

            
            int studentCount = adminController.CountStudents();
            lblStats.Text = "Nombre total d'étudiants : " + studentCount;
        }

        private void BtnActualiser_Click(object? sender, EventArgs e)
        {
            RefreshList();
        }

        private void BtnAjouterUtilisateur_Click(object? sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string role = GetEnglishRoleName(cboRole.SelectedItem?.ToString());
            string schoolClass = cboSchoolClass.SelectedItem?.ToString() ?? string.Empty;

            User? user = adminController.CreateUser(lastName, firstName, email, pwd, role, schoolClass);
            if (user == null)
            {
                MessageBox.Show("Impossible de créer l'utilisateur. Vérifiez les informations, le rôle ou l'email existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Utilisateur {user.LastName} {user.FirstName} créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            RefreshList();
        }

        private void BtnModifierUtilisateur_Click(object? sender, EventArgs e)
        {
            if (selectedUserId < 0)
            {
                MessageBox.Show("Sélectionnez un utilisateur à modifier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string email = txtEmail.Text;
            string pwd = txtPassword.Text;
            string role = GetEnglishRoleName(cboRole.SelectedItem?.ToString());
            string schoolClass = cboSchoolClass.SelectedItem?.ToString() ?? string.Empty;

            if (adminController.UpdateUser(selectedUserId, lastName, firstName, email, pwd, role, schoolClass))
            {
                MessageBox.Show("Utilisateur modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshList();
                selectedUserId = -1;
            }
            else
            {
                MessageBox.Show("Impossible de modifier l'utilisateur. Vérifiez les informations et l'email.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSupprimerUtilisateur_Click(object? sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez un utilisateur à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value is int id)
            {
                if (adminController.DeleteUser(id))
                {
                    MessageBox.Show("Utilisateur supprimé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    RefreshList();
                }
                else
                {
                    MessageBox.Show("Impossible de supprimer cet utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DgvUsers_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value is int id)
            {
                LoadSelectedUser(id);
            }
        }

        private void DgvUsers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvUsers.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
            if (row.Cells["Id"].Value is int id)
            {
                LoadSelectedUser(id);
            }
        }

        private void LoadSelectedUser(int id)
        {
            User? user = adminController.GetUser(id);
            if (user == null)
                return;

            selectedUserId = id;
            txtLastName.Text = user.LastName;
            txtFirstName.Text = user.FirstName;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            cboRole.SelectedItem = GetFrenchRoleName(user.Role);

            if (user is Student student)
            {
                cboSchoolClass.SelectedItem = student.SchoolClass;
                cboSchoolClass.Enabled = true;
            }
            else
            {
                cboSchoolClass.SelectedItem = null;
                cboSchoolClass.Enabled = false;
            }
        }

        private void PopulateClassList()
        {
            System.Collections.Generic.List<string> classes = adminController.GetStudents()
                .Select(s => s.SchoolClass?.Trim())
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(c => c)
                .ToList();

            cboSchoolClass.Items.Clear();
            foreach (string schoolClass in classes)
            {
                cboSchoolClass.Items.Add(schoolClass!);
            }

            if (cboSchoolClass.Items.Count > 0 && cboSchoolClass.SelectedItem == null)
            {
                cboSchoolClass.SelectedIndex = 0;
            }
        }

        private void CboRole_SelectedIndexChanged(object? sender, EventArgs e)
        {
            cboSchoolClass.Enabled = cboRole.SelectedItem?.ToString() == "Etudiant";
            if (!cboSchoolClass.Enabled)
            {
                cboSchoolClass.SelectedItem = null;
            }
        }

        private void ClearFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cboSchoolClass.SelectedItem = null;
            cboRole.SelectedIndex = 0;
            cboSchoolClass.Enabled = false;
            selectedUserId = -1;
        }

        private string GetEnglishRoleName(string? role)
        {
            return role switch
            {
                "Professeur" => "Professor",
                "Etudiant" => "Student",
                _ => "Admin",
            };
        }

        private string GetFrenchRoleName(string role)
        {
            return role switch
            {
                "Professor" => "Professeur",
                "Student" => "Etudiant",
                _ => "Admin",
            };
        }
    }
}
