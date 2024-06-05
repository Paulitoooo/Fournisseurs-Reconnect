namespace Fournisseurs_Reconnect.Objet_connecté
{
    partial class AjouterModifierSupprimerObjetConnecte
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
            this.boutonRetour = new System.Windows.Forms.Button();
            this.listeMarque = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeTypeObjetCo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomModele = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boutonAjouter = new System.Windows.Forms.Button();
            this.boutonSupprimerMarque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 370);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(112, 23);
            this.boutonRetour.TabIndex = 55;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // listeMarque
            // 
            this.listeMarque.FormattingEnabled = true;
            this.listeMarque.Location = new System.Drawing.Point(281, 72);
            this.listeMarque.Name = "listeMarque";
            this.listeMarque.Size = new System.Drawing.Size(120, 56);
            this.listeMarque.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Selectionnez une marque";
            // 
            // listeTypeObjetCo
            // 
            this.listeTypeObjetCo.FormattingEnabled = true;
            this.listeTypeObjetCo.Location = new System.Drawing.Point(281, 161);
            this.listeTypeObjetCo.Name = "listeTypeObjetCo";
            this.listeTypeObjetCo.Size = new System.Drawing.Size(120, 56);
            this.listeTypeObjetCo.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Selectionnez un type d\'objet connecté";
            // 
            // textBoxNomModele
            // 
            this.textBoxNomModele.Location = new System.Drawing.Point(281, 251);
            this.textBoxNomModele.Name = "textBoxNomModele";
            this.textBoxNomModele.Size = new System.Drawing.Size(120, 20);
            this.textBoxNomModele.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Saisissez un nom de modèle";
            // 
            // boutonAjouter
            // 
            this.boutonAjouter.Location = new System.Drawing.Point(288, 332);
            this.boutonAjouter.Name = "boutonAjouter";
            this.boutonAjouter.Size = new System.Drawing.Size(101, 36);
            this.boutonAjouter.TabIndex = 62;
            this.boutonAjouter.Text = "Ajouter";
            this.boutonAjouter.UseVisualStyleBackColor = true;
            this.boutonAjouter.Click += new System.EventHandler(this.boutonAjouter_Click);
            // 
            // boutonSupprimerMarque
            // 
            this.boutonSupprimerMarque.Location = new System.Drawing.Point(592, 348);
            this.boutonSupprimerMarque.Name = "boutonSupprimerMarque";
            this.boutonSupprimerMarque.Size = new System.Drawing.Size(138, 45);
            this.boutonSupprimerMarque.TabIndex = 63;
            this.boutonSupprimerMarque.Text = "Modifier/Supprimer un objet connecté ?";
            this.boutonSupprimerMarque.UseVisualStyleBackColor = true;
            this.boutonSupprimerMarque.Click += new System.EventHandler(this.boutonSupprimerMarque_Click);
            // 
            // AjouterModifierSupprimerObjetConnecte
            // 
            this.AcceptButton = this.boutonAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(742, 405);
            this.ControlBox = false;
            this.Controls.Add(this.boutonSupprimerMarque);
            this.Controls.Add(this.boutonAjouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomModele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeTypeObjetCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeMarque);
            this.Controls.Add(this.boutonRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterModifierSupprimerObjetConnecte";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterModifierSupprimerObjetConnecte";
            this.Load += new System.EventHandler(this.AjouterModifierSupprimerObjetConnecte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.ListBox listeMarque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeTypeObjetCo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomModele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boutonAjouter;
        private System.Windows.Forms.Button boutonSupprimerMarque;
    }
}