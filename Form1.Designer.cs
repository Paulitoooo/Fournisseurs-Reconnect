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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "test connexion BDD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAppareil
            // 
            this.buttonAppareil.Location = new System.Drawing.Point(129, 164);
            this.buttonAppareil.Name = "buttonAppareil";
            this.buttonAppareil.Size = new System.Drawing.Size(125, 23);
            this.buttonAppareil.TabIndex = 1;
            this.buttonAppareil.Text = "Recherche d\'appareil";
            this.buttonAppareil.UseVisualStyleBackColor = true;
            this.buttonAppareil.Click += new System.EventHandler(this.buttonAppareil_Click);
            // 
            // buttonAJouterMarque
            // 
            this.buttonAJouterMarque.Location = new System.Drawing.Point(557, 76);
            this.buttonAJouterMarque.Name = "buttonAJouterMarque";
            this.buttonAJouterMarque.Size = new System.Drawing.Size(172, 35);
            this.buttonAJouterMarque.TabIndex = 2;
            this.buttonAJouterMarque.Text = "Ajouter/Modifier/\r\nSupprimer une marque ";
            this.buttonAJouterMarque.UseVisualStyleBackColor = true;
            this.buttonAJouterMarque.Click += new System.EventHandler(this.buttonAJouterMarque_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ajouter/Modifier/\r\nSupprimer un fournisseur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Formulaire1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAJouterMarque);
            this.Controls.Add(this.buttonAppareil);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulaire1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAppareil;
        private System.Windows.Forms.Button buttonAJouterMarque;
        private System.Windows.Forms.Button button2;
    }
}

