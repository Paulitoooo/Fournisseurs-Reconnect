namespace Fournisseurs_Reconnect.Affiliation.Accessoire
{
    partial class AffilierAccessoire
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
            this.label3 = new System.Windows.Forms.Label();
            this.listeAccessoires = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listeType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeMarque = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.siteFournisseur = new System.Windows.Forms.TextBox();
            this.listeFournisseur = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boutonAffilier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Selectionnez un accessoire";
            // 
            // listeAccessoires
            // 
            this.listeAccessoires.FormattingEnabled = true;
            this.listeAccessoires.Location = new System.Drawing.Point(160, 199);
            this.listeAccessoires.Name = "listeAccessoires";
            this.listeAccessoires.Size = new System.Drawing.Size(117, 43);
            this.listeAccessoires.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selectionnez un type";
            // 
            // listeType
            // 
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(160, 117);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(117, 56);
            this.listeType.Sorted = true;
            this.listeType.TabIndex = 12;
            this.listeType.SelectedIndexChanged += new System.EventHandler(this.listeType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selectionnez une marque";
            // 
            // listeMarque
            // 
            this.listeMarque.FormattingEnabled = true;
            this.listeMarque.Location = new System.Drawing.Point(160, 35);
            this.listeMarque.Name = "listeMarque";
            this.listeMarque.Size = new System.Drawing.Size(117, 56);
            this.listeMarque.Sorted = true;
            this.listeMarque.TabIndex = 10;
            this.listeMarque.SelectedIndexChanged += new System.EventHandler(this.listeMarque_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listeType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listeMarque);
            this.groupBox1.Controls.Add(this.listeAccessoires);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 269);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectionnez un accessoire";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "< Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPrix);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.siteFournisseur);
            this.groupBox2.Controls.Add(this.listeFournisseur);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(344, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 269);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selectionnez un fournisseur à affilier à l\'objet connecté";
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
            this.textBoxPrix.Enabled = false;
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
            this.siteFournisseur.Enabled = false;
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
            this.listeFournisseur.SelectedIndexChanged += new System.EventHandler(this.listeFournisseur_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selectionnez un fournisseur";
            // 
            // boutonAffilier
            // 
            this.boutonAffilier.Location = new System.Drawing.Point(316, 324);
            this.boutonAffilier.Name = "boutonAffilier";
            this.boutonAffilier.Size = new System.Drawing.Size(87, 37);
            this.boutonAffilier.TabIndex = 75;
            this.boutonAffilier.Text = "Affilier";
            this.boutonAffilier.UseVisualStyleBackColor = true;
            this.boutonAffilier.Click += new System.EventHandler(this.boutonAffilier_Click);
            // 
            // AffilierAccessoire
            // 
            this.AcceptButton = this.boutonAffilier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(717, 392);
            this.ControlBox = false;
            this.Controls.Add(this.boutonAffilier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AffilierAccessoire";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Affilier un accessoire à un fournisseur";
            this.Load += new System.EventHandler(this.AffilierAccessoire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listeAccessoires;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeMarque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox siteFournisseur;
        private System.Windows.Forms.ListBox listeFournisseur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boutonAffilier;
    }
}