namespace Fournisseurs_Reconnect.Affiliation
{
    partial class ModifierAffiliationAppareil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listeMarques = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listeType = new System.Windows.Forms.ListBox();
            this.listeModèles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listeTailleStockage = new System.Windows.Forms.ListBox();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.listeFournisseur = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boutonModifier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(358, 381);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectionnez un appareil";
            // 
            // listeMarques
            // 
            this.listeMarques.FormattingEnabled = true;
            this.listeMarques.Location = new System.Drawing.Point(181, 37);
            this.listeMarques.Name = "listeMarques";
            this.listeMarques.Size = new System.Drawing.Size(141, 43);
            this.listeMarques.Sorted = true;
            this.listeMarques.TabIndex = 1;
            this.listeMarques.Click += new System.EventHandler(this.listeMarques_Click);
            this.listeMarques.SelectedIndexChanged += new System.EventHandler(this.listeMarques_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Selectionnez un type d\'appareil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Selectionnez une marque";
            // 
            // listeType
            // 
            this.listeType.Cursor = System.Windows.Forms.Cursors.Default;
            this.listeType.Enabled = false;
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(181, 111);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(141, 82);
            this.listeType.TabIndex = 2;
            this.listeType.Click += new System.EventHandler(this.listeType_Click);
            this.listeType.SelectedIndexChanged += new System.EventHandler(this.listeType_Click);
            // 
            // listeModèles
            // 
            this.listeModèles.Enabled = false;
            this.listeModèles.FormattingEnabled = true;
            this.listeModèles.Location = new System.Drawing.Point(180, 230);
            this.listeModèles.Name = "listeModèles";
            this.listeModèles.Size = new System.Drawing.Size(142, 43);
            this.listeModèles.TabIndex = 3;
            this.listeModèles.Click += new System.EventHandler(this.listeModèles_Click);
            this.listeModèles.SelectedIndexChanged += new System.EventHandler(this.listeModèles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Taille de stockage ( Go )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Selectionnez un modèle";
            // 
            // listeTailleStockage
            // 
            this.listeTailleStockage.Enabled = false;
            this.listeTailleStockage.FormattingEnabled = true;
            this.listeTailleStockage.Location = new System.Drawing.Point(180, 320);
            this.listeTailleStockage.Name = "listeTailleStockage";
            this.listeTailleStockage.Size = new System.Drawing.Size(142, 43);
            this.listeTailleStockage.Sorted = true;
            this.listeTailleStockage.TabIndex = 4;
            this.listeTailleStockage.Click += new System.EventHandler(this.listeTailleStockage_Click);
            this.listeTailleStockage.SelectedIndexChanged += new System.EventHandler(this.listeTailleStockage_Click);
            // 
            // boutonRetour
            // 
            this.boutonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonRetour.Location = new System.Drawing.Point(23, 399);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(114, 31);
            this.boutonRetour.TabIndex = 22;
            this.boutonRetour.TabStop = false;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            // 
            // listeFournisseur
            // 
            this.listeFournisseur.Enabled = false;
            this.listeFournisseur.FormattingEnabled = true;
            this.listeFournisseur.Location = new System.Drawing.Point(584, 171);
            this.listeFournisseur.Name = "listeFournisseur";
            this.listeFournisseur.Size = new System.Drawing.Size(142, 43);
            this.listeFournisseur.TabIndex = 6;
            this.listeFournisseur.Click += new System.EventHandler(this.listeFournisseur_Click);
            this.listeFournisseur.SelectedIndexChanged += new System.EventHandler(this.listeFournisseur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionnez un fournisseur";
            // 
            // boutonModifier
            // 
            this.boutonModifier.Enabled = false;
            this.boutonModifier.Location = new System.Drawing.Point(589, 304);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(87, 37);
            this.boutonModifier.TabIndex = 25;
            this.boutonModifier.Text = "Modifier\r\nl\'affiliation\r\n";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonAffilier_Click);
            // 
            // ModifierAffiliationAppareil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(780, 430);
            this.ControlBox = false;
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeFournisseur);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierAffiliationAppareil";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Modifier l\'affiliation d\'un appareil";
            this.Load += new System.EventHandler(this.ModifierAffiliationAppareil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listeMarques;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listeType;
        private System.Windows.Forms.ListBox listeModèles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeTailleStockage;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.ListBox listeFournisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boutonModifier;
    }
}