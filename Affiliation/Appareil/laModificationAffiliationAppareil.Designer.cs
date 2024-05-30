namespace Fournisseurs_Reconnect.Affiliation
{
    partial class laModificationAffiliationAppareil
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
            this.siteFournisseur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nouveauPrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.boutonModifier = new System.Windows.Forms.Button();
            this.bouronRetablir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // siteFournisseur
            // 
            this.siteFournisseur.Location = new System.Drawing.Point(342, 82);
            this.siteFournisseur.Multiline = true;
            this.siteFournisseur.Name = "siteFournisseur";
            this.siteFournisseur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.siteFournisseur.Size = new System.Drawing.Size(176, 97);
            this.siteFournisseur.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Saisissez un nouveau lien vers le site de l\'appareil";
            // 
            // nouveauPrix
            // 
            this.nouveauPrix.Location = new System.Drawing.Point(342, 214);
            this.nouveauPrix.Name = "nouveauPrix";
            this.nouveauPrix.Size = new System.Drawing.Size(100, 20);
            this.nouveauPrix.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Saisissez un nouveau prix";
            // 
            // boutonRetour
            // 
            this.boutonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonRetour.Location = new System.Drawing.Point(12, 324);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(114, 31);
            this.boutonRetour.TabIndex = 25;
            this.boutonRetour.TabStop = false;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // boutonModifier
            // 
            this.boutonModifier.Location = new System.Drawing.Point(573, 297);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(87, 37);
            this.boutonModifier.TabIndex = 1;
            this.boutonModifier.Text = "Modifier\r\nl\'affiliation\r\n";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // bouronRetablir
            // 
            this.bouronRetablir.Location = new System.Drawing.Point(480, 297);
            this.bouronRetablir.Name = "bouronRetablir";
            this.bouronRetablir.Size = new System.Drawing.Size(87, 37);
            this.bouronRetablir.TabIndex = 26;
            this.bouronRetablir.Text = "Rétablir";
            this.bouronRetablir.UseVisualStyleBackColor = true;
            this.bouronRetablir.Click += new System.EventHandler(this.bouronRetablir_Click);
            // 
            // laModificationAffiliationAppareil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(733, 363);
            this.ControlBox = false;
            this.Controls.Add(this.bouronRetablir);
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nouveauPrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siteFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "laModificationAffiliationAppareil";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Modifier l\'affiliation d\'un appareil";
            this.Load += new System.EventHandler(this.laModificationAffiliationAppareil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox siteFournisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nouveauPrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonModifier;
        private System.Windows.Forms.Button bouronRetablir;
    }
}