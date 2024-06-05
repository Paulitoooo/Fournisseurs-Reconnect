namespace Fournisseurs_Reconnect.Objet_connecté
{
    partial class ModifierObjetConnecte
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
            this.label2 = new System.Windows.Forms.Label();
            this.listeTypeObjetCo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listeMarque = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomModele = new System.Windows.Forms.TextBox();
            this.boutonModifier = new System.Windows.Forms.Button();
            this.boutonRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Selectionnez un type d\'objet connecté";
            // 
            // listeTypeObjetCo
            // 
            this.listeTypeObjetCo.FormattingEnabled = true;
            this.listeTypeObjetCo.Location = new System.Drawing.Point(279, 133);
            this.listeTypeObjetCo.Name = "listeTypeObjetCo";
            this.listeTypeObjetCo.Size = new System.Drawing.Size(120, 56);
            this.listeTypeObjetCo.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Selectionnez une marque";
            // 
            // listeMarque
            // 
            this.listeMarque.FormattingEnabled = true;
            this.listeMarque.Location = new System.Drawing.Point(279, 44);
            this.listeMarque.Name = "listeMarque";
            this.listeMarque.Size = new System.Drawing.Size(120, 56);
            this.listeMarque.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Saisissez un nom de modèle";
            // 
            // textBoxNomModele
            // 
            this.textBoxNomModele.Location = new System.Drawing.Point(279, 224);
            this.textBoxNomModele.Name = "textBoxNomModele";
            this.textBoxNomModele.Size = new System.Drawing.Size(120, 20);
            this.textBoxNomModele.TabIndex = 68;
            // 
            // boutonModifier
            // 
            this.boutonModifier.Location = new System.Drawing.Point(301, 301);
            this.boutonModifier.Name = "boutonModifier";
            this.boutonModifier.Size = new System.Drawing.Size(75, 23);
            this.boutonModifier.TabIndex = 70;
            this.boutonModifier.Text = "Modifier";
            this.boutonModifier.UseVisualStyleBackColor = true;
            this.boutonModifier.Click += new System.EventHandler(this.boutonModifier_Click);
            // 
            // boutonRetour
            // 
            this.boutonRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonRetour.Location = new System.Drawing.Point(12, 345);
            this.boutonRetour.Name = "boutonRetour";
            this.boutonRetour.Size = new System.Drawing.Size(112, 23);
            this.boutonRetour.TabIndex = 71;
            this.boutonRetour.Text = "< Retour";
            this.boutonRetour.UseVisualStyleBackColor = true;
            this.boutonRetour.Click += new System.EventHandler(this.boutonRetour_Click);
            // 
            // ModifierObjetConnecte
            // 
            this.AcceptButton = this.boutonModifier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.boutonRetour;
            this.ClientSize = new System.Drawing.Size(678, 380);
            this.ControlBox = false;
            this.Controls.Add(this.boutonRetour);
            this.Controls.Add(this.boutonModifier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomModele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeTypeObjetCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeMarque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifierObjetConnecte";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier objet connecté";
            this.Load += new System.EventHandler(this.ModifierObjetConnecte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listeTypeObjetCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listeMarque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomModele;
        private System.Windows.Forms.Button boutonModifier;
        private System.Windows.Forms.Button boutonRetour;
    }
}