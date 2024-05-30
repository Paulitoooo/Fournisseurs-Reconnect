namespace Fournisseurs_Reconnect
{
    partial class ModifierSupprimerFournisseur
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
            this.boutonModifier = new System.Windows.Forms.Button();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listeFournisseur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // boutonModifier
            // 
            this.boutonModifier.Location = new System.Drawing.Point(244, 165);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(75, 23);
            this.boutonModifier.TabIndex = 21;
            this.boutonModifier.Text = "Modifier";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 237);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(112, 23);
            this.boutonRetour.TabIndex = 20;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.Location = new System.Drawing.Point(325, 165);
            this.boutonSupprimer.Name = "boutonSupprimer";
            this.boutonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.boutonSupprimer.TabIndex = 19;
            this.boutonSupprimer.Text = "Supprimer";
            this.boutonSupprimer.UseVisualStyleBackColor = true;
            this.boutonSupprimer.Click += new System.EventHandler(this.boutonSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Selectionnez un fournisseur à modifier/supprimer";
            // 
            // listeFournisseur
            // 
            this.listeFournisseur.FormattingEnabled = true;
            this.listeFournisseur.HorizontalScrollbar = true;
            this.listeFournisseur.Location = new System.Drawing.Point(261, 47);
            this.listeFournisseur.Name = "listeFournisseur";
            this.listeFournisseur.Size = new System.Drawing.Size(120, 95);
            this.listeFournisseur.Sorted = true;
            this.listeFournisseur.TabIndex = 17;
            // 
            // ModifierSupprimerFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(582, 272);
            this.ControlBox = false;
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierSupprimerFournisseur";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier/Supprimer un fournisseur";
            this.Load += new System.EventHandler(this.ModifierSupprimerFournisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonModifier;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeFournisseur;
    }
}