namespace Fournisseurs_Reconnect
{
    partial class RechercheAppareil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RechercheAppareil));
            this.label1 = new System.Windows.Forms.Label();
            this.listeMarques = new System.Windows.Forms.ListBox();
            this.listeModèles = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listeTailleStockage = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BoutonReconditionné = new System.Windows.Forms.RadioButton();
            this.boutonNeuf = new System.Windows.Forms.RadioButton();
            this.boutonRecherche = new System.Windows.Forms.Button();
            this.listeType = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.flecheGauche = new System.Windows.Forms.Button();
            this.flecheDroite = new System.Windows.Forms.Button();
            this.labelPrix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.nbrFournisseur = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionnez une marque";
            // 
            // listeMarques
            // 
            this.listeMarques.FormattingEnabled = true;
            this.listeMarques.Location = new System.Drawing.Point(170, 45);
            this.listeMarques.Name = "listeMarques";
            this.listeMarques.Size = new System.Drawing.Size(141, 43);
            this.listeMarques.Sorted = true;
            this.listeMarques.TabIndex = 1;
            this.listeMarques.Click += new System.EventHandler(this.listeMarques_Click);
            this.listeMarques.SelectedIndexChanged += new System.EventHandler(this.listeMarques_Click);
            // 
            // listeModèles
            // 
            this.listeModèles.Enabled = false;
            this.listeModèles.FormattingEnabled = true;
            this.listeModèles.Location = new System.Drawing.Point(169, 197);
            this.listeModèles.Name = "listeModèles";
            this.listeModèles.Size = new System.Drawing.Size(142, 43);
            this.listeModèles.TabIndex = 3;
            this.listeModèles.Click += new System.EventHandler(this.listeModèles_Click);
            this.listeModèles.SelectedIndexChanged += new System.EventHandler(this.listeModèles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selectionnez un modèle";
            // 
            // listeTailleStockage
            // 
            this.listeTailleStockage.Enabled = false;
            this.listeTailleStockage.FormattingEnabled = true;
            this.listeTailleStockage.Location = new System.Drawing.Point(170, 332);
            this.listeTailleStockage.Name = "listeTailleStockage";
            this.listeTailleStockage.Size = new System.Drawing.Size(142, 43);
            this.listeTailleStockage.Sorted = true;
            this.listeTailleStockage.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taille de stockage ( Go )";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoutonReconditionné);
            this.groupBox1.Controls.Add(this.boutonNeuf);
            this.groupBox1.Location = new System.Drawing.Point(111, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neuf ou reconditionné ?";
            // 
            // BoutonReconditionné
            // 
            this.BoutonReconditionné.AutoSize = true;
            this.BoutonReconditionné.Location = new System.Drawing.Point(99, 20);
            this.BoutonReconditionné.Name = "BoutonReconditionné";
            this.BoutonReconditionné.Size = new System.Drawing.Size(94, 17);
            this.BoutonReconditionné.TabIndex = 10;
            this.BoutonReconditionné.Text = "Reconditionné";
            this.BoutonReconditionné.UseVisualStyleBackColor = true;
            this.BoutonReconditionné.CheckedChanged += new System.EventHandler(this.BoutonReconditionné_CheckedChanged);
            // 
            // boutonNeuf
            // 
            this.boutonNeuf.AutoSize = true;
            this.boutonNeuf.Location = new System.Drawing.Point(18, 20);
            this.boutonNeuf.Name = "boutonNeuf";
            this.boutonNeuf.Size = new System.Drawing.Size(48, 17);
            this.boutonNeuf.TabIndex = 9;
            this.boutonNeuf.Text = "Neuf";
            this.boutonNeuf.UseVisualStyleBackColor = true;
            this.boutonNeuf.CheckedChanged += new System.EventHandler(this.boutonNeuf_CheckedChanged);
            // 
            // boutonRecherche
            // 
            this.boutonRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRecherche.Location = new System.Drawing.Point(296, 527);
            this.boutonRecherche.Name = "boutonRecherche";
            this.boutonRecherche.Size = new System.Drawing.Size(75, 23);
            this.boutonRecherche.TabIndex = 11;
            this.boutonRecherche.Text = "Rechercher";
            this.boutonRecherche.UseVisualStyleBackColor = true;
            this.boutonRecherche.Click += new System.EventHandler(this.boutonRecherche_Click);
            // 
            // listeType
            // 
            this.listeType.Cursor = System.Windows.Forms.Cursors.Default;
            this.listeType.Enabled = false;
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(170, 122);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(141, 43);
            this.listeType.TabIndex = 2;
            this.listeType.Click += new System.EventHandler(this.listeType_Click);
            this.listeType.SelectedIndexChanged += new System.EventHandler(this.listeType_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selectionnez un type d\'appareil";
            // 
            // boutonRetour
            // 
            this.boutonRetour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boutonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 521);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(99, 34);
            this.boutonRetour.TabIndex = 13;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Location = new System.Drawing.Point(327, 45);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(61, 13);
            this.linkLabelSite.TabIndex = 20;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "Lien du site";
            this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite_LinkClicked);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(394, -3);
            this.webBrowser1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(767, 501);
            this.webBrowser1.TabIndex = 14;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // flecheGauche
            // 
            this.flecheGauche.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flecheGauche.Enabled = false;
            this.flecheGauche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flecheGauche.Image = global::Fournisseurs_Reconnect.Properties.Resources.fleche_gauche;
            this.flecheGauche.Location = new System.Drawing.Point(772, 504);
            this.flecheGauche.Name = "flecheGauche";
            this.flecheGauche.Size = new System.Drawing.Size(37, 31);
            this.flecheGauche.TabIndex = 15;
            this.flecheGauche.UseVisualStyleBackColor = true;
            this.flecheGauche.Click += new System.EventHandler(this.flecheGauche_Click);
            // 
            // flecheDroite
            // 
            this.flecheDroite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flecheDroite.Enabled = false;
            this.flecheDroite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flecheDroite.Image = global::Fournisseurs_Reconnect.Properties.Resources.fleche_droite;
            this.flecheDroite.Location = new System.Drawing.Point(815, 504);
            this.flecheDroite.Name = "flecheDroite";
            this.flecheDroite.Size = new System.Drawing.Size(37, 31);
            this.flecheDroite.TabIndex = 16;
            this.flecheDroite.UseVisualStyleBackColor = true;
            this.flecheDroite.Click += new System.EventHandler(this.flecheDroite_Click);
            // 
            // labelPrix
            // 
            this.labelPrix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelPrix.Location = new System.Drawing.Point(311, 12);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(58, 20);
            this.labelPrix.TabIndex = 21;
            this.labelPrix.TextChanged += new System.EventHandler(this.labelPrix_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "€";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // nbrFournisseur
            // 
            this.nbrFournisseur.AutoSize = true;
            this.nbrFournisseur.Location = new System.Drawing.Point(311, 66);
            this.nbrFournisseur.Name = "nbrFournisseur";
            this.nbrFournisseur.Size = new System.Drawing.Size(75, 26);
            this.nbrFournisseur.TabIndex = 23;
            this.nbrFournisseur.Text = "Nombre de\r\n fournisseurs : ";
            // 
            // RechercheAppareil
            // 
            this.AcceptButton = this.boutonRecherche;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(1163, 567);
            this.ControlBox = false;
            this.Controls.Add(this.nbrFournisseur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.flecheDroite);
            this.Controls.Add(this.flecheGauche);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listeType);
            this.Controls.Add(this.boutonRecherche);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listeTailleStockage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeModèles);
            this.Controls.Add(this.listeMarques);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RechercheAppareil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appareil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RechercheAppareil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeMarques;
        private System.Windows.Forms.ListBox listeModèles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeTailleStockage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BoutonReconditionné;
        private System.Windows.Forms.RadioButton boutonNeuf;
        private System.Windows.Forms.Button boutonRecherche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listeType;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button flecheGauche;
        private System.Windows.Forms.Button flecheDroite;
        private System.Windows.Forms.TextBox labelPrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label nbrFournisseur;
    }
}