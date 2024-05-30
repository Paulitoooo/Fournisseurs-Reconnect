namespace Fournisseurs_Reconnect.PieceDetachee
{
    partial class ModifierSupprimerTypePieceDetachee
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
            this.listeType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.boutonModifier = new System.Windows.Forms.Button();
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listeType
            // 
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(255, 49);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(120, 95);
            this.listeType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionnez un type de pièce détachée";
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 249);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(75, 23);
            this.boutonRetour.TabIndex = 3;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // boutonModifier
            // 
            this.boutonModifier.Location = new System.Drawing.Point(226, 167);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(75, 23);
            this.boutonModifier.TabIndex = 4;
            this.boutonModifier.Text = "Modifier";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.Location = new System.Drawing.Point(327, 167);
            this.boutonSupprimer.Name = "boutonSupprimer";
            this.boutonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.boutonSupprimer.TabIndex = 5;
            this.boutonSupprimer.Text = "Supprimer";
            this.boutonSupprimer.UseVisualStyleBackColor = true;
            this.boutonSupprimer.Click += new System.EventHandler(this.boutonSupprimer_Click);
            // 
            // ModifierSupprimerTypePieceDetachee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 284);
            this.ControlBox = false;
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierSupprimerTypePieceDetachee";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierSupprimerTypePieceDetachee";
            this.Load += new System.EventHandler(this.ModifierSupprimerTypePieceDetachee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonModifier;
        private System.Windows.Forms.Button boutonSupprimer;
    }
}