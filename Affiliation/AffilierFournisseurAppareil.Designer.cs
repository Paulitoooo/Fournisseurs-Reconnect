namespace Fournisseurs_Reconnect.Affiliation
{
    partial class AffilierFournisseurAppareil
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listeType = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listeTailleStockage = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listeModèles = new System.Windows.Forms.ListBox();
            this.listeMarques = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BoutonReconditionné = new System.Windows.Forms.RadioButton();
            this.boutonNeuf = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.siteFournisseur = new System.Windows.Forms.TextBox();
            this.listeFournisseur = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boutonAffilier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(23, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "< Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Selectionnez un type d\'appareil";
            // 
            // listeType
            // 
            this.listeType.Cursor = System.Windows.Forms.Cursors.Default;
            this.listeType.Enabled = false;
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(181, 81);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(141, 43);
            this.listeType.TabIndex = 17;
            this.listeType.Click += new System.EventHandler(this.listeType_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Taille de stockage ( Go )";
            // 
            // listeTailleStockage
            // 
            this.listeTailleStockage.Enabled = false;
            this.listeTailleStockage.FormattingEnabled = true;
            this.listeTailleStockage.Location = new System.Drawing.Point(180, 288);
            this.listeTailleStockage.Name = "listeTailleStockage";
            this.listeTailleStockage.Size = new System.Drawing.Size(142, 43);
            this.listeTailleStockage.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Selectionnez un modèle";
            // 
            // listeModèles
            // 
            this.listeModèles.Enabled = false;
            this.listeModèles.FormattingEnabled = true;
            this.listeModèles.Location = new System.Drawing.Point(180, 145);
            this.listeModèles.Name = "listeModèles";
            this.listeModèles.Size = new System.Drawing.Size(142, 43);
            this.listeModèles.TabIndex = 13;
            this.listeModèles.Click += new System.EventHandler(this.listeModèles_Click);
            // 
            // listeMarques
            // 
            this.listeMarques.FormattingEnabled = true;
            this.listeMarques.Location = new System.Drawing.Point(181, 22);
            this.listeMarques.Name = "listeMarques";
            this.listeMarques.Size = new System.Drawing.Size(141, 43);
            this.listeMarques.Sorted = true;
            this.listeMarques.TabIndex = 12;
            this.listeMarques.Click += new System.EventHandler(this.listeMarques_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Selectionnez une marque";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.listeMarques);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listeType);
            this.groupBox1.Controls.Add(this.listeModèles);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listeTailleStockage);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 364);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectionnez un appareil  à affilier";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BoutonReconditionné);
            this.groupBox3.Controls.Add(this.boutonNeuf);
            this.groupBox3.Location = new System.Drawing.Point(122, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 52);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neuf ou reconditionné ?";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPrix);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.siteFournisseur);
            this.groupBox2.Controls.Add(this.listeFournisseur);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(417, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 364);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selectionnez un fournisseur à affilier à l\'appareil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Saisissez un prix";
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(161, 227);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(98, 20);
            this.textBoxPrix.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Saisissez le lien vers le produit";
            // 
            // siteFournisseur
            // 
            this.siteFournisseur.Location = new System.Drawing.Point(161, 105);
            this.siteFournisseur.Multiline = true;
            this.siteFournisseur.Name = "siteFournisseur";
            this.siteFournisseur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.siteFournisseur.Size = new System.Drawing.Size(176, 97);
            this.siteFournisseur.TabIndex = 20;
            // 
            // listeFournisseur
            // 
            this.listeFournisseur.FormattingEnabled = true;
            this.listeFournisseur.Location = new System.Drawing.Point(161, 37);
            this.listeFournisseur.Name = "listeFournisseur";
            this.listeFournisseur.Size = new System.Drawing.Size(141, 43);
            this.listeFournisseur.Sorted = true;
            this.listeFournisseur.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionnez un fournisseur";
            // 
            // boutonAffilier
            // 
            this.boutonAffilier.Location = new System.Drawing.Point(361, 394);
            this.boutonAffilier.Name = "boutonAffilier";
            this.boutonAffilier.Size = new System.Drawing.Size(87, 37);
            this.boutonAffilier.TabIndex = 21;
            this.boutonAffilier.Text = "Affilier";
            this.boutonAffilier.UseVisualStyleBackColor = true;
            this.boutonAffilier.Click += new System.EventHandler(this.boutonAffilier_Click);
            // 
            // AffilierFournisseurAppareil
            // 
            this.AcceptButton = this.boutonAffilier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.boutonAffilier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AffilierFournisseurAppareil";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affilier un fournisseur à un appareil";
            this.Load += new System.EventHandler(this.AffilierFournisseurAppareil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listeType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listeTailleStockage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeModèles;
        private System.Windows.Forms.ListBox listeMarques;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listeFournisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox siteFournisseur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button boutonAffilier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton BoutonReconditionné;
        private System.Windows.Forms.RadioButton boutonNeuf;
    }
}