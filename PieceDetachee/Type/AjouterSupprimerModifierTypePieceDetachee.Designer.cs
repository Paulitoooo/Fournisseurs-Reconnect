namespace Fournisseurs_Reconnect.PieceDetachee
{
    partial class AjouterSupprimerModifierTypePieceDetachee
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
            this.textBoxLibelleType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.boutonValider = new System.Windows.Forms.Button();
            this.boutonModifierSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLibelleType
            // 
            this.textBoxLibelleType.Location = new System.Drawing.Point(122, 96);
            this.textBoxLibelleType.Name = "textBoxLibelleType";
            this.textBoxLibelleType.Size = new System.Drawing.Size(264, 20);
            this.textBoxLibelleType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saisissez un nom de type de pièce détachée";
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 235);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(75, 23);
            this.boutonRetour.TabIndex = 2;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // boutonValider
            // 
            this.boutonValider.Location = new System.Drawing.Point(210, 146);
            this.boutonValider.Name = "boutonValider";
            this.boutonValider.Size = new System.Drawing.Size(75, 23);
            this.boutonValider.TabIndex = 3;
            this.boutonValider.Text = "Valider";
            this.boutonValider.UseVisualStyleBackColor = true;
            this.boutonValider.Click += new System.EventHandler(this.boutonValider_Click);
            // 
            // boutonModifierSupprimer
            // 
            this.boutonModifierSupprimer.Location = new System.Drawing.Point(396, 214);
            this.boutonModifierSupprimer.Name = "boutonModifierSupprimer";
            this.boutonModifierSupprimer.Size = new System.Drawing.Size(109, 44);
            this.boutonModifierSupprimer.TabIndex = 4;
            this.boutonModifierSupprimer.Text = "Modifier/Supprimer un type";
            this.boutonModifierSupprimer.UseVisualStyleBackColor = true;
            this.boutonModifierSupprimer.Click += new System.EventHandler(this.boutonModifierSupprimer_Click);
            // 
            // AjouterSupprimerModifierTypePieceDetachee
            // 
            this.AcceptButton = this.boutonValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(517, 270);
            this.ControlBox = false;
            this.Controls.Add(this.boutonModifierSupprimer);
            this.Controls.Add(this.boutonValider);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLibelleType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterSupprimerModifierTypePieceDetachee";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter/Modifier/Supprimer un type de piece détachée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLibelleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonValider;
        private System.Windows.Forms.Button boutonModifierSupprimer;
    }
}