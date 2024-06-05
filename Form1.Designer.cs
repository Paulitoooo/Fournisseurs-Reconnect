namespace Fournisseurs_Reconnect
{
    partial class Formulaire1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulaire1));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAppareil = new System.Windows.Forms.Button();
            this.buttonAJouterMarque = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.boutonPieceDetachee = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "test connexion BDD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAppareil
            // 
            this.buttonAppareil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAppareil.Location = new System.Drawing.Point(255, 293);
            this.buttonAppareil.Name = "buttonAppareil";
            this.buttonAppareil.Size = new System.Drawing.Size(125, 23);
            this.buttonAppareil.TabIndex = 1;
            this.buttonAppareil.Text = "Recherche d\'appareil";
            this.buttonAppareil.UseVisualStyleBackColor = true;
            this.buttonAppareil.Click += new System.EventHandler(this.buttonAppareil_Click);
            // 
            // buttonAJouterMarque
            // 
            this.buttonAJouterMarque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAJouterMarque.Location = new System.Drawing.Point(50, 24);
            this.buttonAJouterMarque.Name = "buttonAJouterMarque";
            this.buttonAJouterMarque.Size = new System.Drawing.Size(172, 35);
            this.buttonAJouterMarque.TabIndex = 2;
            this.buttonAJouterMarque.Text = "Ajouter/Modifier/\r\nSupprimer une marque\r\n";
            this.buttonAJouterMarque.UseVisualStyleBackColor = true;
            this.buttonAJouterMarque.Click += new System.EventHandler(this.buttonAJouterMarque_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(50, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ajouter/Modifier/\r\nSupprimer un fournisseur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(50, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ajouter/Modifier/\r\nSupprimer un appareil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.boutonPieceDetachee);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.buttonAJouterMarque);
            this.groupBox1.Location = new System.Drawing.Point(509, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 481);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(50, 242);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 35);
            this.button7.TabIndex = 6;
            this.button7.Text = "Ajouter/Modifier/Supprimmer un type de pièce détachée";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // boutonPieceDetachee
            // 
            this.boutonPieceDetachee.Location = new System.Drawing.Point(50, 188);
            this.boutonPieceDetachee.Name = "boutonPieceDetachee";
            this.boutonPieceDetachee.Size = new System.Drawing.Size(172, 35);
            this.boutonPieceDetachee.TabIndex = 5;
            this.boutonPieceDetachee.Text = "Ajouter/Modifier/Supprimmer une pièce détachée";
            this.boutonPieceDetachee.UseVisualStyleBackColor = true;
            this.boutonPieceDetachee.Click += new System.EventHandler(this.boutonPieceDetachee_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(50, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Affilier un fournisseur";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Location = new System.Drawing.Point(50, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "Désaffilier un fournisseur";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.Location = new System.Drawing.Point(50, 134);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 35);
            this.button6.TabIndex = 8;
            this.button6.Text = "Modifier une affiliation\r\n";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(181, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 190);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affiliations";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(255, 330);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 34);
            this.button8.TabIndex = 10;
            this.button8.Text = "Recherche de pièce détachée";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(50, 296);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(172, 35);
            this.button9.TabIndex = 7;
            this.button9.Text = "Ajouter/Modifier/Supprimer un objet connecté";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Formulaire1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 503);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAppareil);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulaire1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAppareil;
        private System.Windows.Forms.Button buttonAJouterMarque;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button boutonPieceDetachee;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

