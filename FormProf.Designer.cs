﻿namespace GestionSysthemeEtudiant
{
    partial class FormProf
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomprof = new System.Windows.Forms.TextBox();
            this.txtPrenomprof = new System.Windows.Forms.TextBox();
            this.txtEmailprof = new System.Windows.Forms.TextBox();
            this.txtTelprof = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.tableprof = new System.Windows.Forms.DataGridView();
            this.txtRechercheprof = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cklisteClasse = new System.Windows.Forms.CheckedListBox();
            this.cklisteMatiere = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableprof)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone";
            // 
            // txtNomprof
            // 
            this.txtNomprof.Location = new System.Drawing.Point(170, 108);
            this.txtNomprof.Name = "txtNomprof";
            this.txtNomprof.Size = new System.Drawing.Size(100, 20);
            this.txtNomprof.TabIndex = 4;
            // 
            // txtPrenomprof
            // 
            this.txtPrenomprof.Location = new System.Drawing.Point(170, 167);
            this.txtPrenomprof.Name = "txtPrenomprof";
            this.txtPrenomprof.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomprof.TabIndex = 5;
            // 
            // txtEmailprof
            // 
            this.txtEmailprof.Location = new System.Drawing.Point(170, 229);
            this.txtEmailprof.Name = "txtEmailprof";
            this.txtEmailprof.Size = new System.Drawing.Size(100, 20);
            this.txtEmailprof.TabIndex = 6;
            // 
            // txtTelprof
            // 
            this.txtTelprof.Location = new System.Drawing.Point(170, 297);
            this.txtTelprof.Name = "txtTelprof";
            this.txtTelprof.Size = new System.Drawing.Size(100, 20);
            this.txtTelprof.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnadd.Location = new System.Drawing.Point(58, 497);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.Desktop;
            this.btndelete.Location = new System.Drawing.Point(339, 497);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnupdate.Location = new System.Drawing.Point(195, 497);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Modifier";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnclear.Location = new System.Drawing.Point(486, 497);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Effacer";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // tableprof
            // 
            this.tableprof.AllowUserToAddRows = false;
            this.tableprof.AllowUserToDeleteRows = false;
            this.tableprof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableprof.Location = new System.Drawing.Point(339, 61);
            this.tableprof.Name = "tableprof";
            this.tableprof.ReadOnly = true;
            this.tableprof.Size = new System.Drawing.Size(449, 256);
            this.tableprof.TabIndex = 12;
            // 
            // txtRechercheprof
            // 
            this.txtRechercheprof.Location = new System.Drawing.Point(339, 12);
            this.txtRechercheprof.Multiline = true;
            this.txtRechercheprof.Name = "txtRechercheprof";
            this.txtRechercheprof.Size = new System.Drawing.Size(449, 29);
            this.txtRechercheprof.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Recherche";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Classe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Matiere";
            // 
            // cklisteClasse
            // 
            this.cklisteClasse.FormattingEnabled = true;
            this.cklisteClasse.Location = new System.Drawing.Point(89, 383);
            this.cklisteClasse.Name = "cklisteClasse";
            this.cklisteClasse.Size = new System.Drawing.Size(120, 94);
            this.cklisteClasse.TabIndex = 19;
            // 
            // cklisteMatiere
            // 
            this.cklisteMatiere.FormattingEnabled = true;
            this.cklisteMatiere.Location = new System.Drawing.Point(294, 383);
            this.cklisteMatiere.Name = "cklisteMatiere";
            this.cklisteMatiere.Size = new System.Drawing.Size(120, 94);
            this.cklisteMatiere.TabIndex = 20;
            // 
            // FormProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 638);
            this.Controls.Add(this.cklisteMatiere);
            this.Controls.Add(this.cklisteClasse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRechercheprof);
            this.Controls.Add(this.tableprof);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtTelprof);
            this.Controls.Add(this.txtEmailprof);
            this.Controls.Add(this.txtPrenomprof);
            this.Controls.Add(this.txtNomprof);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProf";
            this.Text = "FormProf";
            ((System.ComponentModel.ISupportInitialize)(this.tableprof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomprof;
        private System.Windows.Forms.TextBox txtPrenomprof;
        private System.Windows.Forms.TextBox txtEmailprof;
        private System.Windows.Forms.TextBox txtTelprof;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridView tableprof;
        private System.Windows.Forms.TextBox txtRechercheprof;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox cklisteClasse;
        private System.Windows.Forms.CheckedListBox cklisteMatiere;
    }
}