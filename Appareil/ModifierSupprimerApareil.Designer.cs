namespace Fournisseurs_Reconnect
{
    partial class ModifierSupprimerApareil
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
            this.listeAppareils = new System.Windows.Forms.ListBox();
            this.listeMarques = new System.Windows.Forms.ListBox();
            this.labelMarque = new System.Windows.Forms.Label();
            this.listeTypes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listeStockage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // boutonModifier
            // 
            this.boutonModifier.Enabled = false;
            this.boutonModifier.Location = new System.Drawing.Point(219, 230);
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
            this.boutonSupprimer.Enabled = false;
            this.boutonSupprimer.Location = new System.Drawing.Point(300, 230);
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
            this.label1.Location = new System.Drawing.Point(9, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Selectionnez un appareil à modifier/supprimer";
            // 
            // listeAppareils
            // 
            this.listeAppareils.Enabled = false;
            this.listeAppareils.FormattingEnabled = true;
            this.listeAppareils.HorizontalScrollbar = true;
            this.listeAppareils.Location = new System.Drawing.Point(236, 151);
            this.listeAppareils.Name = "listeAppareils";
            this.listeAppareils.Size = new System.Drawing.Size(120, 56);
            this.listeAppareils.Sorted = true;
            this.listeAppareils.TabIndex = 17;
            this.listeAppareils.Click += new System.EventHandler(this.listeAppareils_Click);
            // 
            // listeMarques
            // 
            this.listeMarques.FormattingEnabled = true;
            this.listeMarques.Location = new System.Drawing.Point(236, 12);
            this.listeMarques.Name = "listeMarques";
            this.listeMarques.Size = new System.Drawing.Size(120, 56);
            this.listeMarques.TabIndex = 22;
            this.listeMarques.Click += new System.EventHandler(this.listeMarques_Click);
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(103, 12);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(127, 13);
            this.labelMarque.TabIndex = 23;
            this.labelMarque.Text = "Selectionnez une marque";
            // 
            // listeTypes
            // 
            this.listeTypes.Enabled = false;
            this.listeTypes.FormattingEnabled = true;
            this.listeTypes.Location = new System.Drawing.Point(236, 80);
            this.listeTypes.Name = "listeTypes";
            this.listeTypes.Size = new System.Drawing.Size(120, 56);
            this.listeTypes.TabIndex = 24;
            this.listeTypes.Click += new System.EventHandler(this.listeTypes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Selectionnez un type";
            // 
            // listeStockage
            // 
            this.listeStockage.Enabled = false;
            this.listeStockage.FormattingEnabled = true;
            this.listeStockage.Location = new System.Drawing.Point(422, 151);
            this.listeStockage.Name = "listeStockage";
            this.listeStockage.Size = new System.Drawing.Size(120, 56);
            this.listeStockage.TabIndex = 26;
            this.listeStockage.Click += new System.EventHandler(this.listeStockage_Click);
            // 
            // ModifierSupprimerApareil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(582, 272);
            this.ControlBox = false;
            this.Controls.Add(this.listeStockage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeTypes);
            this.Controls.Add(this.labelMarque);
            this.Controls.Add(this.listeMarques);
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeAppareils);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierSupprimerApareil";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierSupprimerApareil";
            this.Load += new System.EventHandler(this.AjouterModifierSupprimerApareil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonModifier;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeAppareils;
        private System.Windows.Forms.ListBox listeMarques;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.ListBox listeTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeStockage;
    }
}