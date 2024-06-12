namespace Fournisseurs_Reconnect.Accessoires
{
    partial class RechercheAccessoire
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flecheDroite = new System.Windows.Forms.Button();
            this.flecheGauche = new System.Windows.Forms.Button();
            this.nbrFournisseur = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.TextBox();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.boutonRecherche = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label3 = new System.Windows.Forms.Label();
            this.listeAccessoires = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listeType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeMarque = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "€";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(288, 94);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 12);
            this.progressBar1.TabIndex = 90;
            // 
            // flecheDroite
            // 
            this.flecheDroite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flecheDroite.Enabled = false;
            this.flecheDroite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flecheDroite.Image = global::Fournisseurs_Reconnect.Properties.Resources.fleche_droite;
            this.flecheDroite.Location = new System.Drawing.Point(825, 498);
            this.flecheDroite.Name = "flecheDroite";
            this.flecheDroite.Size = new System.Drawing.Size(37, 31);
            this.flecheDroite.TabIndex = 89;
            this.flecheDroite.UseVisualStyleBackColor = true;
            this.flecheDroite.Click += new System.EventHandler(this.flecheDroite_Click);
            // 
            // flecheGauche
            // 
            this.flecheGauche.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flecheGauche.Enabled = false;
            this.flecheGauche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flecheGauche.Image = global::Fournisseurs_Reconnect.Properties.Resources.fleche_gauche;
            this.flecheGauche.Location = new System.Drawing.Point(782, 498);
            this.flecheGauche.Name = "flecheGauche";
            this.flecheGauche.Size = new System.Drawing.Size(37, 31);
            this.flecheGauche.TabIndex = 88;
            this.flecheGauche.UseVisualStyleBackColor = true;
            this.flecheGauche.Click += new System.EventHandler(this.flecheGauche_Click);
            // 
            // nbrFournisseur
            // 
            this.nbrFournisseur.AutoSize = true;
            this.nbrFournisseur.Location = new System.Drawing.Point(301, 140);
            this.nbrFournisseur.Name = "nbrFournisseur";
            this.nbrFournisseur.Size = new System.Drawing.Size(75, 26);
            this.nbrFournisseur.TabIndex = 81;
            this.nbrFournisseur.Text = "Nombre de\r\n fournisseurs : ";
            // 
            // labelPrix
            // 
            this.labelPrix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelPrix.Location = new System.Drawing.Point(311, 61);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(58, 20);
            this.labelPrix.TabIndex = 80;
            this.labelPrix.TextChanged += new System.EventHandler(this.labelPrix_TextChanged);
            // 
            // boutonRetour
            // 
            this.boutonRetour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boutonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 517);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(99, 34);
            this.boutonRetour.TabIndex = 78;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Enabled = false;
            this.linkLabelSite.Location = new System.Drawing.Point(317, 119);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(61, 13);
            this.linkLabelSite.TabIndex = 79;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "Lien du site";
            this.linkLabelSite.Click += new System.EventHandler(this.linkLabelSite_Click);
            // 
            // boutonRecherche
            // 
            this.boutonRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRecherche.Location = new System.Drawing.Point(296, 523);
            this.boutonRecherche.Name = "boutonRecherche";
            this.boutonRecherche.Size = new System.Drawing.Size(120, 23);
            this.boutonRecherche.TabIndex = 77;
            this.boutonRecherche.Text = "Rechercher";
            this.boutonRecherche.UseVisualStyleBackColor = true;
            this.boutonRecherche.Click += new System.EventHandler(this.boutonRecherche_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(394, 2);
            this.webBrowser1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(764, 490);
            this.webBrowser1.TabIndex = 76;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Selectionnez un accessoire";
            // 
            // listeAccessoires
            // 
            this.listeAccessoires.FormattingEnabled = true;
            this.listeAccessoires.Location = new System.Drawing.Point(197, 357);
            this.listeAccessoires.Name = "listeAccessoires";
            this.listeAccessoires.Size = new System.Drawing.Size(117, 43);
            this.listeAccessoires.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Selectionnez un type";
            // 
            // listeType
            // 
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(197, 275);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(117, 56);
            this.listeType.Sorted = true;
            this.listeType.TabIndex = 94;
            this.listeType.SelectedIndexChanged += new System.EventHandler(this.listeType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Selectionnez une marque";
            // 
            // listeMarque
            // 
            this.listeMarque.FormattingEnabled = true;
            this.listeMarque.Location = new System.Drawing.Point(197, 193);
            this.listeMarque.Name = "listeMarque";
            this.listeMarque.Size = new System.Drawing.Size(117, 56);
            this.listeMarque.Sorted = true;
            this.listeMarque.TabIndex = 92;
            this.listeMarque.SelectedIndexChanged += new System.EventHandler(this.listeMarque_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Si le prix est différent vous  pouvez le modifier :";
            // 
            // RechercheAccessoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(1147, 551);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listeAccessoires);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeMarque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.flecheDroite);
            this.Controls.Add(this.flecheGauche);
            this.Controls.Add(this.nbrFournisseur);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.boutonRecherche);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RechercheAccessoire";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher un accessoire";
            this.Load += new System.EventHandler(this.RechercheAccessoire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button flecheDroite;
        private System.Windows.Forms.Button flecheGauche;
        private System.Windows.Forms.Label nbrFournisseur;
        private System.Windows.Forms.TextBox labelPrix;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.Button boutonRecherche;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listeAccessoires;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeMarque;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
    }
}