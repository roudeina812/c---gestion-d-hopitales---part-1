
namespace projet_csharp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxForm3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeCNAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomConjoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomConjoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbEnfant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule ";
            // 
            // textBoxForm3
            // 
            this.textBoxForm3.Location = new System.Drawing.Point(210, 56);
            this.textBoxForm3.Name = "textBoxForm3";
            this.textBoxForm3.Size = new System.Drawing.Size(191, 22);
            this.textBoxForm3.TabIndex = 1;
            this.textBoxForm3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(770, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Modifier.Location = new System.Drawing.Point(540, 22);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(186, 56);
            this.Modifier.TabIndex = 3;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(63, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(304, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 56);
            this.button4.TabIndex = 5;
            this.button4.Text = "consulter";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.prenom,
            this.matricule,
            this.cin,
            this.dateNais,
            this.adresse,
            this.grade,
            this.numTel,
            this.codeCNAM,
            this.etatCivil,
            this.nomConjoint,
            this.prenomConjoint,
            this.nbEnfant});
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(977, 164);
            this.dataGridView1.TabIndex = 6;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 125;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.Width = 125;
            // 
            // matricule
            // 
            this.matricule.HeaderText = "matricule";
            this.matricule.MinimumWidth = 6;
            this.matricule.Name = "matricule";
            this.matricule.Width = 125;
            // 
            // cin
            // 
            this.cin.HeaderText = "cin";
            this.cin.MinimumWidth = 6;
            this.cin.Name = "cin";
            this.cin.Width = 125;
            // 
            // dateNais
            // 
            this.dateNais.HeaderText = "dateNais";
            this.dateNais.MinimumWidth = 6;
            this.dateNais.Name = "dateNais";
            this.dateNais.Width = 125;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "adresse";
            this.adresse.MinimumWidth = 6;
            this.adresse.Name = "adresse";
            this.adresse.Width = 125;
            // 
            // grade
            // 
            this.grade.HeaderText = "grade";
            this.grade.MinimumWidth = 6;
            this.grade.Name = "grade";
            this.grade.Width = 125;
            // 
            // numTel
            // 
            this.numTel.HeaderText = "numTel";
            this.numTel.MinimumWidth = 6;
            this.numTel.Name = "numTel";
            this.numTel.Width = 125;
            // 
            // codeCNAM
            // 
            this.codeCNAM.HeaderText = "codeCNAM";
            this.codeCNAM.MinimumWidth = 6;
            this.codeCNAM.Name = "codeCNAM";
            this.codeCNAM.Width = 125;
            // 
            // etatCivil
            // 
            this.etatCivil.HeaderText = "etatCivil";
            this.etatCivil.MinimumWidth = 6;
            this.etatCivil.Name = "etatCivil";
            this.etatCivil.Width = 125;
            // 
            // nomConjoint
            // 
            this.nomConjoint.HeaderText = "nomConjoint";
            this.nomConjoint.MinimumWidth = 6;
            this.nomConjoint.Name = "nomConjoint";
            this.nomConjoint.Width = 125;
            // 
            // prenomConjoint
            // 
            this.prenomConjoint.HeaderText = "nomConjoint";
            this.prenomConjoint.MinimumWidth = 6;
            this.prenomConjoint.Name = "prenomConjoint";
            this.prenomConjoint.Width = 125;
            // 
            // nbEnfant
            // 
            this.nbEnfant.HeaderText = "nbEnfant";
            this.nbEnfant.MinimumWidth = 6;
            this.nbEnfant.Name = "nbEnfant";
            this.nbEnfant.Width = 125;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(540, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Chercher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(770, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 56);
            this.button5.TabIndex = 8;
            this.button5.Text = "Chercher";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxForm3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Gestion des employées";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBoxForm3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNais;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeCNAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomConjoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomConjoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbEnfant;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}