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
            this.labelPrix = new System.Windows.Forms.Label();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.boutonRetour = new System.Windows.Forms.Button();
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
            this.listeMarques.TabIndex = 2;
            this.listeMarques.Click += new System.EventHandler(this.listeMarques_Click);
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
            this.listeTailleStockage.Location = new System.Drawing.Point(169, 278);
            this.listeTailleStockage.Name = "listeTailleStockage";
            this.listeTailleStockage.Size = new System.Drawing.Size(142, 43);
            this.listeTailleStockage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taille de stockage ( Go )";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoutonReconditionné);
            this.groupBox1.Controls.Add(this.boutonNeuf);
            this.groupBox1.Location = new System.Drawing.Point(70, 347);
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
            this.BoutonReconditionné.TabIndex = 1;
            this.BoutonReconditionné.Text = "Reconditionné";
            this.BoutonReconditionné.UseVisualStyleBackColor = true;
            // 
            // boutonNeuf
            // 
            this.boutonNeuf.AutoSize = true;
            this.boutonNeuf.Checked = true;
            this.boutonNeuf.Location = new System.Drawing.Point(18, 20);
            this.boutonNeuf.Name = "boutonNeuf";
            this.boutonNeuf.Size = new System.Drawing.Size(48, 17);
            this.boutonNeuf.TabIndex = 0;
            this.boutonNeuf.TabStop = true;
            this.boutonNeuf.Text = "Neuf";
            this.boutonNeuf.UseVisualStyleBackColor = true;
            // 
            // boutonRecherche
            // 
            this.boutonRecherche.Location = new System.Drawing.Point(338, 374);
            this.boutonRecherche.Name = "boutonRecherche";
            this.boutonRecherche.Size = new System.Drawing.Size(75, 23);
            this.boutonRecherche.TabIndex = 8;
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
            this.listeType.TabIndex = 9;
            this.listeType.Click += new System.EventHandler(this.listeType_Click);
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
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(565, 152);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(36, 13);
            this.labelPrix.TabIndex = 11;
            this.labelPrix.Text = "Prix ...";
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Location = new System.Drawing.Point(565, 197);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(0, 13);
            this.linkLabelSite.TabIndex = 12;
            this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite_LinkClicked);
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(39, 415);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(75, 23);
            this.boutonRetour.TabIndex = 13;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // RechercheAppareil
            // 
            this.AcceptButton = this.boutonRecherche;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.labelPrix);
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
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.Button boutonRetour;
    }
}