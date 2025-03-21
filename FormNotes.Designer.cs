namespace GestionSysthemeEtudiant
{
    partial class FormNotes
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEtudiant = new System.Windows.Forms.ComboBox();
            this.cmbMatiere = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tablebulletin = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoyenne = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablebulletin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etudiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matiere";
            // 
            // cmbEtudiant
            // 
            this.cmbEtudiant.FormattingEnabled = true;
            this.cmbEtudiant.Location = new System.Drawing.Point(103, 76);
            this.cmbEtudiant.Name = "cmbEtudiant";
            this.cmbEtudiant.Size = new System.Drawing.Size(121, 21);
            this.cmbEtudiant.TabIndex = 2;
            // 
            // cmbMatiere
            // 
            this.cmbMatiere.FormattingEnabled = true;
            this.cmbMatiere.Location = new System.Drawing.Point(103, 142);
            this.cmbMatiere.Name = "cmbMatiere";
            this.cmbMatiere.Size = new System.Drawing.Size(121, 21);
            this.cmbMatiere.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(103, 219);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(121, 20);
            this.txtNote.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAjouter.Location = new System.Drawing.Point(27, 362);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(197, 33);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // tablebulletin
            // 
            this.tablebulletin.AllowUserToAddRows = false;
            this.tablebulletin.AllowUserToDeleteRows = false;
            this.tablebulletin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablebulletin.Location = new System.Drawing.Point(357, 84);
            this.tablebulletin.Name = "tablebulletin";
            this.tablebulletin.ReadOnly = true;
            this.tablebulletin.Size = new System.Drawing.Size(396, 311);
            this.tablebulletin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Moyenne";
            // 
            // txtMoyenne
            // 
            this.txtMoyenne.Location = new System.Drawing.Point(103, 300);
            this.txtMoyenne.Name = "txtMoyenne";
            this.txtMoyenne.Size = new System.Drawing.Size(121, 20);
            this.txtMoyenne.TabIndex = 9;
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 638);
            this.Controls.Add(this.txtMoyenne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tablebulletin);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMatiere);
            this.Controls.Add(this.cmbEtudiant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotes";
            this.Text = "FormNotes";
            ((System.ComponentModel.ISupportInitialize)(this.tablebulletin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEtudiant;
        private System.Windows.Forms.ComboBox cmbMatiere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView tablebulletin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoyenne;
    }
}