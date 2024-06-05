namespace Fournisseurs_Reconnect.Affiliation.Pièce_détachée
{
    partial class ModifierAffiliationPieceDetachee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.boutonModifier = new System.Windows.Forms.Button();
            this.listeFournisseur = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "< Retour";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.listeMarques);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listeTypeAppareil);
            this.groupBox1.Controls.Add(this.listeAppareil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listeTypePieceDetachee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listePieces);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 440);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selectionnez une pièce détachée";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Selectionnez une marque d\'appareil";
            // 
            // listeMarques
            // 
            this.listeMarques.FormattingEnabled = true;
            this.listeMarques.Location = new System.Drawing.Point(214, 41);
            this.listeMarques.Name = "listeMarques";
            this.listeMarques.Size = new System.Drawing.Size(120, 56);
            this.listeMarques.Sorted = true;
            this.listeMarques.TabIndex = 30;
            this.listeMarques.Click += new System.EventHandler(this.listeMarques_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Selectionnez un type d\'appareil";
            // 
            // listeTypeAppareil
            // 
            this.listeTypeAppareil.Enabled = false;
            this.listeTypeAppareil.FormattingEnabled = true;
            this.listeTypeAppareil.Location = new System.Drawing.Point(214, 114);
            this.listeTypeAppareil.Name = "listeTypeAppareil";
            this.listeTypeAppareil.Size = new System.Drawing.Size(120, 43);
            this.listeTypeAppareil.TabIndex = 28;
            this.listeTypeAppareil.Click += new System.EventHandler(this.listeTypeAppareil_Click);
            // 
            // listeAppareil
            // 
            this.listeAppareil.FormattingEnabled = true;
            this.listeAppareil.Location = new System.Drawing.Point(214, 185);
            this.listeAppareil.Name = "listeAppareil";
            this.listeAppareil.Size = new System.Drawing.Size(120, 69);
            this.listeAppareil.TabIndex = 22;
            this.listeAppareil.Click += new System.EventHandler(this.listeAppareil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Selectionnez une piece détachée\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Selectionnez un type de piece détachée";
            // 
            // listeTypePieceDetachee
            // 
            this.listeTypePieceDetachee.Enabled = false;
            this.listeTypePieceDetachee.FormattingEnabled = true;
            this.listeTypePieceDetachee.Location = new System.Drawing.Point(214, 288);
            this.listeTypePieceDetachee.Name = "listeTypePieceDetachee";
            this.listeTypePieceDetachee.Size = new System.Drawing.Size(120, 43);
            this.listeTypePieceDetachee.TabIndex = 24;
            this.listeTypePieceDetachee.Click += new System.EventHandler(this.listeTypePieceDetachee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Selectionnez un appareil";
            // 
            // listePieces
            // 
            this.listePieces.FormattingEnabled = true;
            this.listePieces.Location = new System.Drawing.Point(214, 367);
            this.listePieces.Name = "listePieces";
            this.listePieces.Size = new System.Drawing.Size(120, 56);
            this.listePieces.TabIndex = 26;
            this.listePieces.Click += new System.EventHandler(this.listePieces_Click);
            // 
            // boutonModifier
            // 
            this.boutonModifier.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonModifier.Location = new System.Drawing.Point(574, 300);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(87, 37);
            this.boutonModifier.TabIndex = 33;
            this.boutonModifier.Text = "Modifier";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // listeFournisseur
            // 
            this.listeFournisseur.FormattingEnabled = true;
            this.listeFournisseur.Location = new System.Drawing.Point(564, 197);
            this.listeFournisseur.Name = "listeFournisseur";
            this.listeFournisseur.Size = new System.Drawing.Size(141, 43);
            this.listeFournisseur.Sorted = true;
            this.listeFournisseur.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Selectionnez un fournisseur";
            // 
            // ModifierAffiliationPieceDetachee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.ControlBox = false;
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.listeFournisseur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "ModifierAffiliationPieceDetachee";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierAffiliationPieceDetachee";
            this.Load += new System.EventHandler(this.ModifierAffiliationPieceDetachee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button boutonModifier;
        private System.Windows.Forms.ListBox listeFournisseur;
        private System.Windows.Forms.Label label1;
    }
}