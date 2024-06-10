namespace Fournisseurs_Reconnect.Affiliation.Objet_Connecté
{
    partial class DesaffilierObjetConnecte
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
            this.boutonAffilier = new System.Windows.Forms.Button();
            this.listeFournisseur = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listeMarque = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listeModele = new System.Windows.Forms.ListBox();
            this.listeTypeObjetCo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boutonAffilier
            // 
            this.boutonAffilier.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonAffilier.Location = new System.Drawing.Point(207, 263);
            this.boutonAffilier.Name = "boutonAffilier";
            this.boutonAffilier.Size = new System.Drawing.Size(87, 37);
            this.boutonAffilier.TabIndex = 27;
            this.boutonAffilier.Text = "Désaffilier";
            this.boutonAffilier.UseVisualStyleBackColor = true;
            this.boutonAffilier.Click += new System.EventHandler(this.boutonAffilier_Click);
            // 
            // listeFournisseur
            // 
            this.listeFournisseur.FormattingEnabled = true;
            this.listeFournisseur.Location = new System.Drawing.Point(189, 173);
            this.listeFournisseur.Name = "listeFournisseur";
            this.listeFournisseur.Size = new System.Drawing.Size(141, 43);
            this.listeFournisseur.Sorted = true;
            this.listeFournisseur.TabIndex = 25;
            this.listeFournisseur.Click += new System.EventHandler(this.listeFournisseur_Click);
            this.listeFournisseur.SelectedIndexChanged += new System.EventHandler(this.listeFournisseur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Selectionnez un fournisseur";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listeMarque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listeModele);
            this.groupBox1.Controls.Add(this.listeTypeObjetCo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(417, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 338);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectionnez un objet connecté à désaffilier";
            // 
            // listeMarque
            // 
            this.listeMarque.FormattingEnabled = true;
            this.listeMarque.Location = new System.Drawing.Point(207, 45);
            this.listeMarque.Name = "listeMarque";
            this.listeMarque.Size = new System.Drawing.Size(120, 56);
            this.listeMarque.TabIndex = 66;
            this.listeMarque.Click += new System.EventHandler(this.listeMarque_Click);
            this.listeMarque.SelectedIndexChanged += new System.EventHandler(this.listeMarque_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Selectionnez un modèle\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Selectionnez une marque";
            // 
            // listeModele
            // 
            this.listeModele.FormattingEnabled = true;
            this.listeModele.Location = new System.Drawing.Point(207, 223);
            this.listeModele.Name = "listeModele";
            this.listeModele.Size = new System.Drawing.Size(120, 56);
            this.listeModele.TabIndex = 70;
            // 
            // listeTypeObjetCo
            // 
            this.listeTypeObjetCo.Enabled = false;
            this.listeTypeObjetCo.FormattingEnabled = true;
            this.listeTypeObjetCo.Location = new System.Drawing.Point(207, 134);
            this.listeTypeObjetCo.Name = "listeTypeObjetCo";
            this.listeTypeObjetCo.Size = new System.Drawing.Size(120, 56);
            this.listeTypeObjetCo.TabIndex = 68;
            this.listeTypeObjetCo.Click += new System.EventHandler(this.listeTypeObjetCo_Click);
            this.listeTypeObjetCo.SelectedIndexChanged += new System.EventHandler(this.listeTypeObjetCo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Selectionnez un type d\'objet connecté";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 31);
            this.button2.TabIndex = 74;
            this.button2.Text = "< Retour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DesaffilierObjetConnecte
            // 
            this.AcceptButton = this.boutonAffilier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boutonAffilier);
            this.Controls.Add(this.listeFournisseur);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DesaffilierObjetConnecte";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Désaffilier un objet connecté";
            this.Load += new System.EventHandler(this.DesaffilierObjetConnecte_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonAffilier;
        private System.Windows.Forms.ListBox listeFournisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listeMarque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeModele;
        private System.Windows.Forms.ListBox listeTypeObjetCo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}