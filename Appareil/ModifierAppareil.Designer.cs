namespace Fournisseurs_Reconnect
{
    partial class ModifierAppareil
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
            this.nomModele = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listeMarques = new System.Windows.Forms.ListBox();
            this.listeTypes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tailleStockage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boutonModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomModele
            // 
            this.nomModele.Location = new System.Drawing.Point(259, 37);
            this.nomModele.Name = "nomModele";
            this.nomModele.Size = new System.Drawing.Size(280, 20);
            this.nomModele.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saisissez  un nouveau nom de modèle";
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 294);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(112, 23);
            this.boutonRetour.TabIndex = 15;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selectionnez une marque";
            // 
            // listeMarques
            // 
            this.listeMarques.FormattingEnabled = true;
            this.listeMarques.Location = new System.Drawing.Point(211, 91);
            this.listeMarques.Name = "listeMarques";
            this.listeMarques.Size = new System.Drawing.Size(120, 56);
            this.listeMarques.Sorted = true;
            this.listeMarques.TabIndex = 17;
            // 
            // listeTypes
            // 
            this.listeTypes.FormattingEnabled = true;
            this.listeTypes.Location = new System.Drawing.Point(211, 178);
            this.listeTypes.Name = "listeTypes";
            this.listeTypes.Size = new System.Drawing.Size(120, 56);
            this.listeTypes.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Selectionnez un type";
            // 
            // tailleStockage
            // 
            this.tailleStockage.Location = new System.Drawing.Point(489, 100);
            this.tailleStockage.Name = "tailleStockage";
            this.tailleStockage.Size = new System.Drawing.Size(100, 20);
            this.tailleStockage.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Saisissez une taille \r\nde stockage ( Go )";
            // 
            // boutonModifier
            // 
            this.boutonModifier.Location = new System.Drawing.Point(474, 253);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(75, 23);
            this.boutonModifier.TabIndex = 22;
            this.boutonModifier.Text = "Modifier";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // ModifierAppareil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(668, 329);
            this.ControlBox = false;
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tailleStockage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listeTypes);
            this.Controls.Add(this.listeMarques);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomModele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierAppareil";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier un appareil";
            this.Load += new System.EventHandler(this.ModifierAppareil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomModele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boutonRetour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeMarques;
        private System.Windows.Forms.ListBox listeTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tailleStockage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boutonModifier;
    }
}