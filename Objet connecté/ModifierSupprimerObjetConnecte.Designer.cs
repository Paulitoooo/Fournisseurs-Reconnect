namespace Fournisseurs_Reconnect.Objet_connecté
{
    partial class ModifierSupprimerObjetConnecte
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
            this.label2 = new System.Windows.Forms.Label();
            this.listeTypeObjetCo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeMarque = new System.Windows.Forms.ListBox();
            this.listeModele = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boutonModifier = new System.Windows.Forms.Button();
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 302);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(112, 23);
            this.boutonRetour.TabIndex = 56;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Selectionnez un type d\'objet connecté";
            // 
            // listeTypeObjetCo
            // 
            this.listeTypeObjetCo.Enabled = false;
            this.listeTypeObjetCo.FormattingEnabled = true;
            this.listeTypeObjetCo.Location = new System.Drawing.Point(281, 111);
            this.listeTypeObjetCo.Name = "listeTypeObjetCo";
            this.listeTypeObjetCo.Size = new System.Drawing.Size(120, 56);
            this.listeTypeObjetCo.TabIndex = 62;
            this.listeTypeObjetCo.Click += new System.EventHandler(this.listeTypeObjetCo_Click);
            this.listeTypeObjetCo.SelectedIndexChanged += new System.EventHandler(this.listeTypeObjetCo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Selectionnez une marque";
            // 
            // listeMarque
            // 
            this.listeMarque.FormattingEnabled = true;
            this.listeMarque.Location = new System.Drawing.Point(281, 22);
            this.listeMarque.Name = "listeMarque";
            this.listeMarque.Size = new System.Drawing.Size(120, 56);
            this.listeMarque.TabIndex = 60;
            this.listeMarque.Click += new System.EventHandler(this.listeMarque_Click);
            this.listeMarque.SelectedIndexChanged += new System.EventHandler(this.listeMarque_Click);
            // 
            // listeModele
            // 
            this.listeModele.Enabled = false;
            this.listeModele.FormattingEnabled = true;
            this.listeModele.Location = new System.Drawing.Point(281, 200);
            this.listeModele.Name = "listeModele";
            this.listeModele.Size = new System.Drawing.Size(120, 56);
            this.listeModele.TabIndex = 64;
            this.listeModele.Click += new System.EventHandler(this.listeModele_Click);
            this.listeModele.SelectedIndexChanged += new System.EventHandler(this.listeModele_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Selectionnez un modèle\r\n";
            // 
            // boutonModifier
            // 
            this.boutonModifier.Enabled = false;
            this.boutonModifier.Location = new System.Drawing.Point(260, 284);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(75, 23);
            this.boutonModifier.TabIndex = 67;
            this.boutonModifier.Text = "Modifier";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.Enabled = false;
            this.boutonSupprimer.Location = new System.Drawing.Point(341, 284);
            this.boutonSupprimer.Name = "boutonSupprimer";
            this.boutonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.boutonSupprimer.TabIndex = 66;
            this.boutonSupprimer.Text = "Supprimer";
            this.boutonSupprimer.UseVisualStyleBackColor = true;
            this.boutonSupprimer.Click += new System.EventHandler(this.boutonSupprimer_Click);
            // 
            // ModifierSupprimerObjetConnecte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(670, 337);
            this.ControlBox = false;
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listeModele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeTypeObjetCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeMarque);
            this.Controls.Add(this.boutonRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierSupprimerObjetConnecte";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modfier/Supprimer un objet connecté";
            this.Load += new System.EventHandler(this.ModifierSupprimerObjetConnecte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeTypeObjetCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeMarque;
        private System.Windows.Forms.ListBox listeModele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boutonModifier;
        private System.Windows.Forms.Button boutonSupprimer;
    }
}