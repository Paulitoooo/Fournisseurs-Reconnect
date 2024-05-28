namespace Fournisseurs_Reconnect
{
    partial class AjouterModifierSupprimerAppareil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterModifierSupprimerAppareil));
            this.boutonRetour = new System.Windows.Forms.Button();
            this.boutonSupprimerMarque = new System.Windows.Forms.Button();
            this.boutonEnregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomModèle = new System.Windows.Forms.TextBox();
            this.listeMarques = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listeTypes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStockage = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BoutonReconditionné = new System.Windows.Forms.RadioButton();
            this.boutonNeuf = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 312);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(112, 23);
            this.boutonRetour.TabIndex = 54;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // boutonSupprimerMarque
            // 
            this.boutonSupprimerMarque.Location = new System.Drawing.Point(530, 290);
            this.boutonSupprimerMarque.Name = "boutonSupprimerMarque";
            this.boutonSupprimerMarque.Size = new System.Drawing.Size(138, 45);
            this.boutonSupprimerMarque.TabIndex = 53;
            this.boutonSupprimerMarque.Text = "Modifier/Supprimer un appareil ?";
            this.boutonSupprimerMarque.UseVisualStyleBackColor = true;
            this.boutonSupprimerMarque.Click += new System.EventHandler(this.boutonSupprimerMarque_Click);
            // 
            // boutonEnregistrer
            // 
            this.boutonEnregistrer.Location = new System.Drawing.Point(425, 301);
            this.boutonEnregistrer.Name = "boutonEnregistrer";
            this.boutonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.boutonEnregistrer.TabIndex = 52;
            this.boutonEnregistrer.Text = "Enregistrer";
            this.boutonEnregistrer.UseVisualStyleBackColor = true;
            this.boutonEnregistrer.Click += new System.EventHandler(this.boutonEnregistrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Saisissez un modèle\r\n\r\n";
            // 
            // textBoxNomModèle
            // 
            this.textBoxNomModèle.Enabled = false;
            this.textBoxNomModèle.Location = new System.Drawing.Point(188, 172);
            this.textBoxNomModèle.MaxLength = 150;
            this.textBoxNomModèle.Name = "textBoxNomModèle";
            this.textBoxNomModèle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxNomModèle.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxNomModèle.Size = new System.Drawing.Size(312, 20);
            this.textBoxNomModèle.TabIndex = 3;
            // 
            // listeMarques
            // 
            this.listeMarques.FormattingEnabled = true;
            this.listeMarques.Location = new System.Drawing.Point(188, 21);
            this.listeMarques.Name = "listeMarques";
            this.listeMarques.Size = new System.Drawing.Size(120, 56);
            this.listeMarques.TabIndex = 1;
            this.listeMarques.Click += new System.EventHandler(this.listeMarques_Click);
            this.listeMarques.SelectedIndexChanged += new System.EventHandler(this.listeMarques_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Slectionnez une marque";
            // 
            // listeTypes
            // 
            this.listeTypes.Enabled = false;
            this.listeTypes.FormattingEnabled = true;
            this.listeTypes.Location = new System.Drawing.Point(188, 94);
            this.listeTypes.Name = "listeTypes";
            this.listeTypes.Size = new System.Drawing.Size(120, 56);
            this.listeTypes.TabIndex = 2;
            this.listeTypes.Click += new System.EventHandler(this.listeTypes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Slectionnez un type d\'appareil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Saisissez un stockage ( Go )";
            // 
            // textBoxStockage
            // 
            this.textBoxStockage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxStockage.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.textBoxStockage.Location = new System.Drawing.Point(188, 212);
            this.textBoxStockage.Name = "textBoxStockage";
            this.textBoxStockage.Size = new System.Drawing.Size(37, 20);
            this.textBoxStockage.TabIndex = 4;
            this.textBoxStockage.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoutonReconditionné);
            this.groupBox1.Controls.Add(this.boutonNeuf);
            this.groupBox1.Location = new System.Drawing.Point(188, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 62;
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
            // 
            // boutonNeuf
            // 
            this.boutonNeuf.AutoSize = true;
            this.boutonNeuf.Checked = true;
            this.boutonNeuf.Location = new System.Drawing.Point(18, 20);
            this.boutonNeuf.Name = "boutonNeuf";
            this.boutonNeuf.Size = new System.Drawing.Size(48, 17);
            this.boutonNeuf.TabIndex = 9;
            this.boutonNeuf.TabStop = true;
            this.boutonNeuf.Text = "Neuf";
            this.boutonNeuf.UseVisualStyleBackColor = true;
            // 
            // AjouterModifierSupprimerAppareil
            // 
            this.AcceptButton = this.boutonEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(680, 347);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxStockage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listeTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeMarques);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.boutonSupprimerMarque);
            this.Controls.Add(this.boutonEnregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomModèle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterModifierSupprimerAppareil";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un appareil";
            this.Load += new System.EventHandler(this.AjouterModifierSupprimerAppareil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Button boutonSupprimerMarque;
        private System.Windows.Forms.Button boutonEnregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomModèle;
        private System.Windows.Forms.ListBox listeMarques;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textBoxStockage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BoutonReconditionné;
        private System.Windows.Forms.RadioButton boutonNeuf;
    }
}