namespace Fournisseurs_Reconnect
{
    partial class AjouterModifierSupprimerFournisseur
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
            this.boutonModifSupprimerFournisseur = new System.Windows.Forms.Button();
            this.boutonEnregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomFournisseur = new System.Windows.Forms.TextBox();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 237);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(112, 23);
            this.boutonRetour.TabIndex = 54;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // boutonModifSupprimerFournisseur
            // 
            this.boutonModifSupprimerFournisseur.Location = new System.Drawing.Point(408, 215);
            this.boutonModifSupprimerFournisseur.Name = "boutonModifSupprimerFournisseur";
            this.boutonModifSupprimerFournisseur.Size = new System.Drawing.Size(138, 45);
            this.boutonModifSupprimerFournisseur.TabIndex = 53;
            this.boutonModifSupprimerFournisseur.Text = "Modifier/Supprimer un fournisseur ?";
            this.boutonModifSupprimerFournisseur.UseVisualStyleBackColor = true;
            this.boutonModifSupprimerFournisseur.Click += new System.EventHandler(this.boutonModifSupprimerFournisseur_Click);
            // 
            // boutonEnregistrer
            // 
            this.boutonEnregistrer.Location = new System.Drawing.Point(318, 152);
            this.boutonEnregistrer.Name = "boutonEnregistrer";
            this.boutonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.boutonEnregistrer.TabIndex = 52;
            this.boutonEnregistrer.Text = "Enregistrer";
            this.boutonEnregistrer.UseVisualStyleBackColor = true;
            this.boutonEnregistrer.Click += new System.EventHandler(this.boutonEnregistrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Saisissez un nom de fournisseur : \r\n";
            // 
            // textBoxNomFournisseur
            // 
            this.textBoxNomFournisseur.Location = new System.Drawing.Point(191, 58);
            this.textBoxNomFournisseur.MaxLength = 150;
            this.textBoxNomFournisseur.Name = "textBoxNomFournisseur";
            this.textBoxNomFournisseur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxNomFournisseur.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxNomFournisseur.Size = new System.Drawing.Size(312, 20);
            this.textBoxNomFournisseur.TabIndex = 51;
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(191, 98);
            this.textBoxSite.MaxLength = 150;
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSite.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxSite.Size = new System.Drawing.Size(312, 20);
            this.textBoxSite.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Saisissez un site de fournisseur : \r\n";
            // 
            // AjouterModifierSupprimerFournisseur
            // 
            this.AcceptButton = this.boutonEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(582, 272);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSite);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.boutonModifSupprimerFournisseur);
            this.Controls.Add(this.boutonEnregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterModifierSupprimerFournisseur";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterFournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonModifSupprimerFournisseur;
        private System.Windows.Forms.Button boutonEnregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomFournisseur;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.Label label2;
    }
}