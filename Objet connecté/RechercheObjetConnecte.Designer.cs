﻿namespace Fournisseurs_Reconnect.Objet_connecté
{
    partial class RechercheObjetConnecte
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.nbrFournisseur = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.TextBox();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.boutonRecherche = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listeModele = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listeTypeObjetCo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeMarque = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(397, 0);
            this.webBrowser1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(767, 496);
            this.webBrowser1.TabIndex = 15;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // nbrFournisseur
            // 
            this.nbrFournisseur.AutoSize = true;
            this.nbrFournisseur.Location = new System.Drawing.Point(311, 66);
            this.nbrFournisseur.Name = "nbrFournisseur";
            this.nbrFournisseur.Size = new System.Drawing.Size(75, 26);
            this.nbrFournisseur.TabIndex = 37;
            this.nbrFournisseur.Text = "Nombre de\r\n fournisseurs : ";
            // 
            // labelPrix
            // 
            this.labelPrix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelPrix.Location = new System.Drawing.Point(311, 12);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(58, 20);
            this.labelPrix.TabIndex = 36;
            // 
            // boutonRetour
            // 
            this.boutonRetour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boutonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 521);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(99, 34);
            this.boutonRetour.TabIndex = 34;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Location = new System.Drawing.Point(327, 45);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(61, 13);
            this.linkLabelSite.TabIndex = 35;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "Lien du site";
            // 
            // boutonRecherche
            // 
            this.boutonRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRecherche.Location = new System.Drawing.Point(296, 527);
            this.boutonRecherche.Name = "boutonRecherche";
            this.boutonRecherche.Size = new System.Drawing.Size(75, 23);
            this.boutonRecherche.TabIndex = 33;
            this.boutonRecherche.Text = "Rechercher";
            this.boutonRecherche.UseVisualStyleBackColor = true;
            this.boutonRecherche.Click += new System.EventHandler(this.boutonRecherche_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Selectionnez un modèle\r\n";
            // 
            // listeModele
            // 
            this.listeModele.Enabled = false;
            this.listeModele.FormattingEnabled = true;
            this.listeModele.Location = new System.Drawing.Point(207, 318);
            this.listeModele.Name = "listeModele";
            this.listeModele.Size = new System.Drawing.Size(120, 56);
            this.listeModele.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Selectionnez un type d\'objet connecté";
            // 
            // listeTypeObjetCo
            // 
            this.listeTypeObjetCo.Enabled = false;
            this.listeTypeObjetCo.FormattingEnabled = true;
            this.listeTypeObjetCo.Location = new System.Drawing.Point(207, 229);
            this.listeTypeObjetCo.Name = "listeTypeObjetCo";
            this.listeTypeObjetCo.Size = new System.Drawing.Size(120, 56);
            this.listeTypeObjetCo.TabIndex = 68;
            this.listeTypeObjetCo.SelectedIndexChanged += new System.EventHandler(this.listeTypeObjetCo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Selectionnez une marque";
            // 
            // listeMarque
            // 
            this.listeMarque.FormattingEnabled = true;
            this.listeMarque.Location = new System.Drawing.Point(207, 140);
            this.listeMarque.Name = "listeMarque";
            this.listeMarque.Size = new System.Drawing.Size(120, 56);
            this.listeMarque.TabIndex = 66;
            this.listeMarque.SelectedIndexChanged += new System.EventHandler(this.listeMarque_Click);
            // 
            // RechercheObjetConnecte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1163, 567);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listeModele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeTypeObjetCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeMarque);
            this.Controls.Add(this.nbrFournisseur);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.boutonRecherche);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RechercheObjetConnecte";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RechercheObjetConnecte";
            this.Load += new System.EventHandler(this.RechercheObjetConnecte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label nbrFournisseur;
        private System.Windows.Forms.TextBox labelPrix;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.Button boutonRecherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listeModele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeTypeObjetCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeMarque;
    }
}