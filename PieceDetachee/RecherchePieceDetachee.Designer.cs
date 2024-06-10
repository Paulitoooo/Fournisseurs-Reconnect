namespace Fournisseurs_Reconnect.PieceDetachee
{
    partial class RecherchePieceDetachee
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
            this.label8 = new System.Windows.Forms.Label();
            this.listeMarques = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listeTypeAppareil = new System.Windows.Forms.ListBox();
            this.listeAppareil = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listeTypePieceDetachee = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listePieces = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.nbrFournisseur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.TextBox();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.flecheDroite = new System.Windows.Forms.Button();
            this.flecheGauche = new System.Windows.Forms.Button();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.boutonRecherche = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Selectionnez une marque d\'appareil";
            // 
            // listeMarques
            // 
            this.listeMarques.FormattingEnabled = true;
            this.listeMarques.Location = new System.Drawing.Point(207, 67);
            this.listeMarques.Name = "listeMarques";
            this.listeMarques.Size = new System.Drawing.Size(120, 56);
            this.listeMarques.Sorted = true;
            this.listeMarques.TabIndex = 30;
            this.listeMarques.Click += new System.EventHandler(this.listeMarques_Click);
            this.listeMarques.SelectedIndexChanged += new System.EventHandler(this.listeMarques_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Selectionnez un type d\'appareil";
            // 
            // listeTypeAppareil
            // 
            this.listeTypeAppareil.Enabled = false;
            this.listeTypeAppareil.FormattingEnabled = true;
            this.listeTypeAppareil.Location = new System.Drawing.Point(207, 140);
            this.listeTypeAppareil.Name = "listeTypeAppareil";
            this.listeTypeAppareil.Size = new System.Drawing.Size(120, 43);
            this.listeTypeAppareil.TabIndex = 28;
            this.listeTypeAppareil.Click += new System.EventHandler(this.listeTypeAppareil_Click);
            this.listeTypeAppareil.SelectedIndexChanged += new System.EventHandler(this.listeTypeAppareil_Click);
            // 
            // listeAppareil
            // 
            this.listeAppareil.FormattingEnabled = true;
            this.listeAppareil.Location = new System.Drawing.Point(207, 211);
            this.listeAppareil.Name = "listeAppareil";
            this.listeAppareil.Size = new System.Drawing.Size(120, 69);
            this.listeAppareil.TabIndex = 22;
            this.listeAppareil.Click += new System.EventHandler(this.listeAppareil_Click);
            this.listeAppareil.SelectedIndexChanged += new System.EventHandler(this.listeAppareil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Selectionnez une piece détachée\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Selectionnez un type de piece détachée";
            // 
            // listeTypePieceDetachee
            // 
            this.listeTypePieceDetachee.Enabled = false;
            this.listeTypePieceDetachee.FormattingEnabled = true;
            this.listeTypePieceDetachee.Location = new System.Drawing.Point(207, 314);
            this.listeTypePieceDetachee.Name = "listeTypePieceDetachee";
            this.listeTypePieceDetachee.Size = new System.Drawing.Size(120, 43);
            this.listeTypePieceDetachee.TabIndex = 24;
            this.listeTypePieceDetachee.Click += new System.EventHandler(this.listeTypePieceDetachee_Click);
            this.listeTypePieceDetachee.SelectedIndexChanged += new System.EventHandler(this.listeTypePieceDetachee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Selectionnez un appareil";
            // 
            // listePieces
            // 
            this.listePieces.FormattingEnabled = true;
            this.listePieces.Location = new System.Drawing.Point(207, 393);
            this.listePieces.Name = "listePieces";
            this.listePieces.Size = new System.Drawing.Size(120, 56);
            this.listePieces.TabIndex = 26;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(435, 0);
            this.webBrowser1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(681, 555);
            this.webBrowser1.TabIndex = 32;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // nbrFournisseur
            // 
            this.nbrFournisseur.AutoSize = true;
            this.nbrFournisseur.Location = new System.Drawing.Point(336, 66);
            this.nbrFournisseur.Name = "nbrFournisseur";
            this.nbrFournisseur.Size = new System.Drawing.Size(75, 26);
            this.nbrFournisseur.TabIndex = 36;
            this.nbrFournisseur.Text = "Nombre de\r\n fournisseurs : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "€";
            // 
            // labelPrix
            // 
            this.labelPrix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelPrix.Location = new System.Drawing.Point(336, 5);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(58, 20);
            this.labelPrix.TabIndex = 34;
            this.labelPrix.TextChanged += new System.EventHandler(this.labelPrix_TextChanged);
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Enabled = false;
            this.linkLabelSite.Location = new System.Drawing.Point(352, 45);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(61, 13);
            this.linkLabelSite.TabIndex = 33;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "Lien du site";
            this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite_LinkClicked);
            // 
            // flecheDroite
            // 
            this.flecheDroite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flecheDroite.Enabled = false;
            this.flecheDroite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flecheDroite.Image = global::Fournisseurs_Reconnect.Properties.Resources.fleche_droite;
            this.flecheDroite.Location = new System.Drawing.Point(832, 561);
            this.flecheDroite.Name = "flecheDroite";
            this.flecheDroite.Size = new System.Drawing.Size(37, 31);
            this.flecheDroite.TabIndex = 40;
            this.flecheDroite.UseVisualStyleBackColor = true;
            this.flecheDroite.Click += new System.EventHandler(this.flecheDroite_Click);
            // 
            // flecheGauche
            // 
            this.flecheGauche.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flecheGauche.Enabled = false;
            this.flecheGauche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flecheGauche.Image = global::Fournisseurs_Reconnect.Properties.Resources.fleche_gauche;
            this.flecheGauche.Location = new System.Drawing.Point(789, 561);
            this.flecheGauche.Name = "flecheGauche";
            this.flecheGauche.Size = new System.Drawing.Size(37, 31);
            this.flecheGauche.TabIndex = 39;
            this.flecheGauche.UseVisualStyleBackColor = true;
            this.flecheGauche.Click += new System.EventHandler(this.flecheGauche_Click);
            // 
            // boutonRetour
            // 
            this.boutonRetour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boutonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(29, 578);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(99, 34);
            this.boutonRetour.TabIndex = 38;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // boutonRecherche
            // 
            this.boutonRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRecherche.Location = new System.Drawing.Point(313, 584);
            this.boutonRecherche.Name = "boutonRecherche";
            this.boutonRecherche.Size = new System.Drawing.Size(75, 23);
            this.boutonRecherche.TabIndex = 37;
            this.boutonRecherche.Text = "Rechercher";
            this.boutonRecherche.UseVisualStyleBackColor = true;
            this.boutonRecherche.Click += new System.EventHandler(this.boutonRecherche_Click);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(313, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 12);
            this.progressBar1.TabIndex = 41;
            // 
            // RecherchePieceDetachee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(1114, 620);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.flecheDroite);
            this.Controls.Add(this.flecheGauche);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.boutonRecherche);
            this.Controls.Add(this.nbrFournisseur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listeMarques);
            this.Controls.Add(this.listePieces);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listeTypeAppareil);
            this.Controls.Add(this.listeTypePieceDetachee);
            this.Controls.Add(this.listeAppareil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RecherchePieceDetachee";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecherchePieceDetachee";
            this.Load += new System.EventHandler(this.RecherchePieceDetachee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listeMarques;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listeTypeAppareil;
        private System.Windows.Forms.ListBox listeAppareil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeTypePieceDetachee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listePieces;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label nbrFournisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelPrix;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.Button flecheDroite;
        private System.Windows.Forms.Button flecheGauche;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonRecherche;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}