
namespace projet_csharp
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fraisActe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCIN_EMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule d\'employée :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.depotDate,
            this.acte,
            this.fraisActe,
            this.idCIN_EMP});
            this.dataGridView1.Location = new System.Drawing.Point(12, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 241);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // num
            // 
            this.num.HeaderText = "num";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.Width = 125;
            // 
            // depotDate
            // 
            this.depotDate.HeaderText = "depotDate";
            this.depotDate.MinimumWidth = 6;
            this.depotDate.Name = "depotDate";
            this.depotDate.Width = 125;
            // 
            // acte
            // 
            this.acte.HeaderText = "acte";
            this.acte.MinimumWidth = 6;
            this.acte.Name = "acte";
            this.acte.Width = 125;
            // 
            // fraisActe
            // 
            this.fraisActe.HeaderText = "fraisActe";
            this.fraisActe.MinimumWidth = 6;
            this.fraisActe.Name = "fraisActe";
            this.fraisActe.Width = 125;
            // 
            // idCIN_EMP
            // 
            this.idCIN_EMP.HeaderText = "idCIN_EMP";
            this.idCIN_EMP.MinimumWidth = 6;
            this.idCIN_EMP.Name = "idCIN_EMP";
            this.idCIN_EMP.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Afficher tous les Bulletins";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(430, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(338, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "Afficher les bulletins d\'un emlpyée donnée";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(654, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "Retour";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(946, 497);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Consultation des Bulletins";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn depotDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn acte;
        private System.Windows.Forms.DataGridViewTextBoxColumn fraisActe;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCIN_EMP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}