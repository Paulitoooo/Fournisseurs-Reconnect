namespace Fournisseurs_Reconnect.Affiliation.Pièce_détachée
{
    partial class laModificationnAffiliationPieceDetachee
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
            this.bouronRetablir = new System.Windows.Forms.Button();
            this.boutonModifier = new System.Windows.Forms.Button();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nouveauPrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siteFournisseur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bouronRetablir
            // 
            this.bouronRetablir.Location = new System.Drawing.Point(480, 289);
            this.bouronRetablir.Name = "bouronRetablir";
            this.bouronRetablir.Size = new System.Drawing.Size(87, 37);
            this.bouronRetablir.TabIndex = 33;
            this.bouronRetablir.Text = "Rétablir";
            this.bouronRetablir.UseVisualStyleBackColor = true;
            this.bouronRetablir.Click += new System.EventHandler(this.bouronRetablir_Click);
            // 
            // boutonModifier
            // 
            this.boutonModifier.Location = new System.Drawing.Point(573, 289);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(87, 37);
            this.boutonModifier.TabIndex = 27;
            this.boutonModifier.Text = "Modifier\r\nl\'affiliation\r\n";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // boutonRetour
            // 
            this.boutonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonRetour.Location = new System.Drawing.Point(12, 316);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(114, 31);
            this.boutonRetour.TabIndex = 32;
            this.boutonRetour.TabStop = false;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Saisissez un nouveau prix";
            // 
            // nouveauPrix
            // 
            this.nouveauPrix.Location = new System.Drawing.Point(342, 206);
            this.nouveauPrix.Name = "nouveauPrix";
            this.nouveauPrix.Size = new System.Drawing.Size(100, 20);
            this.nouveauPrix.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Saisissez un nouveau lien vers le site de l\'appareil";
            // 
            // siteFournisseur
            // 
            this.siteFournisseur.Location = new System.Drawing.Point(342, 74);
            this.siteFournisseur.Multiline = true;
            this.siteFournisseur.Name = "siteFournisseur";
            this.siteFournisseur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.siteFournisseur.Size = new System.Drawing.Size(176, 97);
            this.siteFournisseur.TabIndex = 28;
            // 
            // laModificationnAffiliationPieceDetachee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(729, 359);
            this.ControlBox = false;
            this.Controls.Add(this.bouronRetablir);
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nouveauPrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siteFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "laModificationnAffiliationPieceDetachee";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification affilation pièce détachée";
            this.Load += new System.EventHandler(this.laModificationnAffiliationPieceDetachee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bouronRetablir;
        private System.Windows.Forms.Button boutonModifier;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nouveauPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox siteFournisseur;
    }
}