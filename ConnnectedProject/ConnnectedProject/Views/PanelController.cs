using ConnnectedProject.Controllers;
using ConnnectedProject.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConnnectedProject.Views
{
    public class PanelController : Form
    {
        private readonly AdminController adminController;
        private DataGridView dgvUsers = null!;
        private Button btnActualiser = null!;
        private Button btnAjouterUtilisateur = null!;
        private Button btnModifierUtilisateur = null!;
        private Button btnSupprimerUtilisateur = null!;
        private TextBox txtNom = null!;
        private TextBox txtPrenom = null!;
        private TextBox txtEmail = null!;
        private TextBox txtMdp = null!;
        private ComboBox cboClasse = null!;
        private ComboBox cboRole = null!;
        private Label lblHeader = null!;
        private Label lblNom = null!;
        private Label lblPrenom = null!;
        private Label lblEmail = null!;
        private Label lblMdp = null!;
        private Label lblRole = null!;
        private Label lblClasse = null!;
        //j'ai ajuter 1 labl pr aiché le  nbr detudiant
        private Label lblStats = null!;
        private int selectedUserId = -1;

        public PanelController()
        {
            adminController = new AdminController();
            InitializeComponent();
            ActualiserListe();
        }

        private void InitializeComponent()
        {
            dgvUsers = new DataGridView();
            btnActualiser = new Button();
            btnAjouterUtilisateur = new Button();
            btnModifierUtilisateur = new Button();
            btnSupprimerUtilisateur = new Button();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtEmail = new TextBox();
            txtMdp = new TextBox();
            cboClasse = new ComboBox();
            cboRole = new ComboBox();
            lblHeader = new Label();
            lblNom = new Label();
            lblPrenom = new Label();
            lblEmail = new Label();
            lblMdp = new Label();
            lblRole = new Label();
            lblClasse = new Label();

            //jinitializ le label pr  montré l  nbr d'eleves
            lblStats = new Label();

            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(24, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(218, 37);
            lblHeader.Text = "Panneau Admin";
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblStats.Location = new Point(300, 25);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(200, 25);
            lblStats.Text = "Statistiques chargement...";
            // 
            // dgvUsers
            // 
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
            // 
            // btnActualiser
            // 
            btnActualiser.Location = new Point(24, 510);
            btnActualiser.Name = "btnActualiser";
            btnActualiser.Size = new Size(120, 30);
            btnActualiser.Text = "Actualiser";
            btnActualiser.UseVisualStyleBackColor = true;
            btnActualiser.Click += BtnActualiser_Click;
            // 
            // btnSupprimerUtilisateur
            // 
            btnSupprimerUtilisateur.Location = new Point(154, 510);
            btnSupprimerUtilisateur.Name = "btnSupprimerUtilisateur";
            btnSupprimerUtilisateur.Size = new Size(170, 30);
            btnSupprimerUtilisateur.Text = "Supprimer utilisateur";
            btnSupprimerUtilisateur.UseVisualStyleBackColor = true;
            btnSupprimerUtilisateur.Click += BtnSupprimerUtilisateur_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(788, 80);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(41, 20);
            lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(788, 104);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(220, 27);
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(788, 145);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(65, 20);
            lblPrenom.Text = "Prénom :";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(788, 168);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(220, 27);
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(788, 209);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 20);
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(788, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 27);
            // 
            // lblMdp
            // 
            lblMdp.AutoSize = true;
            lblMdp.Location = new Point(788, 273);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new Size(123, 20);
            lblMdp.Text = "Mot de passe :";
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(788, 296);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(220, 27);
            txtMdp.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(788, 335);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(41, 20);
            lblRole.Text = "Rôle :";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.Items.AddRange(new object[] { "Admin", "Professeur", "Etudiant" });
            cboRole.Location = new Point(788, 358);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(220, 28);
            cboRole.SelectedIndexChanged += CboRole_SelectedIndexChanged;
            cboRole.SelectedIndex = 0;
            // 
            // lblClasse
            // 
            lblClasse.AutoSize = true;
            lblClasse.Location = new Point(788, 395);
            lblClasse.Name = "lblClasse";
            lblClasse.Size = new Size(52, 20);
            lblClasse.Text = "Classe :";
            // 
            // cboClasse
            // 
            cboClasse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClasse.Location = new Point(788, 418);
            cboClasse.Name = "cboClasse";
            cboClasse.Size = new Size(220, 27);
            cboClasse.Enabled = false;
            // 
            // btnAjouterUtilisateur
            // 
            btnAjouterUtilisateur.Location = new Point(788, 455);
            btnAjouterUtilisateur.Name = "btnAjouterUtilisateur";
            btnAjouterUtilisateur.Size = new Size(220, 30);
            btnAjouterUtilisateur.Text = "Créer utilisateur";
            btnAjouterUtilisateur.UseVisualStyleBackColor = true;
            btnAjouterUtilisateur.Click += BtnAjouterUtilisateur_Click;
            // 
            // btnModifierUtilisateur
            // 
            btnModifierUtilisateur.Location = new Point(788, 495);
            btnModifierUtilisateur.Name = "btnModifierUtilisateur";
            btnModifierUtilisateur.Size = new Size(220, 30);
            btnModifierUtilisateur.Text = "Modifier utilisateur";
            btnModifierUtilisateur.UseVisualStyleBackColor = true;
            btnModifierUtilisateur.Click += BtnModifierUtilisateur_Click;
            // 
            // PanelController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 540);
            Controls.Add(lblHeader);
            //j'ajout l  labl a la fenetr
            Controls.Add(lblStats);
            Controls.Add(dgvUsers);
            Controls.Add(btnActualiser);
            Controls.Add(btnSupprimerUtilisateur);
            Controls.Add(lblNom);
            Controls.Add(txtNom);
            Controls.Add(lblPrenom);
            Controls.Add(txtPrenom);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblMdp);
            Controls.Add(txtMdp);
            Controls.Add(lblRole);
            Controls.Add(cboRole);
            Controls.Add(lblClasse);
            Controls.Add(cboClasse);
            Controls.Add(btnAjouterUtilisateur);
            Controls.Add(btnModifierUtilisateur);
            Name = "PanelController";
            Text = "Panneau Admin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private void ActualiserListe()
        {
            var utilisateurs = adminController.AfficherTousLesUtilisateurs()
                .Select(u => new
                {
                    u.Id,
                    u.Nom,
                    u.Prenom,
                    u.Email,
                    Role = ConvertRoleToFrench(u.Role),
                    Classe = u is Student student ? student.Classe : string.Empty
                })
                .ToList();

            dgvUsers.DataSource = utilisateurs;
            PopulateClasseListe();

            //je mis a  jour le  texte avc le nbr actuel d etudiant
            int nbEtudiant = adminController.CompterEtudiants();
            lblStats.Text = "Nombre total d'étudiants : " + nbEtudiant;
        }

        private void BtnActualiser_Click(object? sender, EventArgs e)
        {
            ActualiserListe();
        }

        private void BtnAjouterUtilisateur_Click(object? sender, EventArgs e)
        {
            var nom = txtNom.Text;
            var prenom = txtPrenom.Text;
            var email = txtEmail.Text;
            var mdp = txtMdp.Text;
            var role = GetInternalRole(cboRole.SelectedItem?.ToString());
            var classe = cboClasse.SelectedItem?.ToString() ?? string.Empty;

            var utilisateur = adminController.CreerUtilisateur(nom, prenom, email, mdp, role, classe);
            if (utilisateur == null)
            {
                MessageBox.Show("Impossible de créer l'utilisateur. Vérifiez les informations, le rôle ou l'email existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Utilisateur {utilisateur.Nom} {utilisateur.Prenom} créé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ViderChamps();
            ActualiserListe();
        }

        private void BtnModifierUtilisateur_Click(object? sender, EventArgs e)
        {
            if (selectedUserId < 0)
            {
                MessageBox.Show("Sélectionnez un utilisateur à modifier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var nom = txtNom.Text;
            var prenom = txtPrenom.Text;
            var email = txtEmail.Text;
            var mdp = txtMdp.Text;
            var role = GetInternalRole(cboRole.SelectedItem?.ToString());
            var classe = cboClasse.SelectedItem?.ToString() ?? string.Empty;

            if (adminController.ModifierUtilisateur(selectedUserId, nom, prenom, email, mdp, role, classe))
            {
                MessageBox.Show("Utilisateur modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViderChamps();
                ActualiserListe();
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

            var selectedRow = dgvUsers.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value is int id)
            {
                if (adminController.SupprimerUtilisateur(id))
                {
                    MessageBox.Show("Utilisateur supprimé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViderChamps();
                    ActualiserListe();
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

            var selectedRow = dgvUsers.SelectedRows[0];
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

            var row = dgvUsers.Rows[e.RowIndex];
            if (row.Cells["Id"].Value is int id)
            {
                LoadSelectedUser(id);
            }
        }

        private void LoadSelectedUser(int id)
        {
            var utilisateur = adminController.ObtenirUtilisateur(id);
            if (utilisateur == null)
                return;

            selectedUserId = id;
            txtNom.Text = utilisateur.Nom;
            txtPrenom.Text = utilisateur.Prenom;
            txtEmail.Text = utilisateur.Email;
            txtMdp.Text = utilisateur.MotDePasse;
            cboRole.SelectedItem = ConvertRoleToFrench(utilisateur.Role);

            if (utilisateur is Student student)
            {
                cboClasse.SelectedItem = student.Classe;
                cboClasse.Enabled = true;
            }
            else
            {
                cboClasse.SelectedItem = null;
                cboClasse.Enabled = false;
            }
        }

        private void PopulateClasseListe()
        {
            var classes = DataStore.Users.OfType<Student>()
                .Select(s => s.Classe?.Trim())
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(c => c)
                .ToList();

            cboClasse.Items.Clear();
            foreach (var classe in classes)
            {
                cboClasse.Items.Add(classe!);
            }

            if (cboClasse.Items.Count > 0 && cboClasse.SelectedItem == null)
            {
                cboClasse.SelectedIndex = 0;
            }
        }

        private void CboRole_SelectedIndexChanged(object? sender, EventArgs e)
        {
            cboClasse.Enabled = cboRole.SelectedItem?.ToString() == "Etudiant";
            if (!cboClasse.Enabled)
            {
                cboClasse.SelectedItem = null;
            }
        }

        private void ViderChamps()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtEmail.Clear();
            txtMdp.Clear();
            cboClasse.SelectedItem = null;
            cboRole.SelectedIndex = 0;
            cboClasse.Enabled = false;
            selectedUserId = -1;
        }

        private string GetInternalRole(string? role)
        {
            return role switch
            {
                "Professeur" => "Professor",
                "Etudiant" => "Student",
                _ => "Admin",
            };
        }

        private string ConvertRoleToFrench(string role)
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
