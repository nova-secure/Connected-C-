namespace ConnnectedProject.Views
{
    partial class CourseCatalogForm
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
            listBox1 = new ListBox();
            label2 = new Label();
            labelCours = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Math", "Programmation C#", "Programmation Web (Client)", "Électricité", "Arduino", "CAO" });
            listBox1.Location = new Point(12, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(271, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 79);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Description :";
            label2.Click += label2_Click;
            // 
            // labelCours
            // 
            labelCours.AutoSize = true;
            labelCours.Location = new Point(339, 125);
            labelCours.Name = "labelCours";
            labelCours.Size = new Size(0, 20);
            labelCours.TabIndex = 3;
            labelCours.Tag = "";
            labelCours.Click += labelCours_Click;
            // 
            // CourseCatalogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCours);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Name = "CourseCatalogForm";
            Text = "CourseCatalogForm";
            Load += CourseCatalogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label2;
        private Label labelCours;
    }
}